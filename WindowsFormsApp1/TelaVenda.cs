using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
	public partial class TelaVenda : Form
	{

		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public String nomeFuncCx { get; set; }
		public TelaVenda()
		{

			InitializeComponent();
		
		}

		private void TelaVenda_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'sistemaFaturaDataSet2.Administrador' table. You can move, or remove it, as needed.
            label3.Text  = nomeFuncCx;
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;

			// Coletar os dados do DataGridView
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["ID_Produto"].Value != null)
				{
					int produtoId = Convert.ToInt32(row.Cells["ID_Produto"].Value);
					string nomeProduto = row.Cells["Nome_Produto"].Value.ToString();
					int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
					decimal preco = Convert.ToDecimal(row.Cells["Preco_UN"].Value);
					decimal IVA = Convert.ToDecimal(row.Cells["IVA"].Value);

					Produto produto = new Produto(produtoId, nomeProduto, quantidade, preco, IVA);

					listaProdutos.Add(produto);
					totalVenda += (preco * quantidade) + (preco * quantidade * IVA / 100);
				}
			}

			// Dados do funcionário e cliente
			string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			// Gerar fatura
			FaturarRelatorio faturarRelatorio = new FaturarRelatorio();
			faturarRelatorio.gerarFaturaRelatorioPDF(listaProdutos, nomeFunci, nomeClient, nifCliente, totalVenda);

			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			int produtoId;
			int quantidade;

			List<Produto> listaProdutos = new List<Produto>();

			// Verificar se os campos estão preenchidos corretamente
			if (!int.TryParse(ProdIDtextBox1.Text, out produtoId))
			{
				MessageBox.Show("ID do Produto inválido.");
				return;
			}

			if (!int.TryParse(QtdtextBox2.Text, out quantidade) || quantidade <= 0)
			{
				MessageBox.Show("Quantidade inválida.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = @"
                SELECT p.Nome, p.Preco, t.Taxa
                FROM Produtos p
                JOIN TaxasIVA t ON p.TaxaIVAID = t.ID
                WHERE p.ID = @produtoId";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@produtoId", produtoId);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string nomeProduto = reader["Nome"].ToString();
								decimal preco = Convert.ToDecimal(reader["Preco"]);
								decimal IVA = Convert.ToDecimal(reader["Taxa"]);

								dataGridView1.Rows.Add(produtoId, nomeProduto, quantidade, preco, IVA);
							}
							else
							{
								MessageBox.Show("Produto não encontrado.");
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}
		}



		private void atualizarTotal(double valor)
		{
			double valorAnte;
			if (double.TryParse(textBox1.Text, out valorAnte))
			{
				double valor1 = valorAnte + valor;
				textBox1.Text = valor1.ToString("F2");
			}
			else
			{
				MessageBox.Show("Erro de valores");

			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fazendo logout, até a próxima venda");
			this.Hide();
			TelaLogin tl = new TelaLogin();
			tl.Show();
			return;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}
	}
}
