using System;

namespace Provaloteria
{
	public class ApostaFlexivel
	{
		/*Atributos*/
		public int[,] tabelaApostaF = new int[13,3];
		public int apostaF=0;
		private int jogoF=1;
		private int opcao;
		private Random rand = new Random ();
		public int[,] resultadoJ = new int[13,3];
		private int[] resultado = new int[13];


		/*Construtor*/
		public ApostaFlexivel (int apostaF, int jogoF)
		{
			this.apostaF = apostaF;
			this.jogoF = jogoF;
		}


		/*Metodos*/
		public void RealizarApostaFlexivel()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine ("Digite:");
			Console.WriteLine ("1 para vitória do time-1");
			Console.WriteLine ("2 para empate");
			Console.WriteLine ("3 para vitória do time-2");
			Console.WriteLine ("4 para vitória do time-1 e empate");
			Console.WriteLine ("5 para vitória do time-2 e empate");
			Console.Write ("\n");


			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {
					tabelaApostaF [i, j] = 0;
				}
			}

			for (int i = 0; i < 13; i++) {
				Console.WriteLine ("Jogo {0}", jogoF++);
				try{
				apostaF = int.Parse (Console.ReadLine ());
				}catch(FormatException e){
					Console.WriteLine ("Digite apenas números");
					Console.ReadLine ();
				}
					
				for (int j = 0; j < 3; j++) {


					if (apostaF == 1) {
						tabelaApostaF [i, 0] = 1;
					}
					if (apostaF == 2) {
						tabelaApostaF [i, 1] = 1;
					}
					if (apostaF == 3) {
						tabelaApostaF [i, 2] = 1;
					}
					if (apostaF == 4) {
						tabelaApostaF [i, 0] = 1;
						tabelaApostaF [i, 1] = 1;
					}
					if (apostaF == 5) {
						tabelaApostaF [i, 1] = 1;
						tabelaApostaF [i, 2] = 1;
					}
				}
			}
			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {
					resultadoJ [i, j] = 0;

				}
			}
			for (int i = 0; i < 13; i++) {
				resultado [i] = rand.Next (0, 3);

				if (resultado [i] == 0) {
					resultadoJ [i, 0] = 1;
				}
				if (resultado [i] == 1) {
					resultadoJ [i, 1] = 1;
				}
				if (resultado [i] == 2) {
					resultadoJ [i, 2] = 1;
				}
			}
		}
		public int[,] getExibirF(){
			Console.WriteLine ("\t\t Aposta Realizada");
			Console.Write("\n\n");

			Console.WriteLine ("      Time-1  \t     Empate   \t     Time-2");
			for (int i=0; i<13; i++){
				for (int j=0; j<3; j++){
					Console.Write("\t{0}\t", tabelaApostaF [i, j]);
				}
				Console.Write("\n");
			}
			return tabelaApostaF;
		}

		public int[,] getJogoF(){
			Console.WriteLine("Digite o jogo que quer ver");
			try{
			opcao = int.Parse (Console.ReadLine ());
			}catch(FormatException e){
				Console.WriteLine ("Digite apenas números");
				Console.ReadLine ();
			}
			Console.WriteLine ("                     Jogo " + opcao);
			Console.WriteLine (" ");
			Console.WriteLine ("      Time-1  \t     Empate   \t     Time-2");

			if (opcao == 1) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [0, j]);
					}
				}
			}

			if (opcao == 2) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [1, j]);
					}
				}
			}

			if (opcao == 3) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [2, j]);
					}
				}
			}

			if (opcao == 4) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [3, j]);
					}
				}
			}

			if (opcao == 5) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [4, j]);
					}
				}
			}

			if (opcao == 6) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [5, j]);
					}
				}
			}

			if (opcao == 7) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [6, j]);
					}
				}
			}

			if (opcao == 8) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [7, j]);
					}
				}
			}

			if (opcao == 9) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [8, j]);
					}
				}
			}

			if (opcao == 10) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [9, j]);
					}
				}
			}

			if (opcao == 11) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [10, j]);
					}
				}
			}

			if (opcao == 12) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [11, j]);
					}
				}
			}

			if (opcao == 13) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaF [12, j]);
					}
				}
			}

			return tabelaApostaF;

		}

		public int[,] getResult(){
			Console.WriteLine ("\t\t Aposta Realizada");
			Console.Write("\n\n");

			Console.WriteLine ("      Time-1  \t     Empate   \t     Time-2");
			for (int i=0; i<13; i++){
				for (int j=0; j<3; j++){
					Console.Write("\t{0}\t", resultadoJ [i, j]);
				}
				Console.Write("\n");
			}
			return resultadoJ;

		}

	}
}

