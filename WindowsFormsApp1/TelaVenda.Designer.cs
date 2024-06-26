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
			this.button4 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1019, 55);
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
			this.button2.BackColor = System.Drawing.Color.LimeGreen;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(872, 610);
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
			this.button3.Location = new System.Drawing.Point(38, 610);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 61);
			this.button3.TabIndex = 14;
			this.button3.Text = "Cancelar venda";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(613, 240);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Total:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(617, 263);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(163, 29);
			this.textBox1.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(786, 274);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 20);
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
			this.dataGridView1.Location = new System.Drawing.Point(21, 162);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(585, 323);
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
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBox2.Location = new System.Drawing.Point(617, 194);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(163, 29);
			this.textBox2.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(613, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 20);
			this.label6.TabIndex = 20;
			this.label6.Text = "Nome do cliente:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(832, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 20);
			this.label7.TabIndex = 22;
			this.label7.Text = "NIF do cliente:";
			// 
			// textBox3
			// 
			this.textBox3.AccessibleName = "NifCliente";
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(836, 194);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(163, 29);
			this.textBox3.TabIndex = 21;
			// 
			// sistemaFaturaDataSet2
			// 
			this.sistemaFaturaDataSet2.DataSetName = "SistemaFaturaDataSet2";
			this.sistemaFaturaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DarkCyan;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(194, 610);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(127, 61);
			this.button4.TabIndex = 23;
			this.button4.Text = "Proforma";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(836, 263);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(163, 31);
			this.textBox4.TabIndex = 24;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(834, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 25;
			this.label8.Text = "Desconto:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(829, 351);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 31);
			this.label10.TabIndex = 28;
			this.label10.Text = "Kz";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(617, 351);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(206, 31);
			this.textBox5.TabIndex = 27;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(612, 319);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(175, 29);
			this.label11.TabIndex = 26;
			this.label11.Text = "Total a pagar:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(612, 403);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(203, 25);
			this.label9.TabIndex = 29;
			this.label9.Text = "Forma de pagamento";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.textBox7);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.textBox6);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(617, 459);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(382, 100);
			this.panel2.TabIndex = 30;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(300, 67);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 20);
			this.label14.TabIndex = 21;
			this.label14.Text = "Kz";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(120, 58);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(163, 29);
			this.textBox7.TabIndex = 20;
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(51, 62);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 20);
			this.label15.TabIndex = 19;
			this.label15.Text = "Troco";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(300, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(29, 20);
			this.label13.TabIndex = 18;
			this.label13.Text = "Kz";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(120, 12);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(163, 29);
			this.textBox6.TabIndex = 17;
			this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(20, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 20);
			this.label12.TabIndex = 16;
			this.label12.Text = "Recebido";
			// 
			// guna2ComboBox1
			// 
			this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox1.ItemHeight = 30;
			this.guna2ComboBox1.Location = new System.Drawing.Point(810, 403);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.Size = new System.Drawing.Size(189, 36);
			this.guna2ComboBox1.TabIndex = 31;
			this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(357, 610);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(127, 61);
			this.button5.TabIndex = 32;
			this.button5.Text = "Preview Fatura";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// TelaVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1019, 695);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.guna2ComboBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button4);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TelaVenda";
			this.Text = "TelaVenda";
			this.Load += new System.EventHandler(this.TelaVenda_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label15;
	}
}