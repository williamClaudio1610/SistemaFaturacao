namespace WindowsFormsApp1.UserControls
{
	partial class UC_Fornecedoresssss
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet = new WindowsFormsApp1.SistemaFaturaDataSet();
			this.fornecedoresTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.FornecedoresTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.NIFtextBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.NomeForntextBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(820, 55);
			this.panel1.TabIndex = 5;
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
			this.label3.Size = new System.Drawing.Size(176, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Fornecedores";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.fornecedoresBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(40, 122);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(346, 158);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
			// nIFDataGridViewTextBoxColumn
			// 
			this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
			this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
			this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
			this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fornecedoresBindingSource
			// 
			this.fornecedoresBindingSource.DataMember = "Fornecedores";
			this.fornecedoresBindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// sistemaFaturaDataSet
			// 
			this.sistemaFaturaDataSet.DataSetName = "SistemaFaturaDataSet";
			this.sistemaFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fornecedoresTableAdapter
			// 
			this.fornecedoresTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Fornecedores";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.addNovoPro);
			this.panel2.Controls.Add(this.NIFtextBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.NomeForntextBox1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(40, 320);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(457, 148);
			this.panel2.TabIndex = 8;
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
			// NIFtextBox2
			// 
			this.NIFtextBox2.Location = new System.Drawing.Point(167, 57);
			this.NIFtextBox2.Name = "NIFtextBox2";
			this.NIFtextBox2.Size = new System.Drawing.Size(246, 20);
			this.NIFtextBox2.TabIndex = 7;
			this.NIFtextBox2.TextChanged += new System.EventHandler(this.NIFtextBox2_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(117, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "NIF";
			// 
			// NomeForntextBox1
			// 
			this.NomeForntextBox1.Location = new System.Drawing.Point(167, 19);
			this.NomeForntextBox1.Name = "NomeForntextBox1";
			this.NomeForntextBox1.Size = new System.Drawing.Size(246, 20);
			this.NomeForntextBox1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nome Fornecedor";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(238, 25);
			this.label5.TabIndex = 9;
			this.label5.Text = "Adicionar novo fornecedor";
			// 
			// UC_Fornecedoresssss
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Fornecedoresssss";
			this.Size = new System.Drawing.Size(820, 513);
			this.Load += new System.EventHandler(this.UC_Fornecedoresssss_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource fornecedoresBindingSource;
		private SistemaFaturaDataSet sistemaFaturaDataSet;
		private SistemaFaturaDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox NIFtextBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NomeForntextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button addNovoPro;
	}
}
