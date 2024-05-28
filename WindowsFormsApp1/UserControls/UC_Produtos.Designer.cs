namespace WindowsFormsApp1.UserControls
{
	partial class UC_Produtos
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Produtos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridProdutos = new System.Windows.Forms.DataGridView();
			this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet = new WindowsFormsApp1.SistemaFaturaDataSet();
			this.produtosTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.ProdutosTableAdapter();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.sistemaFaturaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidadePorUnidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fornecedorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taxaIVAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(928, 61);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(33, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Produtos";
			// 
			// dataGridProdutos
			// 
			this.dataGridProdutos.AllowUserToDeleteRows = false;
			this.dataGridProdutos.AutoGenerateColumns = false;
			this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadePorUnidadeDataGridViewTextBoxColumn,
            this.fornecedorIDDataGridViewTextBoxColumn,
            this.taxaIVAIDDataGridViewTextBoxColumn,
            this.categoriaIDDataGridViewTextBoxColumn});
			this.dataGridProdutos.DataSource = this.produtosBindingSource1;
			this.dataGridProdutos.Location = new System.Drawing.Point(26, 79);
			this.dataGridProdutos.Name = "dataGridProdutos";
			this.dataGridProdutos.ReadOnly = true;
			this.dataGridProdutos.Size = new System.Drawing.Size(844, 223);
			this.dataGridProdutos.TabIndex = 1;
			this.dataGridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// produtosBindingSource
			// 
			this.produtosBindingSource.DataMember = "Produtos";
			this.produtosBindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// sistemaFaturaDataSet
			// 
			this.sistemaFaturaDataSet.DataSetName = "SistemaFaturaDataSet";
			this.sistemaFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// produtosTableAdapter
			// 
			this.produtosTableAdapter.ClearBeforeFill = true;
			// 
			// addNovoPro
			// 
			this.addNovoPro.BackColor = System.Drawing.Color.SteelBlue;
			this.addNovoPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNovoPro.Image = ((System.Drawing.Image)(resources.GetObject("addNovoPro.Image")));
			this.addNovoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNovoPro.Location = new System.Drawing.Point(26, 320);
			this.addNovoPro.Name = "addNovoPro";
			this.addNovoPro.Size = new System.Drawing.Size(241, 68);
			this.addNovoPro.TabIndex = 3;
			this.addNovoPro.Text = "Adicionar novo produto";
			this.addNovoPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNovoPro.UseVisualStyleBackColor = false;
			this.addNovoPro.Click += new System.EventHandler(this.addNovoPro_Click);
			// 
			// sistemaFaturaDataSetBindingSource
			// 
			this.sistemaFaturaDataSetBindingSource.DataSource = this.sistemaFaturaDataSet;
			this.sistemaFaturaDataSetBindingSource.Position = 0;
			// 
			// produtosBindingSource1
			// 
			this.produtosBindingSource1.DataMember = "Produtos";
			this.produtosBindingSource1.DataSource = this.sistemaFaturaDataSetBindingSource;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// precoDataGridViewTextBoxColumn
			// 
			this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
			this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
			this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
			this.precoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantidadePorUnidadeDataGridViewTextBoxColumn
			// 
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.DataPropertyName = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.HeaderText = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.Name = "quantidadePorUnidadeDataGridViewTextBoxColumn";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fornecedorIDDataGridViewTextBoxColumn
			// 
			this.fornecedorIDDataGridViewTextBoxColumn.DataPropertyName = "FornecedorID";
			this.fornecedorIDDataGridViewTextBoxColumn.HeaderText = "FornecedorID";
			this.fornecedorIDDataGridViewTextBoxColumn.Name = "fornecedorIDDataGridViewTextBoxColumn";
			this.fornecedorIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// taxaIVAIDDataGridViewTextBoxColumn
			// 
			this.taxaIVAIDDataGridViewTextBoxColumn.DataPropertyName = "TaxaIVAID";
			this.taxaIVAIDDataGridViewTextBoxColumn.HeaderText = "TaxaIVAID";
			this.taxaIVAIDDataGridViewTextBoxColumn.Name = "taxaIVAIDDataGridViewTextBoxColumn";
			this.taxaIVAIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoriaIDDataGridViewTextBoxColumn
			// 
			this.categoriaIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriaID";
			this.categoriaIDDataGridViewTextBoxColumn.HeaderText = "CategoriaID";
			this.categoriaIDDataGridViewTextBoxColumn.Name = "categoriaIDDataGridViewTextBoxColumn";
			this.categoriaIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// UC_Produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.addNovoPro);
			this.Controls.Add(this.dataGridProdutos);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Produtos";
			this.Size = new System.Drawing.Size(928, 516);
			this.Load += new System.EventHandler(this.UC_Produtos_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridProdutos;
		private System.Windows.Forms.BindingSource produtosBindingSource;
		private SistemaFaturaDataSet sistemaFaturaDataSet;
		private SistemaFaturaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePorUnidadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn taxaIVAIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource produtosBindingSource1;
		private System.Windows.Forms.BindingSource sistemaFaturaDataSetBindingSource;
	}
}
