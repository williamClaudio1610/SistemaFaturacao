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
using System.Xml.Serialization;
using WindowsFormsApp1.Classes;

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

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			String nomeFornecedor;
			String NifFornecedor;
			nomeFornecedor = NomeForntextBox1.Text.Trim().ToLower();
			NifFornecedor = NIFtextBox2.Text.ToLower();
			Fornecedores forn = new Fornecedores();

			int resul = forn.adicionarNovoFornecedor(nomeFornecedor, NifFornecedor);

			if(resul == 0)
			{
				MessageBox.Show("Campos vazios não são aceites !!");

			}
			else if(resul == 1)
			{
				MessageBox.Show("Fornecedor já existe");
			}else if(resul == 2)
			{
				MessageBox.Show("Fornecedor adicionado com sucesso !");
				voltarInicio();
			}
			else
			{
				MessageBox.Show("Erro na Base de Dados");
			}

			
		}

		private void NIFtextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void voltarInicio()
		{
			UC_Fornecedoresssss uc = new UC_Fornecedoresssss();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}

		}
	
	}
}
