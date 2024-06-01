namespace WindowsFormsApp1
{
	partial class TelaVenda
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
			this.label1 = new System.Windows.Forms.Label();
			this.ProdIDtextBox1 = new System.Windows.Forms.TextBox();
			this.QtdtextBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Preco_UN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.sistemaFaturaDataSet2 = new WindowsFormsApp1.SistemaFaturaDataSet2();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID do Produto";
			// 
			// ProdIDtextBox1
			// 
			this.ProdIDtextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdIDtextBox1.Location = new System.Drawing.Point(38, 110);
			this.ProdIDtextBox1.Multiline = true;
			this.ProdIDtextBox1.Name = "ProdIDtextBox1";
			this.ProdIDtextBox1.Size = new System.Drawing.Size(133, 25);
			this.ProdIDtextBox1.TabIndex = 2;
			// 
			// QtdtextBox2
			// 
			this.QtdtextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QtdtextBox2.Location = new System.Drawing.Point(188, 110);
			this.QtdtextBox2.Multiline = true;
			this.QtdtextBox2.Name = "QtdtextBox2";
			this.QtdtextBox2.Size = new System.Drawing.Size(133, 25);
			this.QtdtextBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(188, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Quantidade";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(338, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "Adicionar";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(993, 55);
			this.panel1.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(940, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 35);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
			this.label3.Size = new System.Drawing.Size(154, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nome_User";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lime;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(766, 420);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 61);
			this.button2.TabIndex = 13;
			this.button2.Text = "Finalizar Venda";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(597, 420);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 61);
			this.button3.TabIndex = 14;
			this.button3.Text = "Cancelar venda";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(608, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(195, 31);
			this.label4.TabIndex = 15;
			this.label4.Text = "Total a pagar:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(614, 347);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 31);
			this.textBox1.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(772, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 31);
			this.label5.TabIndex = 17;
			this.label5.Text = "Kz";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Nome_Produto,
            this.Quantidade,
            this.Preco_UN,
            this.IVA});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
			this.dataGridView1.Location = new System.Drawing.Point(38, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(543, 265);
			this.dataGridView1.TabIndex = 18;
			// 
			// Id_Produto
			// 
			this.Id_Produto.HeaderText = "Id_Produto";
			this.Id_Produto.Name = "Id_Produto";
			this.Id_Produto.ReadOnly = true;
			// 
			// Nome_Produto
			// 
			this.Nome_Produto.HeaderText = "Nome_Produto";
			this.Nome_Produto.Name = "Nome_Produto";
			this.Nome_Produto.ReadOnly = true;
			// 
			// Quantidade
			// 
			this.Quantidade.HeaderText = "Quantidade";
			this.Quantidade.Name = "Quantidade";
			this.Quantidade.ReadOnly = true;
			// 
			// Preco_UN
			// 
			this.Preco_UN.HeaderText = "Preco_UN";
			this.Preco_UN.Name = "Preco_UN";
			this.Preco_UN.ReadOnly = true;
			// 
			// IVA
			// 
			this.IVA.HeaderText = "IVA";
			this.IVA.Name = "IVA";
			this.IVA.ReadOnly = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(614, 189);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(163, 24);
			this.textBox2.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(610, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 20);
			this.label6.TabIndex = 20;
			this.label6.Text = "Nome do cliente:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(610, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 20);
			this.label7.TabIndex = 22;
			this.label7.Text = "NIF do cliente:";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(614, 266);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(163, 24);
			this.textBox3.TabIndex = 21;
			// 
			// sistemaFaturaDataSet2
			// 
			this.sistemaFaturaDataSet2.DataSetName = "SistemaFaturaDataSet2";
			this.sistemaFaturaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TelaVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(993, 517);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.QtdtextBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ProdIDtextBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TelaVenda";
			this.Text = "TelaVenda";
			this.Load += new System.EventHandler(this.TelaVenda_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ProdIDtextBox1;
		private System.Windows.Forms.TextBox QtdtextBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private SistemaFaturaDataSet2 sistemaFaturaDataSet2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Preco_UN;
		private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
	}
}