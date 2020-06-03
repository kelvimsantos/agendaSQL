namespace agendaSQL
{
	partial class frm_add_editar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_editar));
			this.btn_fechar = new System.Windows.Forms.Button();
			this.btn_gravar = new System.Windows.Forms.Button();
			this.lbl_nome = new System.Windows.Forms.Label();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.txt_telefone = new System.Windows.Forms.TextBox();
			this.lbl_telefone = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_fechar
			// 
			this.btn_fechar.Location = new System.Drawing.Point(137, 180);
			this.btn_fechar.Name = "btn_fechar";
			this.btn_fechar.Size = new System.Drawing.Size(89, 22);
			this.btn_fechar.TabIndex = 0;
			this.btn_fechar.Text = "fechar";
			this.btn_fechar.UseVisualStyleBackColor = true;
			this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click_1);
			// 
			// btn_gravar
			// 
			this.btn_gravar.Location = new System.Drawing.Point(49, 180);
			this.btn_gravar.Name = "btn_gravar";
			this.btn_gravar.Size = new System.Drawing.Size(82, 22);
			this.btn_gravar.TabIndex = 1;
			this.btn_gravar.Text = "gravar";
			this.btn_gravar.UseVisualStyleBackColor = true;
			this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
			// 
			// lbl_nome
			// 
			this.lbl_nome.Location = new System.Drawing.Point(12, 9);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(227, 24);
			this.lbl_nome.TabIndex = 2;
			this.lbl_nome.Text = "nome";
			this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(12, 36);
			this.txt_nome.MaxLength = 50;
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(257, 20);
			this.txt_nome.TabIndex = 0;
			// 
			// txt_telefone
			// 
			this.txt_telefone.Location = new System.Drawing.Point(12, 109);
			this.txt_telefone.MaxLength = 20;
			this.txt_telefone.Name = "txt_telefone";
			this.txt_telefone.Size = new System.Drawing.Size(209, 20);
			this.txt_telefone.TabIndex = 3;
			// 
			// lbl_telefone
			// 
			this.lbl_telefone.Location = new System.Drawing.Point(12, 82);
			this.lbl_telefone.Name = "lbl_telefone";
			this.lbl_telefone.Size = new System.Drawing.Size(176, 24);
			this.lbl_telefone.TabIndex = 4;
			this.lbl_telefone.Text = "telefone";
			this.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frm_add_editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 233);
			this.Controls.Add(this.txt_telefone);
			this.Controls.Add(this.lbl_telefone);
			this.Controls.Add(this.txt_nome);
			this.Controls.Add(this.lbl_nome);
			this.Controls.Add(this.btn_gravar);
			this.Controls.Add(this.btn_fechar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frm_add_editar";
			this.Text = "frm_add_editar";
			this.Load += new System.EventHandler(this.frm_add_editar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_fechar;
		private System.Windows.Forms.Button btn_gravar;
		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.TextBox txt_telefone;
		private System.Windows.Forms.Label lbl_telefone;
	}
}