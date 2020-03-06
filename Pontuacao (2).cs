using System;

namespace Provaloteria
{
	public class Pontuacao
	{
		
		public int PontosAc (int [,]tabelaApostaR, int [,]resultadoJ){
			int pontos=0;


			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {

					if (tabelaApostaR [i, j] + resultadoJ[i,j]== 2) {
						pontos=pontos+1;
					}
				}
			}

			return pontos;
		}



		public double PontosF(int [,]tabelaApostaF, int [,]resultadoJ, int apostaF){

			double pontos=0, pontos1=0, pontos2=0;


			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {
					if (apostaF <= 3) {

						if (tabelaApostaF [i, j] + resultadoJ [i, j] == 2) {
							pontos1 = pontos1 + 1;
						}
					}
					if (apostaF > 3) {
						if (tabelaApostaF [i, j] + resultadoJ [i, j] == 2) {
							pontos2 = pontos2 + 0.5;
						}

					}
					pontos = pontos1 + pontos2;
				}
			}

			return pontos;




		}


	}
}
