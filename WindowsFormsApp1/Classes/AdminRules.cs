using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Navigation;

namespace WindowsFormsApp1.Classes
{
	internal class AdminRules
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public int adicionarNovoFunc(String nome, String email, String senha, String tipo)
		{
			
			// Verificar se algum campo está vazio
			if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipo))
			{
				return 1; // Indica que há campos vazios
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					// Verificar se o usuário já existe na tabela FuncionarioCaixa
					string checkQuery = "SELECT COUNT(*) FROM FuncionarioCaixa WHERE LOWER(Nome) = @nome";
					string checkQueryAdmin = "SELECT COUNT(*) FROM Administrador WHERE LOWER(Nome) = @nome";

					int userCount = 0;

					// Verificar em FuncionarioCaixa
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@nome", nome);
						userCount = (int)checkCmd.ExecuteScalar();
					}

					// Se não encontrado em FuncionarioCaixa, verificar em Administrador
					if (userCount == 0)
					{
						using (SqlCommand checkCmdAdmin = new SqlCommand(checkQueryAdmin, conn))
						{
							checkCmdAdmin.Parameters.AddWithValue("@Nome", nome);
							userCount = (int)checkCmdAdmin.ExecuteScalar();
						}
					}

					// Se o usuário já existir em qualquer uma das tabelas, retornar com mensagem
					if (userCount > 0)
					{
						return 2; // Indica que o usuário já existe
					}

					// Inserir novo usuário conforme o tipo
						if (tipo.Trim().ToLower() == "administrador")
						{
							string insertQuery = "INSERT INTO Administrador (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";
							using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
							{
								insertCmd.Parameters.AddWithValue("@Nome", nome);
								insertCmd.Parameters.AddWithValue("@Email", email);
								insertCmd.Parameters.AddWithValue("@Senha", senha);
								insertCmd.ExecuteNonQuery();
							}
							return 3;
						}
						else
						{
							string insertQuery = "INSERT INTO FuncionarioCaixa (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";
							using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
							{
								insertCmd.Parameters.AddWithValue("@Nome", nome);
								insertCmd.Parameters.AddWithValue("@Email", email);
								insertCmd.Parameters.AddWithValue("@Senha", senha);
								insertCmd.ExecuteNonQuery();
							}
							return 4;
						}
					
						
					}
					catch (Exception ex)
				{
					return 6000; // Indica um erro durante a operação
				}
			}
			return 1000;
		}
	}

}
