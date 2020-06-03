using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaSQL
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//inicia a app ,antes de apresentar o form vai chamar o  metodo iniciar da classe vars
			vars.iniciar(); //para verificar se existe a pasta e criar ela nos meus documentos


			//essa linha apresenta o menu inicial ,a instancia dele ja vem escrita quando cria o form
			Application.Run(new frm_menu());
		}
	}
}
