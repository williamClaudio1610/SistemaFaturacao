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
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.UserControls
{
	public partial class UC_AddNovoUser : UserControl
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_AddNovoUser()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UC_Usuarios uc = new UC_Usuarios();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UC_Usuarios uc = new UC_Usuarios();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}

		}

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			String nomeUser;
			String emailUser;
			String senha;
			String tipoUser;

			String dominio;

			AdminRules admin = new AdminRules();


			nomeUser = NomeUsertextBox1.Text.Trim().ToLower();
			emailUser = String.Concat(nomeUser, "@sistema.com");
			senha = SenhatextBox1.Text.Trim().ToLower();
			tipoUser = TipoUserComboBox2.Text.Trim().ToLower();

			int recebe = admin.adicionarNovoFunc(nomeUser, emailUser, senha, tipoUser);
			if (recebe == 1)
			{
				MessageBox.Show("Todos os campos devem ser preenchidos.");

			}else if(recebe == 2){
				MessageBox.Show("O usuário já existe.");

			}
			else if(recebe == 3)
			{
				MessageBox.Show("Administrador adicionado com sucesso.");
				voltarATela();
			}
			else if(recebe == 4)
			{
				MessageBox.Show("Funcionário adicionado com sucesso.");
				voltarATela();
			}
			else
			{
				MessageBox.Show("Erro de Conexão");

			}
	
		}

		private void voltarATela()
		{
			UC_Usuarios uc = new UC_Usuarios();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}

		}
		
		private void FillComboBox()
		{
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = "SELECT Nome FROM Categoria";
					SqlCommand cmd = new SqlCommand(query, conn);
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						TipoUserComboBox2.Items.Add(reader["Nome"].ToString());
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}
		}

		private void UC_AddNovoUser_Load(object sender, EventArgs e)
		{
			TipoUserComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

			// Adiciona opções à ComboBox
			TipoUserComboBox2.Items.Add("Administrador");
			TipoUserComboBox2.Items.Add("FuncionarioCaixa");

		}

			


			private void TipoUserComboBox2_SelectedIndexChanged(object sender, EventArgs e)
			{
			
			}
		}
} 

