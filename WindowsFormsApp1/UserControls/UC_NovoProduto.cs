using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp1.Classes;

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

		private void addNovoPro_Click(object sender, EventArgs e)
		{
			String nome = NomeProdtextBox1.Text;
			String desc = DescricaotextBox2.Text;
			String qtd = QuantidadetextBox3.Text;
			String categ = categoriaComboBox2.Text;
			String forn = FornecedorcomboBox1.Text;
			String iva = IVAcomboBox2.Text;
			String preco = PrecoUNtextBox4.Text;

			// Variáveis para armazenar os valores convertidos
			int quantidade;
			double precoUnitario;

			// Tentar converter a quantidade
			if (!int.TryParse(qtd, out quantidade))
			{
				MessageBox.Show("Quantidade inválida. Por favor, insira um número inteiro.");
				return;
			}

			// Tentar converter o preço
			if (!double.TryParse(preco, out precoUnitario))
			{
				MessageBox.Show("Preço inválido. Por favor, insira um valor numérico.");
				return;
			}

			Produto prod = new Produto();
			int resul = prod.NovoProduto(nome, desc, precoUnitario, quantidade, forn, categ, iva);

			// Verificação do resultado e exibição de mensagem apropriada
			switch (resul)
			{
				case 0:
					MessageBox.Show("Produto adicionado com sucesso.");
					break;
				case 1:
					MessageBox.Show("Todos os campos devem ser preenchidos e os valores devem ser positivos.");
					break;
				case 2:
					MessageBox.Show("Fornecedor não encontrado.");
					break;
				case 3:
					MessageBox.Show("Categoria não encontrada.");
					break;
				case 4:
					MessageBox.Show("Taxa de IVA não encontrada.");
					break;
				case -1:
					MessageBox.Show("Erro durante a operação.");
					break;
				default:
					MessageBox.Show("Resultado desconhecido.");
					break;
			}
		}

		private void categoriaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		private void UC_NovoProduto_Load(object sender, EventArgs e)
		{
			Categoria categ = new Categoria();
			List<string> categorias = categ.ObterCategorias();
			categoriaComboBox2.Items.Clear();
			categoriaComboBox2.Items.AddRange(categorias.ToArray());

			Fornecedores forn = new Fornecedores();
			List<string> fornecedores = forn.ObterFornecedores();
			FornecedorcomboBox1.Items.Clear();
			FornecedorcomboBox1.Items.AddRange(fornecedores.ToArray());

			TaxasIVA iva = new TaxasIVA();
			List<decimal> valoresIVA = iva.ObterTaxasIVA();
			IVAcomboBox2.Items.Clear();
			foreach (var valor in valoresIVA)
			{
				IVAcomboBox2.Items.Add(valor);
			}
		}

		private void IVAcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
