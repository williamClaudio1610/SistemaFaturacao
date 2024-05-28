using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
	public partial class UC_NovoProduto : UserControl
	{
		public UC_NovoProduto()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UC_Produtos uc = new UC_Produtos();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UC_Produtos uc = new UC_Produtos();
			Form telaAdmin = this.ParentForm as Form;
			if (telaAdmin != null)
			{
				TelaAdmin tl = (TelaAdmin)telaAdmin;
				tl.addUserControls(uc);
			}
		}
	}
}
