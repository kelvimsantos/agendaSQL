namespace agendaSQL
{
	partial class pesquisa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa));
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtpesquisa = new System.Windows.Forms.TextBox();
			this.btn_pesquisa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Location = new System.Drawing.Point(200, 52);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_cancelar.TabIndex = 0;
			this.btn_cancelar.Text = "cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "procurar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtpesquisa
			// 
			this.txtpesquisa.Location = new System.Drawing.Point(85, 12);
			this.txtpesquisa.MaxLength = 50;
			this.txtpesquisa.Name = "txtpesquisa";
			this.txtpesquisa.Size = new System.Drawing.Size(190, 20);
			this.txtpesquisa.TabIndex = 2;
			// 
			// btn_pesquisa
			// 
			this.btn_pesquisa.Location = new System.Drawing.Point(85, 52);
			this.btn_pesquisa.Name = "btn_pesquisa";
			this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
			this.btn_pesquisa.TabIndex = 3;
			this.btn_pesquisa.Text = "pesquisar";
			this.btn_pesquisa.UseVisualStyleBackColor = true;
			this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
			// 
			// pesquisa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 87);
			this.ControlBox = false;
			this.Controls.Add(this.btn_pesquisa);
			this.Controls.Add(this.txtpesquisa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_cancelar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "pesquisa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "pesquisa";
	
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtpesquisa;
		private System.Windows.Forms.Button btn_pesquisa;
	}
}