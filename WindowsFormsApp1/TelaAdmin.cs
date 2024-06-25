using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;
using System.Data.SqlClient;
using System.Security.RightsManagement;


namespace WindowsFormsApp1
{
	public partial class TelaAdmin : Form
	{
		public String nomeAdmin {  get; set; }
		String connectionStringSQL = @"Data Source=WA_16;Integrated Security=True;Trust Server Certificate=True";
		public TelaAdmin()
		{
			InitializeComponent();
		}
		public void addUserControls(UserControl usercontrol)
		{
			usercontrol.Dock = DockStyle.Fill;
			panel4.Controls.Clear();
			panel4.Controls.Add(usercontrol);
			usercontrol.BringToFront();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{

			UC_Produtos uc = new UC_Produtos();
			addUserControls(uc);
			

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			UC_Usuarios uc = new UC_Usuarios();
			addUserControls(uc);

		}

		private void iconButton4_Click(object sender, EventArgs e)
		{
			UC_Fornecedoresssss uc = new UC_Fornecedoresssss();
			addUserControls(uc);

		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			UC_Taxassss uc = new UC_Taxassss();
			addUserControls(uc);
		}

		private void dashBtn_Click(object sender, EventArgs e)
		{
			UC_DashBoard uc = new UC_DashBoard();
			addUserControls(uc);
		}

		private void iconButton5_Click(object sender, EventArgs e)
		{
			UC_Categorias uc = new UC_Categorias();
			addUserControls(uc);
		}

		private void TelaAdmin_Load(object sender, EventArgs e)
		{
			label1.Text = nomeAdmin;

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void logOutBtn_Click(object sender, EventArgs e)
		{
			DialogResult confirmaLogOut = MessageBox.Show("Tem a certeza que pretende fazer log out do sistema ?", "Fazendo LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (confirmaLogOut == DialogResult.Yes)
			{
				MessageBox.Show("Fazendo logout, até a próxima venda");
				this.Hide();
				TelaLogin tl = new TelaLogin();
				tl.Show();
				return;
			}
		}
	}

}
