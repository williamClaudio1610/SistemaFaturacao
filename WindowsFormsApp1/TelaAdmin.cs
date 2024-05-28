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


namespace WindowsFormsApp1
{
	public partial class TelaAdmin : Form
	{
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
	}

}
