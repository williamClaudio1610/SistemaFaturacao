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
		decimal valorRecebido = 0;
		decimal valorTroco = 0;

		private void TelaVenda_Load(object sender, EventArgs e)
		{
			label3.Text = nomeFuncCx;
			textBox1.Enabled = false;
			textBox5.Enabled = false;
			textBox7.Enabled = false;

			guna2ComboBox1.Items.Clear();
			guna2ComboBox1.Items.Add("Multicaixa");
			guna2ComboBox1.Items.Add("Numerário (Cash)");

			guna2ComboBox1.SelectedIndex = guna2ComboBox1.Items.IndexOf("Multicaixa");

			textBox4.Text = ValorDesconto.ToString("0.00");

			QtdtextBox2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			ProdIDtextBox1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

			textBox4.TextChanged += new EventHandler(textBox4_TextChanged);
			textBox6.TextChanged += new EventHandler(textBox6_TextChanged);

			DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
			deleteButton.Name = "Delete";
			deleteButton.HeaderText = "Excluir";
			deleteButton.Text = "Excluir";
			deleteButton.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(deleteButton);

			dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox4.Text, out decimal desconto))
			{
				ValorDesconto = desconto;
				AtualizarTotalAPagar();
			}
			else
			{
				ValorDesconto = 0;
			}
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox6.Text, out decimal recebido))
			{
				valorRecebido = recebido;
				valorTroco = valorRecebido - ValorTotalFinal;
				textBox7.Text = valorTroco.ToString("F2");
			}
			else
			{
				textBox7.Text = "0.00";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Não há produtos no carrinho.");
				return;
			}

			if (guna2ComboBox1.Text.Equals("Numerário (Cash)"))
			{
				if (!decimal.TryParse(textBox6.Text, out valorRecebido))
				{
					MessageBox.Show("Por favor, insira um valor válido no campo de valor recebido.");
					return;
				}

				if (valorRecebido < ValorTotalFinal)
				{
					MessageBox.Show("O valor recebido é insuficiente para completar a venda.");
					return;
				}

				valorTroco = valorRecebido - ValorTotalFinal;
				textBox7.Text = valorTroco.ToString("F2");
			}
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;

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

			string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			FaturarRelatorio faturarRelatorio = new FaturarRelatorio();
			faturarRelatorio.gerarFaturaRelatorioPDF(listaProdutos, nomeFunci, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);

			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
			ValorDesconto = 0;
			textBox1.Clear();
			textBox4.Text = ValorDesconto.ToString("0.00");
			ValorTotalFinal = 0;
			textBox5.Text = ValorTotalFinal.ToString("F2");
			valorRecebido = 0;
			valorTroco = 0;
			textBox6.Clear();
			textBox7.Clear();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int produtoId;
			int quantidade;

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

			if (!decimal.TryParse(textBox4.Text, out ValorDesconto) || ValorDesconto < 0)
			{
				MessageBox.Show("Desconto inválido");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = @"
				SELECT p.Nome, p.Preco, p.QuantidadePorUnidade, t.Taxa
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
								int quantidadePorUnidade = Convert.ToInt32(reader["QuantidadePorUnidade"]);

								if (quantidadePorUnidade <= 5)
								{
									MessageBox.Show("Produto com quantidade insuficiente em estoque.");
									return;
								}

								string nomeProduto = reader["Nome"].ToString();
								decimal preco = Convert.ToDecimal(reader["Preco"]);
								decimal IVA = Convert.ToDecimal(reader["Taxa"]);

								// Verificar se o produto já existe no DataGridView
								bool produtoExistente = false;
								foreach (DataGridViewRow row in dataGridView1.Rows)
								{
									if (Convert.ToInt32(row.Cells["ID_Produto"].Value) == produtoId)
									{
										int quantidadeAtual = Convert.ToInt32(row.Cells["Quantidade"].Value);
										int novaQuantidade = quantidadeAtual + quantidade;

										if (novaQuantidade > quantidadePorUnidade)
										{
											MessageBox.Show("Quantidade total do produto excede o limite em estoque.");
											return;
										}
										else
										{
											row.Cells["Quantidade"].Value = novaQuantidade;
											produtoExistente = true;
											break;
										}
									}
								}

								if (!produtoExistente)
								{
									dataGridView1.Rows.Add(produtoId, nomeProduto, quantidade, preco, IVA);
								}

								AtualizarValorProd();
								textBox1.Text = valorProd.ToString("F2");

								ValorTotalFinal = valorProd - ValorDesconto;
								textBox5.Text = ValorTotalFinal.ToString("F2");
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

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult confirma = MessageBox.Show("Tem a certeza que pretende cancelar a venda ?", "Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (confirma == DialogResult.Yes)
			{
				dataGridView1.Rows.Clear();
				QtdtextBox2.Clear();
				ProdIDtextBox1.Clear();
				ValorDesconto = 0;
				textBox1.Clear();
				textBox4.Text = ValorDesconto.ToString("0.00");
				ValorTotalFinal = 0;
				textBox5.Text = ValorTotalFinal.ToString("F2");
				valorRecebido = 0;
				valorTroco = 0;
				textBox6.Clear();
				textBox7.Clear();
			}
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
			{
				dataGridView1.Rows.RemoveAt(e.RowIndex);
				AtualizarValorProd();
				AtualizarTotalAPagar();
			}
		}

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

			textBox1.Text = total.ToString("0.00 Kz");
			ValorTotalFinal = total - ValorDesconto;
			textBox5.Text = ValorTotalFinal.ToString("0.00 Kz");
		}

		private void AtualizarValorProd()
		{
			valorProd = 0;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["Preco_UN"].Value != null && row.Cells["Quantidade"].Value != null)
				{
					decimal preco = Convert.ToDecimal(row.Cells["Preco_UN"].Value);
					int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
					valorProd += preco * quantidade;
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;
			FaturarRelatorio proforma = new FaturarRelatorio();

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

			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			proforma.gerarFaturaProforma(listaProdutos, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
			ValorDesconto = 0;
			textBox1.Clear();
			textBox4.Text = ValorDesconto.ToString("0.00");
			ValorTotalFinal = 0;
			textBox5.Text = ValorTotalFinal.ToString("F2");
			valorRecebido = 0;
			valorTroco = 0;
			textBox6.Clear();
			textBox7.Clear();
		}

		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (guna2ComboBox1.Text.Equals("Multicaixa"))
			{
				panel2.Visible = false;
			}
			else
			{
				panel2.Visible = true;
			}
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			valorTroco = valorRecebido - ValorTotalFinal;
			textBox7.Text = valorTroco.ToString("F2");
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
		}

		// Pré-visualização da Fatura
		private void button5_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;

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

			string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			FaturarRelatorio faturarRelatorio = new FaturarRelatorio();
			faturarRelatorio.gerarFaturaPreview(listaProdutos, nomeFunci, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);
		}

		private void textBox4_TextChanged_1(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox4.Text, out decimal desconto))
			{
				// Verificar se o desconto é maior que o valor total dos produtos
				if (desconto > valorProd)
				{
					MessageBox.Show("O desconto não pode ser maior que o valor total da compra.");
					desconto = valorProd;
					textBox4.Text = desconto.ToString("0.00");
				}
				ValorDesconto = desconto;
				AtualizarTotalAPagar();
			}
			else
			{
				ValorDesconto = 0;
				AtualizarTotalAPagar();
			}
		}
	}
}
