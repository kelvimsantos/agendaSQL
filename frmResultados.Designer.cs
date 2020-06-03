namespace agendaSQL
{
	partial class frmResultados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
			this.btn_sair = new System.Windows.Forms.Button();
			this.gralha_resultados = new System.Windows.Forms.DataGridView();
			this.lbl_resultados = new System.Windows.Forms.Label();
			this.btn_apagar = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_refrescar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gralha_resultados)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(351, 292);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(75, 23);
			this.btn_sair.TabIndex = 0;
			this.btn_sair.Text = "sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// gralha_resultados
			// 
			this.gralha_resultados.AllowUserToAddRows = false;
			this.gralha_resultados.AllowUserToDeleteRows = false;
			this.gralha_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gralha_resultados.Location = new System.Drawing.Point(12, 12);
			this.gralha_resultados.Name = "gralha_resultados";
			this.gralha_resultados.ReadOnly = true;
			this.gralha_resultados.RowHeadersVisible = false;
			this.gralha_resultados.Size = new System.Drawing.Size(414, 242);
			this.gralha_resultados.TabIndex = 1;
			this.gralha_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gralha_resultados_CellClick);
			// 
			// lbl_resultados
			// 
			this.lbl_resultados.AutoSize = true;
			this.lbl_resultados.Location = new System.Drawing.Point(12, 277);
			this.lbl_resultados.Name = "lbl_resultados";
			this.lbl_resultados.Size = new System.Drawing.Size(35, 13);
			this.lbl_resultados.TabIndex = 2;
			this.lbl_resultados.Text = "label1";
			// 
			// btn_apagar
			// 
			this.btn_apagar.Location = new System.Drawing.Point(206, 292);
			this.btn_apagar.Name = "btn_apagar";
			this.btn_apagar.Size = new System.Drawing.Size(75, 23);
			this.btn_apagar.TabIndex = 3;
			this.btn_apagar.Text = "apagar";
			this.btn_apagar.UseVisualStyleBackColor = true;
			this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
			// 
			// btn_editar
			// 
			this.btn_editar.Location = new System.Drawing.Point(68, 292);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(75, 23);
			this.btn_editar.TabIndex = 4;
			this.btn_editar.Text = "editar";
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
			// 
			// btn_refrescar
			// 
			this.btn_refrescar.Location = new System.Drawing.Point(351, 260);
			this.btn_refrescar.Name = "btn_refrescar";
			this.btn_refrescar.Size = new System.Drawing.Size(75, 23);
			this.btn_refrescar.TabIndex = 5;
			this.btn_refrescar.Text = "refrescar";
			this.btn_refrescar.UseVisualStyleBackColor = true;
			this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
			// 
			// frmResultados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 327);
			this.ControlBox = false;
			this.Controls.Add(this.btn_refrescar);
			this.Controls.Add(this.btn_editar);
			this.Controls.Add(this.btn_apagar);
			this.Controls.Add(this.lbl_resultados);
			this.Controls.Add(this.gralha_resultados);
			this.Controls.Add(this.btn_sair);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmResultados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmResultados";
			this.Load += new System.EventHandler(this.frmResultados_Load);
			((System.ComponentModel.ISupportInitialize)(this.gralha_resultados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.DataGridView gralha_resultados;
		private System.Windows.Forms.Label lbl_resultados;
		private System.Windows.Forms.Button btn_apagar;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_refrescar;
	}
}