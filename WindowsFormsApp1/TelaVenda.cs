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
			// TODO: This line of code loads data into the 'sistemaFaturaDataSet2.Administrador' table. You can move, or remove it, as needed.
			label3.Text = nomeFuncCx;
			textBox1.Enabled = false;
			textBox5.Enabled = false;
			textBox7.Enabled = false;

			// Adicionar opções à combobox, se ainda não estiverem adicionadas
			guna2ComboBox1.Items.Clear();
			guna2ComboBox1.Items.Add("Multicaixa");
			guna2ComboBox1.Items.Add("Numerário (Cash)");

			// Definir valor inicial da combobox
			guna2ComboBox1.SelectedIndex = guna2ComboBox1.Items.IndexOf("Multicaixa");

			textBox4.Text = ValorDesconto.ToString("0.00");

			// Associar o evento KeyPress às TextBox para permitir apenas números
			QtdtextBox2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			ProdIDtextBox1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

			textBox4.TextChanged += new EventHandler(textBox4_TextChanged);
			textBox6.TextChanged += new EventHandler(textBox6_TextChanged);

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

		// Evento TextChanged para o campo de Desconto
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

		// Evento TextChanged para o campo de Valor Recebido
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

		//botao para finalizar venda
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

		// botao para adicionar produto ao DataGridView
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

								ValorTotalFinal = valorProd - ValorDesconto;
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
			DialogResult confirmaLogOut = MessageBox.Show("Tem a certeza que pretende fazer log out do sistema ?", "Fazendo LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(confirmaLogOut == DialogResult.Yes)
			{
				MessageBox.Show("Fazendo logout, até a próxima venda");
				this.Hide();
				TelaLogin tl = new TelaLogin();
				tl.Show();
				return;
			}
		}

		// botao para cancelar uma venda
		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult confirma = MessageBox.Show("Tem a certeza que pretende cancelar a venda ?", "Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(confirma == DialogResult.Yes) { 
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
			valorProd = 0;
			ValorTotalFinal = 0;
			textBox1.Text = valorProd.ToString("F2");
			textBox5.Text = ValorTotalFinal.ToString("F2");
			textBox4.Clear();
			textBox6.Clear();
			textBox7.Clear();
			}
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
			textBox1.Text = total.ToString("0.00 Kz");
			ValorTotalFinal = total - ValorDesconto;
			textBox5.Text = ValorTotalFinal.ToString("0.00 Kz");
		}


		private void button4_Click(object sender, EventArgs e)
		{
			List<Produto> listaProdutos = new List<Produto>();
			decimal totalVenda = 0;
			FaturarRelatorio proforma = new FaturarRelatorio();

			

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
			//string nomeFunci = label3.Text;
			string nomeClient = textBox2.Text.Trim();
			string nifCliente = textBox3.Text.Trim();

			proforma.gerarFaturaProforma(listaProdutos, nomeClient, nifCliente, ValorTotalFinal, ValorDesconto);
			dataGridView1.Rows.Clear();
			QtdtextBox2.Clear();
			ProdIDtextBox1.Clear();
		}

		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (guna2ComboBox1.Text.Equals("Multicaixa")){
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
	}
}
