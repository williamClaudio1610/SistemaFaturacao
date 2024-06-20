/*
 using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp1.Classes;

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
		decimal valorProd = 0;
		decimal ValorTotalFinal = 0;
		decimal ValorDesconto = 0;

		private void TelaVenda_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'sistemaFaturaDataSet2.Administrador' table. You can move, or remove it, as needed.
            label3.Text  = nomeFuncCx;
			textBox1.Enabled = false;
			textBox5.Enabled = false;

			
			textBox4.Text = ValorDesconto.ToString("0.00");

		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;

			// Coletar os dados do DataGridView
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["ID_Produto"].Value != null)
				{
					int produtoId = Convert.ToInt32(row.Cells["ID_Produto"].Value);
					string nomeProduto = row.Cells["Nome_Produto"].Value.ToString();
					int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
					decimal preco = Convert.ToDecimal(row.Cells["Preco_UN"].Value);
					decimal IVA = Convert.ToDecimal(row.Cells["IVA"].Value);

					Produto produto = new Produto(produtoId, nomeProduto, quantidade, preco, IVA);

					listaProdutos.Add(produto);
					totalVenda += (preco * quantidade) + (preco * quantidade * IVA / 100);
				}
			}

			// Dados do funcionário e cliente
			string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			// Gerar fatura
			FaturarRelatorio faturarRelatorio = new FaturarRelatorio();
			faturarRelatorio.gerarFaturaRelatorioPDF(listaProdutos, nomeFunci, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);

			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			int produtoId;
			int quantidade;

			List<Produto> listaProdutos = new List<Produto>();

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
					string query = @"
                SELECT p.Nome, p.Preco, t.Taxa
                FROM Produtos p
                JOIN TaxasIVA t ON p.TaxaIVAID = t.ID
                WHERE p.ID = @produtoId";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@produtoId", produtoId);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string nomeProduto = reader["Nome"].ToString();
								decimal preco = Convert.ToDecimal(reader["Preco"]);
								decimal IVA = Convert.ToDecimal(reader["Taxa"]);

								dataGridView1.Rows.Add(produtoId, nomeProduto, quantidade, preco, IVA);

								
								valorProd= (quantidade * preco) + valorProd;
								textBox1.Text = valorProd.ToString("F2");

								ValorTotalFinal = valorProd + ValorDesconto;
								textBox5.Text = ValorTotalFinal.ToString();


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




		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fazendo logout, até a próxima venda");
			this.Hide();
			TelaLogin tl = new TelaLogin();
			tl.Show();
			return;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}
		// Método para permitir apenas números e teclas de controle
		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Permitir apenas números e teclas de controle (como backspace)
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Ignorar a tecla pressionada
			}
		}
	}
}
*/


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

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

		decimal valorProd = 0;
		decimal ValorTotalFinal = 0;
		decimal ValorDesconto = 0;

		private void TelaVenda_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sistemaFaturaDataSet2.Administrador' table. You can move, or remove it, as needed.
			label3.Text = nomeFuncCx;
			textBox1.Enabled = false;
			textBox5.Enabled = false;

			textBox4.Text = ValorDesconto.ToString("0.00");

			// Associar o evento KeyPress às TextBox para permitir apenas números
			QtdtextBox2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			ProdIDtextBox1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

			// Adicionar coluna de botão ao DataGridView
			DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
			deleteButton.Name = "Delete";
			deleteButton.HeaderText = "Excluir";
			deleteButton.Text = "Excluir";
			deleteButton.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(deleteButton);

			// Associar evento CellContentClick ao DataGridView
			dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;

			// Coletar os dados do DataGridView
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["ID_Produto"].Value != null)
				{
					int produtoId = Convert.ToInt32(row.Cells["ID_Produto"].Value);
					string nomeProduto = row.Cells["Nome_Produto"].Value.ToString();
					int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
					decimal preco = Convert.ToDecimal(row.Cells["Preco_UN"].Value);
					decimal IVA = Convert.ToDecimal(row.Cells["IVA"].Value);

					Produto produto = new Produto(produtoId, nomeProduto, quantidade, preco, IVA);

					listaProdutos.Add(produto);
					totalVenda += (preco * quantidade) + (preco * quantidade * IVA / 100);
				}
			}

			// Dados do funcionário e cliente
			string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			// Gerar fatura
			FaturarRelatorio faturarRelatorio = new FaturarRelatorio();
			faturarRelatorio.gerarFaturaRelatorioPDF(listaProdutos, nomeFunci, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);

			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}

		// botao para addicionar produto ao DataGridView
		private void button1_Click(object sender, EventArgs e)
		{
			int produtoId;
			int quantidade;

			List<Produto> listaProdutos = new List<Produto>();

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
					string query = @"
                SELECT p.Nome, p.Preco, t.Taxa
                FROM Produtos p
                JOIN TaxasIVA t ON p.TaxaIVAID = t.ID
                WHERE p.ID = @produtoId";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@produtoId", produtoId);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string nomeProduto = reader["Nome"].ToString();
								decimal preco = Convert.ToDecimal(reader["Preco"]);
								decimal IVA = Convert.ToDecimal(reader["Taxa"]);

								dataGridView1.Rows.Add(produtoId, nomeProduto, quantidade, preco, IVA);

								valorProd = (quantidade * preco) + valorProd;
								textBox1.Text = valorProd.ToString("F2");

								ValorTotalFinal = valorProd + ValorDesconto;
								textBox5.Text = ValorTotalFinal.ToString();
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

		// botao para fazer logout
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fazendo logout, até a próxima venda");
			this.Hide();
			TelaLogin tl = new TelaLogin();
			tl.Show();
			return;
		}

		// botao para cancelar uma venda
		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}

		// Método para permitir apenas números e teclas de controle
		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Permitir apenas números e teclas de controle (como backspace)
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Ignorar a tecla pressionada
			}
		}

		// Evento para excluir uma linha do DataGridView
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica se o clique foi na coluna de botões
			if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
			{
					// Exclui a linha
					dataGridView1.Rows.RemoveAt(e.RowIndex);

					// Atualiza o total a pagar, se necessário
					AtualizarTotalAPagar();
				
			}
		}

		// Método para atualizar o total a pagar
		private void AtualizarTotalAPagar()
		{
			decimal total = 0;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["Preco_UN"].Value != null && row.Cells["Quantidade"].Value != null)
				{
					decimal preco = Convert.ToDecimal(row.Cells["Preco_UN"].Value);
					int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
					total += preco * quantidade;
				}
			}

			// Atualiza o campo de total a pagar
			textBox5.Text = total.ToString("0.00 Kz");
		}
	}
}
