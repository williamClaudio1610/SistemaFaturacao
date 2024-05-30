using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class TelaVenda : Form
	{
		public String nomeFuncCx { get; set; }
		public TelaVenda()
		{

			InitializeComponent();
		
		}

		private void TelaVenda_Load(object sender, EventArgs e)
		{
			label3.Text  = nomeFuncCx;
			

		}
	}
}
