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

namespace WindowsFormsApp1
{
	public partial class TelaVenda : Form
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public String nomeFuncCx { get; set; }
		public TelaVenda()
		{

			InitializeComponent();
		
		}

		private void TelaVenda_Load(object sender, EventArgs e)
		{
			label3.Text  = nomeFuncCx;
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int produtoId;
			int quantidade;

			// Verificar se os campos estão preenchidos corretamente
			if (!int.TryParse(ProdIDtextBox1.Text, out produtoId))
			{
				MessageBox.Show("ID do Produto inválido.");
				return;
			}

			if (!int.TryParse(QtdtextBox2.Text, out quantidade) || quantidade <= 0)
			{
				MessageBox.Show("Quantidade inválida.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = "SELECT Nome, Preco, TaxaIVAID FROM Produtos WHERE ID = @produtoId";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@produtoId", produtoId);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string nomeProduto = reader["Nome"].ToString();
								decimal preco = Convert.ToDecimal(reader["Preco"]);
								decimal taxaIVA = Convert.ToDecimal(reader["TaxaIVAID"]);

								decimal valorIVA = taxaIVA;
								decimal total = (preco * quantidade) + valorIVA;

								dataGridView1.Rows.Add(produtoId, nomeProduto, quantidade, preco, IVA);
							}
							else
							{
								MessageBox.Show("Produto não encontrado.");
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}

		}
		private void calcularTotal(double valor)
		{
			double valorAnte;
			if (double.TryParse(textBox1.Text, out valorAnte))
			{
				double valor1 = valorAnte + valor;
				textBox1.Text = valor1.ToString("F2");
			}
			else
			{
				MessageBox.Show("Erro de valores");

			}
		}
	}
}
