using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace agendaSQL
{
	public partial class frmResultados : Form
	{
		int id_contato; //variavel para pegar id e apagar linha selecionada na grelha
		string item_pesquisa;  // para pesquisar e ver se ela e ="" ou se tem alguma coisa
		//========================================================

		public frmResultados(string item_pesquisa = "")  //string criada para passar´por parametro pesquisa
		{
			InitializeComponent();
			this.item_pesquisa = item_pesquisa;
		}

		//========================================================
		private void btn_sair_Click(object sender, EventArgs e)
		{
			//fecha o quadro
			this.Close();
		}

		//========================================================
		private void frmResultados_Load(object sender, EventArgs e)
		{
			//o metodo criado abaixo para ser executado ao carregar o form
			construir_grelha();
		}
		//=======metodo privado==========================================
		private void construir_grelha()
		{
			//constroi a grelha de registros
			//1 -fazer a ligação com os dados e fzer uma ligacao estilo datatable e depois relacionar a datagridview

			//ligar BD
			SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);  //a ligação voce usaa info da primeira classe
			ligacao.Open();
//===============
			//criar uma string para a pesquisa do botao pesquisa e passar item_pesquisa 
			string query = "SELECT * FROM contatos ";
			if (item_pesquisa != "")
			{
				query = "SELECT * FROM contatos " +
						"WHERE nome LIKE @item OR telefone LIKE @item ";
			}
					
			//criar um  parametro em comando para item
			SqlCeCommand comando = new SqlCeCommand();
			comando.Parameters.AddWithValue("@item","%"+ item_pesquisa + "%");

			comando.CommandText = query;
			comando.Connection = ligacao;

//==============
			SqlCeDataAdapter OperarioAD = new SqlCeDataAdapter();
			//=====selecioanr comando agora que criaado, para passar a query de pesquisa ja que comando tem a conexao
			OperarioAD.SelectCommand = comando;
			//em vez de deixa texto de selecionar coloco uma variavel que pode mudar se ele nao for vazio
			//adaptador carrega o texto do comando do DB, a conexao

			DataTable dadosinvi = new DataTable();
			//............
			OperarioAD.Fill(dadosinvi);
			//agora add a grelha resultados
			gralha_resultados.DataSource = dadosinvi; //fonte de dados vem da tabela invisivel preenchida

			//apresenta o n de registros da DB na label
			lbl_resultados.Text = "resultados : " + gralha_resultados.Rows.Count;
			//esconde colum id_cont|atualiza
			gralha_resultados.Columns[0].Visible = false;
			gralha_resultados.Columns[3].Visible = false;
			//pode ser usado index ou por string "nome" "atualizacao

			//alterar tamanho das colunas
			gralha_resultados.Columns["nome"].Width = calculcarLargura(60);   //calcula a porcentagem para preencher
			gralha_resultados.Columns["telefone"].Width = calculcarLargura(40);

			//controle disponivel

			btn_apagar.Enabled = false;

			btn_editar.Enabled = false;
		}
		//========================================================

		private void btn_apagar_Click(object sender, EventArgs e)
		{
			//eliminar linha selecionada
			//vai ter que apagar na bse de dados e reconstruir a datatable a apartir disso
			//id_contato???
			SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
			ligacao.Open();
			//criar um comando para eliminar registro
			SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos WHERE id_contato =" + id_contato,ligacao);
			//executar o comando
			comando.ExecuteNonQuery();

			comando.Dispose();
			ligacao.Dispose();
			//reconstruir a grelha de contatos
			//chama o metodo para carregar novamente 
			construir_grelha();


		}
		//========================================================

		private void gralha_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//evento da grelha cell click
			id_contato = Convert.ToInt16(gralha_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
			//id = convert.ToInt16(linhas da grelha [index da lin selec]dentro da linha a .celula["string da celula"].valor

			//ea agora ativa o botao com id selecionado

			btn_apagar.Enabled = true;

			btn_editar.Enabled = true;
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{
			//editar registro
			frm_add_editar f = new frm_add_editar(id_contato);
			//id_contato que diz se editar for = -1 nao edita se for qualquer outro  ,true, id contato nesse caso vai de 0..1.. ++
			f.ShowDialog();

			//atualizar a grelha de contatos apos a edição do contato

			construir_grelha();

		}

		private void btn_refrescar_Click(object sender, EventArgs e)
		{
			//volta a apresentar todos registros de contatos
			item_pesquisa = "";  //ele diz que o resultado = nada sendo assim quando for contruir grelha ela sera contruida sem pesquisa
			construir_grelha(); 
		}
		//
		private int calculcarLargura(int porcentagem)
		{
			int largura_grelha = gralha_resultados.Width - 20;   //larg grelha - 20 px do scroolbar
			int resultado = (largura_grelha * porcentagem) / 100;
			return resultado;
		}
	}
}
