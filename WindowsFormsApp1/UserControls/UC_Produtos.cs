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

	
	public partial class UC_Produtos : UserControl
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public UC_Produtos()
		{
			InitializeComponent();
		}

		private void UC_Produtos_Load(object sender, EventArgs e)
		{
			//carregar os dados para a datagrid
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				conn.Open();
				SqlDataAdapter sqlQuery = new SqlDataAdapter("SELECT * FROM vw_ProdutosDetalhados", conn);
				DataTable dt = new DataTable();
				sqlQuery.Fill(dt);
				dataGridView1.DataSource = dt;
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			UC_NovoProduto UC = new UC_NovoProduto();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(UC);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		
	}
}
