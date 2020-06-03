using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;   //importar o name space
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaSQL
{
	//========================================================
	public partial class frm_menu : Form
	{

		//========================================================
		public frm_menu()
		{
			InitializeComponent();

			//apresentar versao ao inicializar o form menu
			lbl_versao.Text = vars.versao;    //usa a prpriedade  publica da classe vars
		}


		//========================================================
		private void btn_add_Click(object sender, EventArgs e)
		{
			frm_add_editar adicionar = new frm_add_editar();
			adicionar.ShowDialog();  //criar o carregamento do form como um objetoe mostra a caixa de dialogo
		}


		private void btn_pesquisar_Click(object sender, EventArgs e)
		{
			///abrir o quadro para iniciar a pesquisar pelo contato
			pesquisa pesquisa = new pesquisa();
			pesquisa.ShowDialog();

			//executa se o quadro nao for cancelado
			//	MessageBox.Show(pesquisa.texto_pesquisa);//texto_pesquisa ,propriedade publica acessivel
			if (pesquisa.cancelar)
			{
				pesquisa.Dispose();
				return;
			}
			else
			{
				//se nao  ,executa a pesquisa
				//vai abrir o frm apenas com a pesquisa especifica procurada 

				frmResultados resPesq = new frmResultados(pesquisa.texto_pesquisa);
				resPesq.ShowDialog();
			}
		}


		private void btn_sair_Click(object sender, EventArgs e)
		{
			//sair da applicação?
			if (MessageBox.Show("deseja realmente sair?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

			//sair mesmo da app
			Application.Exit();


		}


		//========================================================
		private void frm_menu_Load(object sender, EventArgs e)
		{

		}

		//========================================================
		private void btn_visu_Click(object sender, EventArgs e)
		{
			//abrir um quadro para apresentação de todos resultados
			frmResultados f = new frmResultados();
			f.ShowDialog();
		}
		//==============================================
		private void btn_reset_Click(object sender, EventArgs e)
		{
			//apagar todos os contatos da base de dados
			if (MessageBox.Show("deseja realmente eliminar todos os dados da agenda?", "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;
			SqlCeConnection ligacao = new SqlCeConnection("Data source =" + vars.base_dados);
			ligacao.Open();

			SqlCeCommand comando = new SqlCeCommand("DELETE  FROM contatos",ligacao);
			comando.ExecuteNonQuery();
			
			ligacao.Dispose();

			//mensagem que aparece apos apagar
			MessageBox.Show("todos dados eliminados com sucesso!"); 

		}
	}
}
