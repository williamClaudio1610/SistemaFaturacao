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

namespace WindowsFormsApp1.UserControls
{
	public partial class UC_Taxassss : UserControl
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_Taxassss()
		{
			InitializeComponent();
		}

		private void UC_Taxassss_Load(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM TaxasIVA", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView1.DataSource = dt;
			}

		}

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			string descricao = DescricaotextBox2.Text.Trim();
			string valor = valorTaxa.Text;

			if (string.IsNullOrEmpty(descricao))
			{
				MessageBox.Show("A descrição não pode estar vazia.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string insertQuery = "INSERT INTO TaxasIVA (Descricao, Taxa) VALUES (@Descricao, @Taxa)";
					using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
					{
						cmd.Parameters.AddWithValue("@Descricao", descricao);
						cmd.Parameters.AddWithValue("@Taxa", valor);

						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Taxa adicionada com sucesso.");
							// Atualizar o DataGridView
							SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM TaxasIVA", conn);
							DataTable dt = new DataTable();
							sqlQuery.Fill(dt);
							dataGridView1.DataSource = dt;
							voltarATela();
						}
						else
						{
							MessageBox.Show("Erro ao adicionar a taxa.");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}
		}
		private void voltarATela()
		{
			UC_Taxassss uc = new UC_Taxassss();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}

		}

		private void ValorTxatextBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
