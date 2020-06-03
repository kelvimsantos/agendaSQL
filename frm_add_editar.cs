using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;   ///importar a biblioteca data para usar
using System.Windows.Forms;

namespace agendaSQL
{
	public partial class frm_add_editar : Form
	{
		//fazer o controle pelo id ele tem que ser carregado antes do resto da app
		int id_contato;
		bool editar;     //variavel para ter cpontrole se vai gravar em registro ja existente ou um novo

		public frm_add_editar(int id_contato = -1) //dentro do paremtro passamos essa variavel,ja que editar = false
		{//quando esse metodo for chamado pelo btn editar o valor de idcontato passado sera o da seleção do contato  ,!= -1
			//quando clicado no botao editar,  esse formulario será acionado
			InitializeComponent();
			this.id_contato = id_contato;     //a variavel de fora será igual a de dentro

			//definir se vou adicionar ou editar existente
			//if (id_contato == -1)
			//	editar = false;
			//else
			//	editar = true;   
			//tudo isso pode ser escrito de outra forma

			editar = id_contato == -1 ? false:true;
			//caso nao seja clicado no botao editar em frm resultados 
			//com contato selecionado terá o id selecioando será diferente de -1
		}

		private void frm_add_editar_Load(object sender, EventArgs e)
		{
			
			//apresenta dados do contato se o botao editar no frm for press , editar = true
			if (editar)  //se for verdadeiro, (!= -1) qualquer numero
				ApresentaContato();          //um metodo criado a baixo
		}


		//---------------------//----------------------//---------------------


		private void ApresentaContato() 
		{
			//APRESENTAR CONTATO QUE SERÁ EDITADO quando no botao editar 
			//criar uma nova conexao dentro desse metodo

			SqlCeConnection ligacao = new SqlCeConnection("Data Source =" + vars.base_dados);
			ligacao.Open();
			DataTable tabinvisi = new DataTable();
			SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato =" + id_contato, ligacao);//comando sql ,ligacao
			operario.Fill(tabinvisi);			
			ligacao.Dispose();

			//colcoar os dados no txtbox
			txt_nome.Text = tabinvisi.Rows[0]["nome"].ToString();//linha indice 0 e valor nome
			txt_telefone.Text = tabinvisi.Rows[0]["telefone"].ToString();
		}

		//=============================================
		

		private void btn_gravar_Click(object sender, EventArgs e)
		{
			//botao aberto na form tanto para add ou para editar

			//precisa criar  a conexao com sql para add ou editar os dados
			SqlCeConnection ligacao = new SqlCeConnection("Data Source =" + vars.base_dados);
			//essa conection string ja foi escrita la dentro do parentese
			//ligacao.ConnectionString = "Data Source=" + vars.base_dados;
			ligacao.Open();   //liga



			//grava novo registro ou edita registro existente

			//verificações....

			//impedir que grave com campos vazios
			#region verificacoes
			//verificar se os campos estao preenchidos
			if (txt_nome.Text == "" || txt_telefone.Text == "")
			{
				MessageBox.Show("falta preencher algum dos campos.");

				return;  //para que o codigo volte e continue a ser executado
			}

			#endregion
			//------------------------------------------
			//daqui pra baixo é parte de ADD ,seja para editar ou gravar um novo  ,a parte de cima carrega apenas no form resultados quando clicaco em edita
			//valor de editar aqui é falso ,==-1
			//essa parte do codigo e apresentado  quando no menu clica no add   ,aqui edita ==false

			//----------------------------------------
			#region NOVO CONTATO

			if (!editar)      //(id contato =-1) se for diferente de verdadeiro(==falso)   ele nao edita ele add..
			{
				//buscar id contato disponivel
				//apos criar a conexao e abrir
			
				SqlCeDataAdapter operarioAD = new SqlCeDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos", ligacao);//a stringconec.. ja escrita aqui dentro com comando do SQL
				DataTable dados = new DataTable(); //uma tabela invisivel para controle para poder preencher							  //depois de colocar o codigo para selecionar o numero max, objeto criado para conexao
				operarioAD.Fill(dados);           
				//operaioid manda comando para pegar o numero max de id do caminho da tab
				//apos operario vai preencher essa tabela invisivel com id


				//verificar se o valor devolvido é nulo ,,quer dizer que nao tem registro ainda

				if (DBNull.Value.Equals(dados.Rows[0][0]))//linha 0 e coluna 0 linha do id
				{//se for nulo ...id contato == 0 pra poder começar inserir contato ao id 0
					id_contato = 0;

					//se nessa tabela invisivel nao tiver valor acrescenta valor 0 para add esse contato
					//se ja tiver ele acrescenta mais +1 APOS PARA ALOCAR NOVOP CONTATO
				}
				else 
				{
					//se nao for ele pega numero de linhas e acrescenta +1   para novo contato
					id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1;
				}


				//===========  =============== ============

				//gravar o novo contato na base de dados
				//usar o comando e conectar ele aos dados

				//inserir ao comando.conexao= ligacao
				SqlCeCommand comando = new SqlCeCommand();
				comando.Connection = ligacao;   //usa o objeto ligação para a conexao

				//inserir ao comando.parametros com valores que representam cada coluna
				//parametros
				comando.Parameters.AddWithValue("@id_contato", id_contato);//define um nome para ele,e o valor que ele recebe
				comando.Parameters.AddWithValue("@nome", txt_nome.Text);
				comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
				comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);


				//mas antes de adicionar  precisa verificar se ja existe nom e tel
				//-============	=	===========	=	===============	=	================	=	=
				//REINICIAR ADPT E TABELA e NOVO 
				//e acrescenta comando de selecao ao  comando.comandText
				//verificar se o nome e tel já é existente preenchendo o datatable invisvel
				operarioAD = new SqlCeDataAdapter();     
				dados = new DataTable();
				comando.CommandText = "SELECT * FROM contatos  WHERE nome= @nome AND telefone = @telefone";
				//comando carrega inform~ções de (.conection) e (parametro)  e (.comandtext) que recebeu

				//o adaptador  tem varios comandos select ,delete,update..
				operarioAD.SelectCommand = comando;     
				operarioAD.Fill(dados);
				
				//se tiver qualquer quantidade de linha ele vai dizer que existe (commandtext)
				if (dados.Rows.Count != 0)
				{ //ja exeiste um contato com esses dados
					MessageBox.Show("ja existe o registro");
					return;
				}

				//============= =========== ============ =============
				
				//só depois de verificar se ja existe ele pode executar o insert
				//entao comando recebe um novo comando de texto para inserir usando (parametros dele)
				//texto da query	
				comando.CommandText = "INSERT INTO contatos VALUES(" +
					"@id_contato, @nome, @telefone, @atualizacao)";

				comando.ExecuteNonQuery();  //ele nao vai buscar info ,apenas guardar entao nao precisa de retorno
				comando.Dispose();
				ligacao.Dispose();

				MessageBox.Show("contato add com sucesso");
				//limpar o campo ja escrito
				txt_nome.Text = "";
				txt_telefone.Text = "";
				txt_nome.Focus();

			}



			#endregion
			//----------------------------------------
			#region EDITAR CONTATO
			else
			{

				//gravar o novo contato na base de dados
				//usar o comando e conectar ele aos dados

				//inserir ao comando.conexao= ligacao
				SqlCeCommand comando = new SqlCeCommand();
				comando.Connection = ligacao;   //usa o objeto ligação para a conexao

				//inserir ao comando.parametros com valores que representam cada coluna
				//parametros
				comando.Parameters.AddWithValue("@id_contato", id_contato);//define um nome para ele,e o valor que ele recebe
				comando.Parameters.AddWithValue("@nome", txt_nome.Text);
				comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
				comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

				//verifica se ja existe um registro com mesmo nome mas um id diferente
				DataTable tableainvisivel = new DataTable();
				comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";
				SqlCeDataAdapter operario = new SqlCeDataAdapter();//nao precisa passar aqui ,ja que ligacao ja esta associada ao comando ,a isntrução de selecionar tmb
				operario.SelectCommand = comando;
				operario.Fill(tableainvisivel);
				if (tableainvisivel.Rows.Count != 0)
				{
					//foi encontrado um registro com mesmo nome
					if (MessageBox.Show("existe um contao", "mudar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
				}
				
					//editar registro caso sim
						comando.CommandText = "UPDATE contatos SET nome = @nome ,telefone = @telefone, atualizacao = @atualizacao WHERE id_contato = @id_contato";
				comando.ExecuteNonQuery();

				//fechar o quadro
				this.Close();
			}
			#endregion
		}
	

		private void btn_fechar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
