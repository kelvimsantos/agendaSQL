using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;  /// <summary>
/// para salvar em arquivo bloco de notas
/// </summary>

namespace agendaSQL
{
	//==============================================================
	public static partial class vars
		//transformar essa classe em " public static partial"
	{
		//propriedades
		public static string versao = "v.1.0.0";
		public static string pasta_dados;
		public static string base_dados;

		//criar um metodo estatico
		public static void iniciar()
		{
			//proceder aos mecanismos de inicialização da aplicação 
			//para criar uma pasta especial em meus documentos para  salvar a aplicação
			pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";


			//verifica se a pasta de dados existe,se nao existe,cria
			//a pasta/diretorio
			if (!Directory.Exists(pasta_dados)) 
			{
				Directory.CreateDirectory(pasta_dados);
			}

			//verifica se base de dados existe
			base_dados = pasta_dados + "dados.sdf";
			if (!File.Exists(base_dados))
			
				CriarBaseDados(); //vai executar o metodo que cria o banco de dados
			
		}
		//=======================================
		//criar um metodo ára criar o DB
		public static void CriarBaseDados()
		{
			//nosso motor
			SqlCeEngine motor = new SqlCeEngine("Data source = " + base_dados); //fonte DB = local da pasta \+dados.sdf
			motor.CreateDatabase();   //entao cria uma stancia desse  objeto que é o motor


			//criar extrutura da base de dados
			SqlCeConnection ligacao = new SqlCeConnection(); //essa conextionstring poderia ser digitada diretamente aqui
			ligacao.ConnectionString = "Data source = " + base_dados;
			
			//abrir
			ligacao.Open();
			
			

			//comando
			SqlCeCommand comando = new SqlCeCommand(); //commandtext poderia ser digitado diretamente aqui//comando de criação tabela
			comando.CommandText = 
				"CREATE TABLE contatos(" +
				"id_contato			int not null primary key, " +
				"nome				nvarchar(50), " +
				"telefone			nvarchar(20), " +
				"atualizacao		datetime)";
			//conexao
			comando.Connection = ligacao;
			comando.ExecuteNonQuery();
			 //uma query que nao devolve resultado apenas vai executar comando dentro da DB

			comando.Dispose();
			ligacao.Dispose();  //eliminar lixo de memoria restado

		}



	}
}
