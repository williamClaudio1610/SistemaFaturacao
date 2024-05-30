namespace WindowsFormsApp1.UserControls
{
	partial class UC_Usuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Usuarios));
			this.sistemaFaturaDataSet = new WindowsFormsApp1.SistemaFaturaDataSet();
			this.administradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.administradorTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.AdministradorTableAdapter();
			this.vwFuncionariosAdministradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet1 = new WindowsFormsApp1.SistemaFaturaDataSet1();
			this.administradorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.funcionarioCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.funcionarioCaixaTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.FuncionarioCaixaTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.vw_FuncionariosAdministradoresTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSet1TableAdapters.vw_FuncionariosAdministradoresTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.administradorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.administradorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.administradorTableAdapter1 = new WindowsFormsApp1.SistemaFaturaDataSet1TableAdapters.AdministradorTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.funcionarioCaixaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.funcionarioCaixaTableAdapter1 = new WindowsFormsApp1.SistemaFaturaDataSet1TableAdapters.FuncionarioCaixaTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vwFuncionariosAdministradoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioCaixaBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioCaixaBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// sistemaFaturaDataSet
			// 
			this.sistemaFaturaDataSet.DataSetName = "SistemaFaturaDataSet";
			this.sistemaFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// administradorBindingSource
			// 
			this.administradorBindingSource.DataMember = "Administrador";
			this.administradorBindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// administradorTableAdapter
			// 
			this.administradorTableAdapter.ClearBeforeFill = true;
			// 
			// vwFuncionariosAdministradoresBindingSource
			// 
			this.vwFuncionariosAdministradoresBindingSource.DataMember = "vw_FuncionariosAdministradores";
			this.vwFuncionariosAdministradoresBindingSource.DataSource = this.sistemaFaturaDataSet1;
			// 
			// sistemaFaturaDataSet1
			// 
			this.sistemaFaturaDataSet1.DataSetName = "SistemaFaturaDataSet1";
			this.sistemaFaturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// administradorBindingSource1
			// 
			this.administradorBindingSource1.DataMember = "Administrador";
			this.administradorBindingSource1.DataSource = this.sistemaFaturaDataSet;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Administradores";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// funcionarioCaixaBindingSource
			// 
			this.funcionarioCaixaBindingSource.DataMember = "FuncionarioCaixa";
			this.funcionarioCaixaBindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// funcionarioCaixaTableAdapter
			// 
			this.funcionarioCaixaTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(832, 55);
			this.panel1.TabIndex = 4;
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
			this.label3.Size = new System.Drawing.Size(119, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Usuários";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(651, 396);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 55);
			this.button1.TabIndex = 5;
			this.button1.Text = "Adicionar";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// vw_FuncionariosAdministradoresTableAdapter
			// 
			this.vw_FuncionariosAdministradoresTableAdapter.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Caixistas";
			// 
			// administradorBindingSource2
			// 
			this.administradorBindingSource2.DataMember = "Administrador";
			this.administradorBindingSource2.DataSource = this.sistemaFaturaDataSet;
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
            this.emailDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.administradorBindingSource3;
			this.dataGridView1.Location = new System.Drawing.Point(40, 110);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(445, 150);
			this.dataGridView1.TabIndex = 8;
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
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// administradorBindingSource3
			// 
			this.administradorBindingSource3.DataMember = "Administrador";
			this.administradorBindingSource3.DataSource = this.sistemaFaturaDataSet1;
			// 
			// administradorTableAdapter1
			// 
			this.administradorTableAdapter1.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.senhaDataGridViewTextBoxColumn1,
            this.numeroVendasDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.funcionarioCaixaBindingSource1;
			this.dataGridView2.Location = new System.Drawing.Point(40, 301);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(545, 150);
			this.dataGridView2.TabIndex = 9;
			// 
			// iDDataGridViewTextBoxColumn1
			// 
			this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
			this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// nomeDataGridViewTextBoxColumn1
			// 
			this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
			this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn1
			// 
			this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
			this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// senhaDataGridViewTextBoxColumn1
			// 
			this.senhaDataGridViewTextBoxColumn1.DataPropertyName = "Senha";
			this.senhaDataGridViewTextBoxColumn1.HeaderText = "Senha";
			this.senhaDataGridViewTextBoxColumn1.Name = "senhaDataGridViewTextBoxColumn1";
			this.senhaDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// numeroVendasDataGridViewTextBoxColumn
			// 
			this.numeroVendasDataGridViewTextBoxColumn.DataPropertyName = "NumeroVendas";
			this.numeroVendasDataGridViewTextBoxColumn.HeaderText = "NumeroVendas";
			this.numeroVendasDataGridViewTextBoxColumn.Name = "numeroVendasDataGridViewTextBoxColumn";
			this.numeroVendasDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// funcionarioCaixaBindingSource1
			// 
			this.funcionarioCaixaBindingSource1.DataMember = "FuncionarioCaixa";
			this.funcionarioCaixaBindingSource1.DataSource = this.sistemaFaturaDataSet1;
			// 
			// funcionarioCaixaTableAdapter1
			// 
			this.funcionarioCaixaTableAdapter1.ClearBeforeFill = true;
			// 
			// UC_Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "UC_Usuarios";
			this.Size = new System.Drawing.Size(832, 496);
			this.Load += new System.EventHandler(this.UC_Usuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vwFuncionariosAdministradoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioCaixaBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioCaixaBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SistemaFaturaDataSet sistemaFaturaDataSet;
		private System.Windows.Forms.BindingSource administradorBindingSource;
		private SistemaFaturaDataSetTableAdapters.AdministradorTableAdapter administradorTableAdapter;
		private System.Windows.Forms.BindingSource administradorBindingSource1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource funcionarioCaixaBindingSource;
		private SistemaFaturaDataSetTableAdapters.FuncionarioCaixaTableAdapter funcionarioCaixaTableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource vwFuncionariosAdministradoresBindingSource;
		private SistemaFaturaDataSet1 sistemaFaturaDataSet1;
		private SistemaFaturaDataSet1TableAdapters.vw_FuncionariosAdministradoresTableAdapter vw_FuncionariosAdministradoresTableAdapter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource administradorBindingSource2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource administradorBindingSource3;
		private SistemaFaturaDataSet1TableAdapters.AdministradorTableAdapter administradorTableAdapter1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroVendasDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource funcionarioCaixaBindingSource1;
		private SistemaFaturaDataSet1TableAdapters.FuncionarioCaixaTableAdapter funcionarioCaixaTableAdapter1;
	}
}
