using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaSQL
{
	public partial class pesquisa : Form
	{	//criar um propriedade publica
		public string texto_pesquisa { get; set; }
		public bool cancelar { get; set; }

		//===========================================================
		public pesquisa()
		{
			InitializeComponent();
		}
		
		//===========================================================
		private void btn_pesquisa_Click(object sender, EventArgs e)
		{
			///executa a pesquisa ,mas apenas se existir text na txt box
			if (txtpesquisa.Text == "")
			{
				cancelar = true;
			}
			else 
			{
				texto_pesquisa = txtpesquisa.Text;
			}
			
			//texto_pesquisa  e cancela sao ,propriedades publicas acessivel em outras frm

			this.Close();
			
		}
		//===========================================================
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			//fecha o quadro, cancelando a operacao pesquisa
			cancelar = true;
			this.Close();
		}

		
	}
}
