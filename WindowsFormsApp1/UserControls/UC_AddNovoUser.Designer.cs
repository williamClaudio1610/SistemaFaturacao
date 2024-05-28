namespace WindowsFormsApp1.UserControls
{
	partial class UC_AddNovoUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddNovoUser));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SenhatextBox1 = new System.Windows.Forms.TextBox();
			this.TipoUserComboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.emailUsertextBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NomeUsertextBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
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
			this.panel1.Size = new System.Drawing.Size(865, 61);
			this.panel1.TabIndex = 2;
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
			this.label1.Size = new System.Drawing.Size(176, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Novo usuário";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(71, 370);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 52);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancelar";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// addNovoPro
			// 
			this.addNovoPro.BackColor = System.Drawing.Color.Lime;
			this.addNovoPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNovoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNovoPro.Location = new System.Drawing.Point(190, 370);
			this.addNovoPro.Name = "addNovoPro";
			this.addNovoPro.Size = new System.Drawing.Size(103, 52);
			this.addNovoPro.TabIndex = 7;
			this.addNovoPro.Text = "Adicionar";
			this.addNovoPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNovoPro.UseVisualStyleBackColor = false;
			this.addNovoPro.Click += new System.EventHandler(this.addNovoPro_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.SenhatextBox1);
			this.panel2.Controls.Add(this.TipoUserComboBox2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.emailUsertextBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.NomeUsertextBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(71, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(475, 239);
			this.panel2.TabIndex = 6;
			// 
			// SenhatextBox1
			// 
			this.SenhatextBox1.Location = new System.Drawing.Point(177, 134);
			this.SenhatextBox1.Name = "SenhatextBox1";
			this.SenhatextBox1.Size = new System.Drawing.Size(246, 20);
			this.SenhatextBox1.TabIndex = 17;
			// 
			// TipoUserComboBox2
			// 
			this.TipoUserComboBox2.FormattingEnabled = true;
			this.TipoUserComboBox2.Location = new System.Drawing.Point(177, 97);
			this.TipoUserComboBox2.Name = "TipoUserComboBox2";
			this.TipoUserComboBox2.Size = new System.Drawing.Size(246, 21);
			this.TipoUserComboBox2.TabIndex = 11;
			this.TipoUserComboBox2.SelectedIndexChanged += new System.EventHandler(this.TipoUserComboBox2_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(29, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Senha";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tipo de usuário";
			// 
			// emailUsertextBox2
			// 
			this.emailUsertextBox2.Location = new System.Drawing.Point(177, 61);
			this.emailUsertextBox2.Name = "emailUsertextBox2";
			this.emailUsertextBox2.Size = new System.Drawing.Size(246, 20);
			this.emailUsertextBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// NomeUsertextBox1
			// 
			this.NomeUsertextBox1.Location = new System.Drawing.Point(177, 23);
			this.NomeUsertextBox1.Name = "NomeUsertextBox1";
			this.NomeUsertextBox1.Size = new System.Drawing.Size(246, 20);
			this.NomeUsertextBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nome";
			// 
			// UC_AddNovoUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.addNovoPro);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "UC_AddNovoUser";
			this.Size = new System.Drawing.Size(865, 507);
			this.Load += new System.EventHandler(this.UC_AddNovoUser_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox SenhatextBox1;
		private System.Windows.Forms.ComboBox TipoUserComboBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox emailUsertextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NomeUsertextBox1;
		private System.Windows.Forms.Label label2;
	}
}
