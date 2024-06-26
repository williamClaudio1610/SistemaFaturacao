using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
	public class Categoria
	{
		private string connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public int AdicionarCategoria(string nomeCategoria)
		{
			// Verificar se o nome da categoria está vazio
			if (string.IsNullOrWhiteSpace(nomeCategoria))
			{
				return 1; // Indica que o nome da categoria está vazio
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					// Verificar se a categoria já existe
					string checkQuery = "SELECT COUNT(*) FROM Categoria WHERE LOWER(Nome) = @nomeCategoria";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@nomeCategoria", nomeCategoria.ToLower());
						int categoriaCount = (int)checkCmd.ExecuteScalar();

						if (categoriaCount > 0)
						{
							return 2; // Indica que a categoria já existe
						}
					}

					// Inserir a nova categoria
					using (SqlCommand cmd = new SqlCommand("sp_InserirCategoria", conn))
					{
						cmd.CommandType = System.Data.CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@Nome", nomeCategoria);

						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							return 0;
						}

						return 0; // Indica sucesso
					}
				}
				catch (Exception ex)
				{
					return -1; // Indica um erro durante a operação
				}
			}
		}

		public List<string> ObterCategorias()
		{
			List<string> categorias = new List<string>();
			string connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = "SELECT Nome FROM Categoria";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								categorias.Add(reader["Nome"].ToString());
							}
						}
					}
				}
				catch (Exception ex)
				{
					return null;
				}
			}

			return categorias;
		}

	}

}
