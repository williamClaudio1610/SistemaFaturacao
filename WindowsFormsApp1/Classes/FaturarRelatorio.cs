using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApp1.Classes
{
	internal class FaturarRelatorio
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public void gerarFaturaRelatorioPDF(List<Produto> produtos, string nomeFunci, string nomeClient, string nifCliente, decimal totalVenda)
		{
			try
			{
				// Define o caminho onde o PDF será salvo
				string directoryPath = @"C:\Users\Admin\Documents\ISPTEC - Universidade\ISPTEC- 3º ano - 2023-2024\2º Semestre\Engenharia de Software 2\SistemaDeFatura - estável\Faturas";

				// Verifica se o diretório existe, se não, cria
				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}

				// Define o nome do arquivo com base na data e hora atuais
				string fileName = $"Fatura_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
				string filePath = Path.Combine(directoryPath, fileName);

				// Cria um documento PDF
				Document document = new Document();
				PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

				// Abre o documento para escrever
				document.Open();

				// Adiciona título
				var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
				document.Add(new Paragraph("Fatura de Venda", titleFont));
				document.Add(new Paragraph(" ")); // Adiciona uma linha em branco

				// Adiciona informações da fatura
				var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
				document.Add(new Paragraph($"Data: {DateTime.Now}", bodyFont));
				document.Add(new Paragraph($"Nome do Funcionário: {nomeFunci}", bodyFont));
				document.Add(new Paragraph($"Nome do Cliente: {nomeClient}", bodyFont));
				document.Add(new Paragraph($"NIF do Cliente: {nifCliente}", bodyFont));
				document.Add(new Paragraph(" ")); // Adiciona uma linha em branco

				// Adiciona detalhes dos produtos
				document.Add(new Paragraph("Detalhes dos Produtos:", bodyFont));
				PdfPTable table = new PdfPTable(5);
				table.AddCell("ID Produto");
				table.AddCell("Nome Produto");
				table.AddCell("Quantidade");
				table.AddCell("Preço Unitário");
				table.AddCell("IVA");

				foreach (Produto produto in produtos)
				{
					table.AddCell(produto.idProduto.ToString());
					table.AddCell(produto.nomProduto);
					table.AddCell(produto.qtdProduto.ToString());
					table.AddCell(produto.precoProd.ToString("Kz"));
					table.AddCell(produto.ivaProduto.ToString("Kz"));
				}

				document.Add(table);

				// Adiciona o total da venda
				document.Add(new Paragraph(" "));
				document.Add(new Paragraph($"Total da Venda: {totalVenda.ToString("kz")}", bodyFont));

				// Fecha o documento
				document.Close();
				registarVendaNaBD(nomeFunci, nomeClient, nifCliente, DateTime.Now, totalVenda);



				MessageBox.Show($"Fatura gerada com sucesso em: {filePath}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao gerar fatura: " + ex.Message);
			}
		}

		private void registarVendaNaBD(String nomeFunc, String nomeClient, String nifClient, DateTime dataVenda, decimal totalVenda) {
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					int funcionarioID = 0;
					string buscarFuncionarioQuery = "SELECT ID FROM FuncionarioCaixa WHERE Nome = @nomeFunc";
					using (SqlCommand buscarFuncionarioCmd = new SqlCommand(buscarFuncionarioQuery, conn))
					{
						buscarFuncionarioCmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
						object result = buscarFuncionarioCmd.ExecuteScalar();
						if (result != null)
						{
							funcionarioID = Convert.ToInt32(result);
						}
						else
						{
							MessageBox.Show("Funcionário não encontrado.");
							return;
						}
					}

					//dataVenda = DateTime.Now;
					string inserirVendaQuery = "INSERT INTO Vendas(FuncionarioID, NomeCliente, ClienteNIF, DataVenda, ValorTotal) " +
									   "VALUES (@funcionarioID, @nomeClient, @nifClient, @dataVenda, @totalVenda);";

					using (SqlCommand inserirVendaCmd = new SqlCommand(inserirVendaQuery, conn))
					{
						inserirVendaCmd.Parameters.AddWithValue("@funcionarioID", funcionarioID);
						inserirVendaCmd.Parameters.AddWithValue("@NomeCliente", nomeClient);
						inserirVendaCmd.Parameters.AddWithValue("@ClienteNIF", nifClient);
						inserirVendaCmd.Parameters.AddWithValue("@DataVenda", DateTime.Now);
						inserirVendaCmd.Parameters.AddWithValue("@ValorTotal", totalVenda);

						inserirVendaCmd.ExecuteNonQuery();
					}

					string atualizarVendasQuery = "UPDATE FuncionarioCaixa SET NumeroVendas = NumeroVendas + 1 WHERE ID = @funcionarioID";
					using (SqlCommand atualizarVendasCmd = new SqlCommand(atualizarVendasQuery, conn))
					{
						atualizarVendasCmd.Parameters.AddWithValue("@FuncionarioID", funcionarioID);
						atualizarVendasCmd.ExecuteNonQuery();
					}

					//MessageBox.Show("Venda registrada com sucesso.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao registrar venda: " + ex.Message);
				}

			
			}
		
		}
	}
}
