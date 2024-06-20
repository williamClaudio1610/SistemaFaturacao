using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
	internal class Produto
	{
		public int idProduto { get; set; }
		public String nomProduto { get; set; }
		public int qtdProduto { get; set; }
		public decimal precoProd { get; set; }
		public decimal ivaProduto { get; set; }

		public Produto(int idProd, String nomeP, int qtdProd, decimal precoProd, decimal iva)
		{
			this.idProduto = idProd;
			this.nomProduto = nomeP;
			this.qtdProduto = qtdProd;
			this.precoProd = precoProd;
			this.ivaProduto = iva;
		}
		public Produto() { }


		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public int NovoProduto(string nomeP, string descricao, double preco, int quantidadePorUnidade, string nomeFornecedor, string nomeCategoria, decimal valorIVA)
		{
			// Verificar se algum campo está vazio
			if (string.IsNullOrWhiteSpace(nomeP) || string.IsNullOrWhiteSpace(descricao) || preco <= 0 || quantidadePorUnidade <= 0 ||
				string.IsNullOrWhiteSpace(nomeFornecedor) || string.IsNullOrWhiteSpace(nomeCategoria) || valorIVA <= 0)
			{
				return 1; // Indica que há campos vazios ou valores inválidos
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					// Verificar se o fornecedor existe
					int fornecedorID;
					using (SqlCommand checkFornecedorCmd = new SqlCommand("sp_VerificarFornecedor", conn))
					{
						checkFornecedorCmd.CommandType = System.Data.CommandType.StoredProcedure;
						checkFornecedorCmd.Parameters.AddWithValue("@nomeFornecedor", nomeFornecedor.ToLower());
						var result = checkFornecedorCmd.ExecuteScalar();
						if (result == null)
						{
							return 2; // Indica que o fornecedor não existe
						}
						fornecedorID = Convert.ToInt32(result);
					}

					// Verificar se a categoria existe
					int categoriaID;
					using (SqlCommand checkCategoriaCmd = new SqlCommand("sp_VerificarCategoria", conn))
					{
						checkCategoriaCmd.CommandType = System.Data.CommandType.StoredProcedure;
						checkCategoriaCmd.Parameters.AddWithValue("@nomeCategoria", nomeCategoria.ToLower());
						var result = checkCategoriaCmd.ExecuteScalar();
						if (result == null)
						{
							return 3; // Indica que a categoria não existe
						}
						categoriaID = Convert.ToInt32(result);
					}

					// Verificar se a taxa de IVA existe
					int ivaID;
					using (SqlCommand checkIVACmd = new SqlCommand("sp_VerificarIVA", conn))
					{
						checkIVACmd.CommandType = System.Data.CommandType.StoredProcedure;
						checkIVACmd.Parameters.AddWithValue("@valorIVA", valorIVA);
						var result = checkIVACmd.ExecuteScalar();
						if (result == null)
						{
							return 4; // Indica que a taxa de IVA não existe
						}
						ivaID = Convert.ToInt32(result);
					}

					// Inserir o novo produto
					string insertQuery = "INSERT INTO Produtos (Nome, Descricao, Preco, QuantidadePorUnidade, FornecedorID, TaxaIVAID, CategoriaID) " +
										 "VALUES (@nomeP, @descricao, @preco, @quantidadePorUnidade, @fornecedorID, @ivaID, @categoriaID)";
					using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
					{
						insertCmd.Parameters.AddWithValue("@nomeP", nomeP);
						insertCmd.Parameters.AddWithValue("@descricao", descricao);
						insertCmd.Parameters.AddWithValue("@preco", preco);
						insertCmd.Parameters.AddWithValue("@quantidadePorUnidade", quantidadePorUnidade);
						insertCmd.Parameters.AddWithValue("@fornecedorID", fornecedorID);
						insertCmd.Parameters.AddWithValue("@ivaID", ivaID);
						insertCmd.Parameters.AddWithValue("@categoriaID", categoriaID);
						insertCmd.ExecuteNonQuery();
					}

					return 0; // Indica sucesso
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao adicionar o produto: " + ex.Message);
					return -1; // Indica um erro durante a operação
				}
			}
		}

	}	
}
