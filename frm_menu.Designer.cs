namespace agendaSQL
{
	partial class frm_menu
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
			this.btn_add = new System.Windows.Forms.Button();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.btn_pesquisar = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.btn_visu = new System.Windows.Forms.Button();
			this.lbl_versao = new System.Windows.Forms.Label();
			this.btn_reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(94, 94);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(113, 41);
			this.btn_add.TabIndex = 0;
			this.btn_add.Text = "adicionar";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.Font = new System.Drawing.Font("LifeCraft", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.Location = new System.Drawing.Point(64, 0);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(172, 32);
			this.lbl_titulo.TabIndex = 1;
			this.lbl_titulo.Text = "AGENDA SQL";
			this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_pesquisar
			// 
			this.btn_pesquisar.Location = new System.Drawing.Point(94, 155);
			this.btn_pesquisar.Name = "btn_pesquisar";
			this.btn_pesquisar.Size = new System.Drawing.Size(113, 41);
			this.btn_pesquisar.TabIndex = 2;
			this.btn_pesquisar.Text = "pesquisar";
			this.btn_pesquisar.UseVisualStyleBackColor = true;
			this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(94, 214);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(113, 41);
			this.btn_sair.TabIndex = 3;
			this.btn_sair.Text = "sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// btn_visu
			// 
			this.btn_visu.Location = new System.Drawing.Point(94, 35);
			this.btn_visu.Name = "btn_visu";
			this.btn_visu.Size = new System.Drawing.Size(113, 41);
			this.btn_visu.TabIndex = 4;
			this.btn_visu.Text = "visualizar tudo";
			this.btn_visu.UseVisualStyleBackColor = true;
			this.btn_visu.Click += new System.EventHandler(this.btn_visu_Click);
			// 
			// lbl_versao
			// 
			this.lbl_versao.AutoSize = true;
			this.lbl_versao.Location = new System.Drawing.Point(128, 293);
			this.lbl_versao.Name = "lbl_versao";
			this.lbl_versao.Size = new System.Drawing.Size(35, 12);
			this.lbl_versao.TabIndex = 5;
			this.lbl_versao.Text = "versão ";
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(223, 298);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(76, 17);
			this.btn_reset.TabIndex = 6;
			this.btn_reset.Text = "reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// frm_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 327);
			this.ControlBox = false;
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.lbl_versao);
			this.Controls.Add(this.btn_visu);
			this.Controls.Add(this.btn_sair);
			this.Controls.Add(this.btn_pesquisar);
			this.Controls.Add(this.lbl_titulo);
			this.Controls.Add(this.btn_add);
			this.Font = new System.Drawing.Font("LifeCraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AGENDA";
			this.Load += new System.EventHandler(this.frm_menu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.Button btn_pesquisar;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_visu;
		private System.Windows.Forms.Label lbl_versao;
		private System.Windows.Forms.Button btn_reset;
	}
}

