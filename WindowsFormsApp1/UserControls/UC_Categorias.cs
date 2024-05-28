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

	public partial class UC_Categorias : UserControl
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_Categorias()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			string nomeCategoria = NomeCategTextBox.Text.Trim();

			Categoria categoria = new Categoria();
			int resultado = categoria.AdicionarCategoria(nomeCategoria);

			switch (resultado)
			{
				case 0:
					MessageBox.Show("Categoria adicionada com sucesso.");
					break;
				case 1:
					MessageBox.Show("O nome da categoria não pode estar vazio.");
					break;
				case 2:
					MessageBox.Show("A categoria já existe.");
					break;
				case -1:
					MessageBox.Show("Erro durante a operação.");
					break;
				default:
					MessageBox.Show("Resultado desconhecido.");
					break;
			}
		}


		private void UC_Categorias_Load(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM Categoria", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView1.DataSource = dt;
			}
		}
	}
}
