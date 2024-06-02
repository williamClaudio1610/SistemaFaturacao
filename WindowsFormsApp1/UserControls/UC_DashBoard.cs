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
	public partial class UC_DashBoard : UserControl
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public UC_DashBoard()
		{
			InitializeComponent();
		}

		private void UC_DashBoard_Load(object sender, EventArgs e)
		{
			string usuarioComMaisVendas = ObterUsuarioComMaisVendas();
			label4.Text = usuarioComMaisVendas;

			// Obter o valor total das vendas
			decimal valorTotalVendas = ObterValorTotalVendas();
			label5.Text = valorTotalVendas.ToString("0.00 Kz");

		}

		private string ObterUsuarioComMaisVendas()
		{
			string nomeUsuario = "";
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = @"
                SELECT TOP 1 FuncionarioCaixa.Nome 
                FROM Vendas
                JOIN FuncionarioCaixa ON Vendas.FuncionarioID = FuncionarioCaixa.ID
                GROUP BY FuncionarioCaixa.Nome
                ORDER BY COUNT(*) DESC";

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						object result = cmd.ExecuteScalar();
						if (result != null)
						{
							nomeUsuario = result.ToString();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao obter usuário com mais vendas: " + ex.Message);
				}
			}
			return nomeUsuario;
		}

		private decimal ObterValorTotalVendas()
		{
			decimal valorTotal = 0;
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = "SELECT SUM(ValorTotal) FROM Vendas";

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						object result = cmd.ExecuteScalar();
						if (result != null && result != DBNull.Value)
						{
							valorTotal = Convert.ToDecimal(result);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao obter valor total das vendas: " + ex.Message);
				}
			}
			return valorTotal;
		}




	}
}
