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
	public partial class UC_Fornecedoresssss : UserControl
	{

		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_Fornecedoresssss()
		{
			InitializeComponent();
		}

		private void UC_Fornecedoresssss_Load(object sender, EventArgs e)
		{
			//carregar os dados para a datagrid
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM Fornecedores", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView1.DataSource = dt;
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
