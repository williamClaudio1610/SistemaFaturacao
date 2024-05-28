using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
	internal class Fornecedores
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public int adicionarNovoFornecedor(string nomeFornecedor, string nif)
		{
			// Verificar se algum campo está vazio
			if (string.IsNullOrWhiteSpace(nomeFornecedor) || string.IsNullOrWhiteSpace(nif))
			{
				return 0; // Indica que há campos vazios
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					// Verificar se o fornecedor já existe na base de dados
					string checkQuery = "SELECT COUNT(*) FROM Fornecedores WHERE LOWER(Nome) = @nome AND NIF = @nif";
					int fornecedorCount = 0;

					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@nome", nomeFornecedor.ToLower());
						checkCmd.Parameters.AddWithValue("@nif", nif);
						fornecedorCount = (int)checkCmd.ExecuteScalar();
					}

					// Se o fornecedor já existir, retornar com mensagem
					if (fornecedorCount > 0)
					{
						return 1; // Indica que o fornecedor já existe
					}

					// Inserir novo fornecedor
					string insertQuery = "INSERT INTO Fornecedores (Nome, NIF) VALUES (@nome, @nif)";
					using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
					{
						insertCmd.Parameters.AddWithValue("@nome", nomeFornecedor);
						insertCmd.Parameters.AddWithValue("@nif", nif);
						insertCmd.ExecuteNonQuery();
					}
					return 2; // fornecedor adicionado com sucesso
				}
				catch (Exception ex)
				{
					return 3; // Indica um erro durante a operação
				}
			}
		}

	}
}
