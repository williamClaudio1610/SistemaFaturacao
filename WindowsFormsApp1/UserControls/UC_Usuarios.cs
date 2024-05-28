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
	public partial class UC_Usuarios : UserControl
	{
		
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_Usuarios()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UC_AddNovoUser uc = new UC_AddNovoUser();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}
		}



		private void UC_Usuarios_Load(object sender, EventArgs e)
		{

			//carregar os dados para a datagrid
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM Administrador", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView1.DataSource = dt;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM FuncionarioCaixa", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView2.DataSource = dt;
			}

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
