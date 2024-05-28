namespace WindowsFormsApp1.UserControls
{
	partial class UC_Taxassss
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
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.valorTaxa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.taxasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet = new WindowsFormsApp1.SistemaFaturaDataSet();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.taxasIVATableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.TaxasIVATableAdapter();
			this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet2 = new WindowsFormsApp1.SistemaFaturaDataSet2();
			this.categoriaTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSet2TableAdapters.CategoriaTableAdapter();
			this.fKProdutosCatego6C190EBBBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produtosTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSet2TableAdapters.ProdutosTableAdapter();
			this.taxasIVABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.taxasIVATableAdapter1 = new WindowsFormsApp1.SistemaFaturaDataSet2TableAdapters.TaxasIVATableAdapter();
			this.DescricaotextBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.taxasIVABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taxaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKProdutosCatego6C190EBBBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 301);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "Adicionar novo IVA";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.DescricaotextBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.addNovoPro);
			this.panel2.Controls.Add(this.valorTaxa);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(40, 338);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(457, 148);
			this.panel2.TabIndex = 13;
			// 
			// addNovoPro
			// 
			this.addNovoPro.BackColor = System.Drawing.Color.LimeGreen;
			this.addNovoPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNovoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNovoPro.Location = new System.Drawing.Point(331, 104);
			this.addNovoPro.Name = "addNovoPro";
			this.addNovoPro.Size = new System.Drawing.Size(82, 32);
			this.addNovoPro.TabIndex = 10;
			this.addNovoPro.Text = "Adicionar";
			this.addNovoPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNovoPro.UseVisualStyleBackColor = false;
			this.addNovoPro.Click += new System.EventHandler(this.addNovoPro_Click);
			// 
			// valorTaxa
			// 
			this.valorTaxa.Location = new System.Drawing.Point(167, 18);
			this.valorTaxa.Name = "valorTaxa";
			this.valorTaxa.Size = new System.Drawing.Size(126, 20);
			this.valorTaxa.TabIndex = 5;
			this.valorTaxa.TextChanged += new System.EventHandler(this.ValorTxatextBox1_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(55, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Valor (%)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Taxas";
			// 
			// taxasIVABindingSource
			// 
			this.taxasIVABindingSource.DataMember = "TaxasIVA";
			this.taxasIVABindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// sistemaFaturaDataSet
			// 
			this.sistemaFaturaDataSet.DataSetName = "SistemaFaturaDataSet";
			this.sistemaFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(895, 55);
			this.panel1.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(33, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Taxas";
			// 
			// taxasIVATableAdapter
			// 
			this.taxasIVATableAdapter.ClearBeforeFill = true;
			// 
			// categoriaBindingSource
			// 
			this.categoriaBindingSource.DataMember = "Categoria";
			this.categoriaBindingSource.DataSource = this.sistemaFaturaDataSet2;
			// 
			// sistemaFaturaDataSet2
			// 
			this.sistemaFaturaDataSet2.DataSetName = "SistemaFaturaDataSet2";
			this.sistemaFaturaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// categoriaTableAdapter
			// 
			this.categoriaTableAdapter.ClearBeforeFill = true;
			// 
			// fKProdutosCatego6C190EBBBindingSource
			// 
			this.fKProdutosCatego6C190EBBBindingSource.DataMember = "FK__Produtos__Catego__6C190EBB";
			this.fKProdutosCatego6C190EBBBindingSource.DataSource = this.categoriaBindingSource;
			// 
			// produtosTableAdapter
			// 
			this.produtosTableAdapter.ClearBeforeFill = true;
			// 
			// taxasIVABindingSource1
			// 
			this.taxasIVABindingSource1.DataMember = "TaxasIVA";
			this.taxasIVABindingSource1.DataSource = this.sistemaFaturaDataSet2;
			// 
			// taxasIVATableAdapter1
			// 
			this.taxasIVATableAdapter1.ClearBeforeFill = true;
			// 
			// DescricaotextBox2
			// 
			this.DescricaotextBox2.Location = new System.Drawing.Point(167, 61);
			this.DescricaotextBox2.Name = "DescricaotextBox2";
			this.DescricaotextBox2.Size = new System.Drawing.Size(126, 20);
			this.DescricaotextBox2.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Descrição";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.taxaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.taxasIVABindingSource2;
			this.dataGridView1.Location = new System.Drawing.Point(40, 123);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(347, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// taxasIVABindingSource2
			// 
			this.taxasIVABindingSource2.DataMember = "TaxasIVA";
			this.taxasIVABindingSource2.DataSource = this.sistemaFaturaDataSet2;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			// 
			// taxaDataGridViewTextBoxColumn
			// 
			this.taxaDataGridViewTextBoxColumn.DataPropertyName = "Taxa";
			this.taxaDataGridViewTextBoxColumn.HeaderText = "Taxa";
			this.taxaDataGridViewTextBoxColumn.Name = "taxaDataGridViewTextBoxColumn";
			// 
			// UC_Taxassss
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Taxassss";
			this.Size = new System.Drawing.Size(895, 533);
			this.Load += new System.EventHandler(this.UC_Taxassss_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKProdutosCatego6C190EBBBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.taxasIVABindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.TextBox valorTaxa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource taxasIVABindingSource;
		private SistemaFaturaDataSet sistemaFaturaDataSet;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private SistemaFaturaDataSetTableAdapters.TaxasIVATableAdapter taxasIVATableAdapter;
		private System.Windows.Forms.BindingSource categoriaBindingSource;
		private SistemaFaturaDataSet2 sistemaFaturaDataSet2;
		private SistemaFaturaDataSet2TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
		private System.Windows.Forms.BindingSource taxasIVABindingSource1;
		private System.Windows.Forms.BindingSource fKProdutosCatego6C190EBBBindingSource;
		private SistemaFaturaDataSet2TableAdapters.ProdutosTableAdapter produtosTableAdapter;
		private SistemaFaturaDataSet2TableAdapters.TaxasIVATableAdapter taxasIVATableAdapter1;
		private System.Windows.Forms.TextBox DescricaotextBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn taxaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource taxasIVABindingSource2;
	}
}
