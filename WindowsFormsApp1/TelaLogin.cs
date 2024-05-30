using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
	public partial class TelaLogin : Form
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


		public TelaLogin()
		{
			InitializeComponent();
		}

		/*public void addUserControls(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(userControl);
			userControl.BringToFront();
		}
		*/


		private void TelaLogin_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nomeUser = textBox1.Text.Trim();
			string senha = textBox2.Text.Trim();

			if (string.IsNullOrWhiteSpace(nomeUser) || string.IsNullOrWhiteSpace(senha))
			{
				MessageBox.Show("Nome de usuário e senha não podem estar vazios.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					// Verificar se o usuário é administrador
					string adminQuery = "SELECT COUNT(*) FROM Administrador WHERE LOWER(Nome) = @nomeUser AND Senha = @senha";
					using (SqlCommand cmd = new SqlCommand(adminQuery, conn))
					{
						cmd.Parameters.AddWithValue("@nomeUser", nomeUser.ToLower());
						cmd.Parameters.AddWithValue("@senha", senha);
						int adminCount = (int)cmd.ExecuteScalar();

						if (adminCount > 0)
						{
							MessageBox.Show("Bem-vindo, Administrador!");
							this.Hide();
							TelaAdmin ta = new TelaAdmin();
							ta.nomeAdmin = nomeUser;
							ta.Show();

							return;
						}
					}

					// Verificar se o usuário é funcionário de caixa
					string caixaQuery = "SELECT COUNT(*) FROM FuncionarioCaixa WHERE LOWER(Nome) = @nomeUser AND Senha = @senha";
					using (SqlCommand cmd = new SqlCommand(caixaQuery, conn))
					{
						cmd.Parameters.AddWithValue("@nomeUser", nomeUser.ToLower());
						cmd.Parameters.AddWithValue("@senha", senha);
						int caixaCount = (int)cmd.ExecuteScalar();

						if (caixaCount > 0)
						{
							MessageBox.Show("Bem-vindo, Funcionário de Caixa!");
							this.Hide();
							TelaVenda tv = new TelaVenda();
							tv.nomeFuncCx = nomeUser;
							tv.Show();
							return;
						}
					}

					// Se não encontrou em nenhuma tabela
					MessageBox.Show("Usuário ou senha inválidos.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}

		}
	}
}
