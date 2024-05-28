namespace WindowsFormsApp1.UserControls
{
	partial class UC_NovoProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NovoProduto));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.PrecoUNtextBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.IVAcomboBox2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.FornecedorcomboBox1 = new System.Windows.Forms.ComboBox();
			this.categoriaComboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.QuantidadetextBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.DescricaotextBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NomeProdtextBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(937, 61);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(11, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 37);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(92, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Novo produto";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.PrecoUNtextBox4);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.IVAcomboBox2);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.FornecedorcomboBox1);
			this.panel2.Controls.Add(this.categoriaComboBox2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.QuantidadetextBox3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.DescricaotextBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.NomeProdtextBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(99, 108);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(475, 354);
			this.panel2.TabIndex = 2;
			// 
			// PrecoUNtextBox4
			// 
			this.PrecoUNtextBox4.Location = new System.Drawing.Point(177, 280);
			this.PrecoUNtextBox4.Name = "PrecoUNtextBox4";
			this.PrecoUNtextBox4.Size = new System.Drawing.Size(113, 20);
			this.PrecoUNtextBox4.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(28, 278);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 20);
			this.label8.TabIndex = 15;
			this.label8.Text = "Preço (Unidade)";
			// 
			// IVAcomboBox2
			// 
			this.IVAcomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.IVAcomboBox2.FormattingEnabled = true;
			this.IVAcomboBox2.Location = new System.Drawing.Point(177, 240);
			this.IVAcomboBox2.Name = "IVAcomboBox2";
			this.IVAcomboBox2.Size = new System.Drawing.Size(246, 21);
			this.IVAcomboBox2.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(28, 241);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "IVA %";
			// 
			// FornecedorcomboBox1
			// 
			this.FornecedorcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FornecedorcomboBox1.FormattingEnabled = true;
			this.FornecedorcomboBox1.Location = new System.Drawing.Point(177, 193);
			this.FornecedorcomboBox1.Name = "FornecedorcomboBox1";
			this.FornecedorcomboBox1.Size = new System.Drawing.Size(246, 21);
			this.FornecedorcomboBox1.TabIndex = 12;
			// 
			// categoriaComboBox2
			// 
			this.categoriaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoriaComboBox2.FormattingEnabled = true;
			this.categoriaComboBox2.Location = new System.Drawing.Point(177, 148);
			this.categoriaComboBox2.Name = "categoriaComboBox2";
			this.categoriaComboBox2.Size = new System.Drawing.Size(246, 21);
			this.categoriaComboBox2.TabIndex = 11;
			this.categoriaComboBox2.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox2_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(28, 191);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Fornecedor";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(28, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Categoria";
			// 
			// QuantidadetextBox3
			// 
			this.QuantidadetextBox3.Location = new System.Drawing.Point(177, 98);
			this.QuantidadetextBox3.Name = "QuantidadetextBox3";
			this.QuantidadetextBox3.Size = new System.Drawing.Size(83, 20);
			this.QuantidadetextBox3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Quantidade";
			// 
			// DescricaotextBox2
			// 
			this.DescricaotextBox2.Location = new System.Drawing.Point(177, 61);
			this.DescricaotextBox2.Name = "DescricaotextBox2";
			this.DescricaotextBox2.Size = new System.Drawing.Size(246, 20);
			this.DescricaotextBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Descrição";
			// 
			// NomeProdtextBox1
			// 
			this.NomeProdtextBox1.Location = new System.Drawing.Point(177, 23);
			this.NomeProdtextBox1.Name = "NomeProdtextBox1";
			this.NomeProdtextBox1.Size = new System.Drawing.Size(246, 20);
			this.NomeProdtextBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nome do produto";
			// 
			// addNovoPro
			// 
			this.addNovoPro.BackColor = System.Drawing.Color.LimeGreen;
			this.addNovoPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNovoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNovoPro.Location = new System.Drawing.Point(794, 410);
			this.addNovoPro.Name = "addNovoPro";
			this.addNovoPro.Size = new System.Drawing.Size(103, 52);
			this.addNovoPro.TabIndex = 4;
			this.addNovoPro.Text = "Adicionar";
			this.addNovoPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNovoPro.UseVisualStyleBackColor = false;
			this.addNovoPro.Click += new System.EventHandler(this.addNovoPro_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(675, 410);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 52);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancelar";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// UC_NovoProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addNovoPro);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "UC_NovoProduto";
			this.Size = new System.Drawing.Size(937, 555);
			this.Load += new System.EventHandler(this.UC_NovoProduto_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox QuantidadetextBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox DescricaotextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NomeProdtextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox categoriaComboBox2;
		private System.Windows.Forms.ComboBox FornecedorcomboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox IVAcomboBox2;
		private System.Windows.Forms.TextBox PrecoUNtextBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.Button button2;
	}
}
