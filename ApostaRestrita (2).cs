using System;

namespace Provaloteria
{
	public class ApostaRestrita
	{
		/*Atributos*/
		public int[,] tabelaApostaR = new int[13,3];
		private int apostaR;
		private int jogoR=1;
		private int opcao;
		private Random rand = new Random ();
		public int[,] resultadoJ = new int[13,3];
		private int[] resultado = new int[13];


		/*Construtor*/
		public ApostaRestrita (int aposta, int jogo)
		{
			this.apostaR = aposta;
			this.jogoR = jogo;
		}

		/*Metodos*/
		public void RealizarApostaRestrita(){
			Console.ForegroundColor=ConsoleColor.Green;

			Console.WriteLine ("Digite:");
			Console.WriteLine ("1 para vitória do time-1");
			Console.WriteLine ("2 para empate");
			Console.WriteLine ("3 para vitória do time-2");
			Console.WriteLine("\n");

			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {
					tabelaApostaR [i, j] = 0;
				}
			}

			for (int i = 0; i < 13; i++) {
				Console.WriteLine ("Jogo {0}", jogoR++);
				try{
				apostaR = int.Parse (Console.ReadLine ());
				}catch(FormatException e){
					Console.WriteLine ("Digite apenas números");
					Console.ReadLine ();
				}
				for (int j = 0; j < 3; j++) {

					if (apostaR == 1) {
						tabelaApostaR [i, 0] = 1;
					}
					if (apostaR == 2) {
						tabelaApostaR [i, 1] = 1;
					}
					if (apostaR == 3) {
						tabelaApostaR [i, 2] = 1;
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
		public int[,] getExibirR(){
			Console.WriteLine ("\t\t Aposta Realizada");
			Console.Write("\n\n");

			Console.WriteLine ("      Time-1  \t     Empate   \t     Time-2");
			for (int i=0; i<13; i++){
				for (int j=0; j<3; j++){
					Console.Write("\t{0}\t", tabelaApostaR [i, j]);
				}
				Console.Write("\n");
			}
			return tabelaApostaR;

		}

		public int[,] getJogoR(){
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
						Console.Write ("\t{0}\t", tabelaApostaR [0, j]);
					}
				}
			}

			if (opcao == 2) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [1, j]);
					}
				}
			}

			if (opcao == 3) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [2, j]);
					}
				}
			}

			if (opcao == 4) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [3, j]);
					}
				}
			}

			if (opcao == 5) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [4, j]);
					}
				}
			}

			if (opcao == 6) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [5, j]);
					}
				}
			}

			if (opcao == 7) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [6, j]);
					}
				}
			}

			if (opcao == 8) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [7, j]);
					}
				}
			}

			if (opcao == 9) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [8, j]);
					}
				}
			}

			if (opcao == 10) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [9, j]);
					}
				}
			}

			if (opcao == 11) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [10, j]);
					}
				}
			}

			if (opcao == 12) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [11, j]);
					}
				}
			}

			if (opcao == 13) {
				for (int i = 0; i < 1; i++) {
					for (int j = 0; j < 3; j++) {
						Console.Write ("\t{0}\t", tabelaApostaR [12, j]);
					}
				}
			}

			return tabelaApostaR;

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


