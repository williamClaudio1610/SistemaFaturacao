namespace WindowsFormsApp1.UserControls
{
	partial class UC_Categorias
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
			this.NomeCategTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet2 = new WindowsFormsApp1.SistemaFaturaDataSet2();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.categoriaTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSet2TableAdapters.CategoriaTableAdapter();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 318);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Adicionar nova categoria";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.addNovoPro);
			this.panel2.Controls.Add(this.NomeCategTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(40, 355);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(457, 148);
			this.panel2.TabIndex = 18;
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
			// NomeCategTextBox
			// 
			this.NomeCategTextBox.Location = new System.Drawing.Point(167, 48);
			this.NomeCategTextBox.Name = "NomeCategTextBox";
			this.NomeCategTextBox.Size = new System.Drawing.Size(246, 20);
			this.NomeCategTextBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome Categoria";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "Categorias";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.categoriaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(40, 140);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(244, 141);
			this.dataGridView1.TabIndex = 16;
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(884, 55);
			this.panel1.TabIndex = 15;
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
			this.label3.Size = new System.Drawing.Size(144, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Categorias";
			// 
			// categoriaTableAdapter
			// 
			this.categoriaTableAdapter.ClearBeforeFill = true;
			// 
			// UC_Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Categorias";
			this.Size = new System.Drawing.Size(884, 593);
			this.Load += new System.EventHandler(this.UC_Categorias_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.TextBox NomeCategTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource categoriaBindingSource;
		private SistemaFaturaDataSet2 sistemaFaturaDataSet2;
		private SistemaFaturaDataSet2TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
	}
}
