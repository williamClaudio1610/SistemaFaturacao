using System.Drawing;
using System.Windows.Forms;
using FontAwesome;


namespace WindowsFormsApp1
{
	partial class TelaAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdmin));
			this.panel2 = new System.Windows.Forms.Panel();
			this.iconButton5 = new FontAwesome.Sharp.IconButton();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.logOutBtn = new System.Windows.Forms.Button();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.dashBtn = new FontAwesome.Sharp.IconButton();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.logoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel2.Controls.Add(this.iconButton5);
			this.panel2.Controls.Add(this.iconButton4);
			this.panel2.Controls.Add(this.logOutBtn);
			this.panel2.Controls.Add(this.iconButton3);
			this.panel2.Controls.Add(this.iconButton2);
			this.panel2.Controls.Add(this.iconButton1);
			this.panel2.Controls.Add(this.dashBtn);
			this.panel2.Controls.Add(this.logoPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(9, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(171, 531);
			this.panel2.TabIndex = 1;
			// 
			// iconButton5
			// 
			this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton5.FlatAppearance.BorderSize = 0;
			this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton5.IconColor = System.Drawing.Color.Black;
			this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton5.IconSize = 16;
			this.iconButton5.Location = new System.Drawing.Point(0, 346);
			this.iconButton5.Name = "iconButton5";
			this.iconButton5.Size = new System.Drawing.Size(171, 40);
			this.iconButton5.TabIndex = 7;
			this.iconButton5.Text = "Categorias de Produtos";
			this.iconButton5.UseVisualStyleBackColor = true;
			this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
			// 
			// iconButton4
			// 
			this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton4.IconColor = System.Drawing.Color.Black;
			this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton4.IconSize = 16;
			this.iconButton4.Location = new System.Drawing.Point(0, 306);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Size = new System.Drawing.Size(171, 40);
			this.iconButton4.TabIndex = 6;
			this.iconButton4.Text = "Fornecedores";
			this.iconButton4.UseVisualStyleBackColor = true;
			this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
			// 
			// logOutBtn
			// 
			this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
			this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.logOutBtn.Location = new System.Drawing.Point(0, 477);
			this.logOutBtn.Name = "logOutBtn";
			this.logOutBtn.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
			this.logOutBtn.Size = new System.Drawing.Size(171, 54);
			this.logOutBtn.TabIndex = 0;
			this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.logOutBtn.UseVisualStyleBackColor = true;
			this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
			// 
			// iconButton3
			// 
			this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton3.IconColor = System.Drawing.Color.Black;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.IconSize = 16;
			this.iconButton3.Location = new System.Drawing.Point(0, 266);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Size = new System.Drawing.Size(171, 40);
			this.iconButton3.TabIndex = 5;
			this.iconButton3.Text = "Taxas";
			this.iconButton3.UseVisualStyleBackColor = true;
			this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
			// 
			// iconButton2
			// 
			this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton2.IconColor = System.Drawing.Color.Black;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 16;
			this.iconButton2.Location = new System.Drawing.Point(0, 226);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Size = new System.Drawing.Size(171, 40);
			this.iconButton2.TabIndex = 4;
			this.iconButton2.Text = "Usuários";
			this.iconButton2.UseVisualStyleBackColor = true;
			this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 16;
			this.iconButton1.Location = new System.Drawing.Point(0, 186);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(171, 40);
			this.iconButton1.TabIndex = 3;
			this.iconButton1.Text = "Produtos";
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// dashBtn
			// 
			this.dashBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.dashBtn.FlatAppearance.BorderSize = 0;
			this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dashBtn.IconChar = FontAwesome.Sharp.IconChar.None;
			this.dashBtn.IconColor = System.Drawing.Color.Black;
			this.dashBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.dashBtn.IconSize = 16;
			this.dashBtn.Location = new System.Drawing.Point(0, 146);
			this.dashBtn.Name = "dashBtn";
			this.dashBtn.Size = new System.Drawing.Size(171, 40);
			this.dashBtn.TabIndex = 2;
			this.dashBtn.Text = "DashBoard";
			this.dashBtn.UseVisualStyleBackColor = true;
			this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
			// 
			// logoPanel
			// 
			this.logoPanel.Controls.Add(this.pictureBox1);
			this.logoPanel.Controls.Add(this.label1);
			this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.logoPanel.Location = new System.Drawing.Point(0, 0);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(171, 146);
			this.logoPanel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(97, 104);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(24, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "AdminName";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel4
			// 
			this.panel4.AutoScroll = true;
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(180, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(839, 531);
			this.panel4.TabIndex = 3;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// TelaAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(1036, 531);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TelaAdmin";
			this.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrator";
			this.Load += new System.EventHandler(this.TelaAdmin_Load);
			this.panel2.ResumeLayout(false);
			this.logoPanel.ResumeLayout(false);
			this.logoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		
		private Panel panel2;
		private FontAwesome.Sharp.IconButton dashBtn;
		private Panel logoPanel;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private Label label1;
		private Panel panel4;
		private Button logOutBtn;
		private FontAwesome.Sharp.IconButton iconButton4;
		private FontAwesome.Sharp.IconButton iconButton5;
		private PictureBox pictureBox1;
	}

}