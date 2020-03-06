using System;

namespace Provaloteria
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int opcao=0, opcao2=0,sair=1;
			ApostaFlexivel apostaf = new ApostaFlexivel (1, 0);
			ApostaRestrita apostar = new ApostaRestrita (1, 0);
			Pontuacao pontos = new Pontuacao ();

			Console.WriteLine("-----------------");
			Console.WriteLine("LOTERIA ESPORTIVA");
			Console.WriteLine("-----------------");
			Console.WriteLine("\n");

			do{

				Console.ForegroundColor=ConsoleColor.Cyan;
				Console.Clear();
				Console.WriteLine("-----------------");
				Console.WriteLine("LOTERIA ESPORTIVA");
				Console.WriteLine("-----------------");
				Console.WriteLine("\n");
				Console.WriteLine ("Digite:");
				Console.WriteLine("1: Realizar Aposta");
				Console.WriteLine("2: Exibir Aposta Completa");
				Console.WriteLine("3: Exibir Um Jogo Da Aposta");
				Console.WriteLine("4: Verificar Resultado");
				Console.WriteLine("5: Verificar Pontuação");
				Console.WriteLine("6: Sair");
				try{
				opcao=int.Parse(Console.ReadLine());
				}catch(FormatException e){
					Console.WriteLine("Digite apenas números");
					Console.ReadLine();
				}
				
		
				Console.ForegroundColor=ConsoleColor.Red;

				switch (opcao) {
				case 1:
					Console.Clear();
					Console.WriteLine("-----------------");
					Console.WriteLine("LOTERIA ESPORTIVA");
					Console.WriteLine("-----------------");
					Console.WriteLine("\n");
					Console.WriteLine ("Digite:");
					Console.WriteLine ("1: Realizar Aposta Flexível");
					Console.WriteLine ("2: Realizar Aposta Restrita");
					try{
					opcao2 = int.Parse (Console.ReadLine ());
					}catch(FormatException e){
						Console.WriteLine ("Digite apenas números");
						Console.ReadLine ();
					}
					if (opcao2 == 1) {

						Console.Clear();
						Console.WriteLine("-----------------");
						Console.WriteLine("LOTERIA ESPORTIVA");
						Console.WriteLine("-----------------");
						Console.WriteLine("\n");
						apostaf.RealizarApostaFlexivel ();
					}
					if (opcao2 == 2) {
						Console.Clear();
						Console.WriteLine("-----------------");
						Console.WriteLine("LOTERIA ESPORTIVA");
						Console.WriteLine("-----------------");
						Console.WriteLine("\n");
						apostar.RealizarApostaRestrita ();
					}

					break;

				case 2:
					Console.Clear();
					Console.WriteLine("-----------------");
					Console.WriteLine("LOTERIA ESPORTIVA");
					Console.WriteLine("-----------------");
					Console.WriteLine("\n");
					if ((opcao2!=1)&&(opcao2!=2)){
						apostaf.getExibirF();
						Console.ReadLine();
					}
					if(opcao2==1){
						apostaf.getExibirF();
						Console.ReadLine();
					}
					if(opcao2==2){
						apostar.getExibirR();
						Console.ReadLine();
					}

					break;
				case 3:
					Console.Clear();
					Console.WriteLine("-----------------");
					Console.WriteLine("LOTERIA ESPORTIVA");
					Console.WriteLine("-----------------");
					Console.WriteLine("\n");
					if ((opcao2!=1)&&(opcao2!=2)){
						apostaf.getJogoF();
						Console.ReadLine();
					}
					if(opcao2==1){
						apostaf.getJogoF();
						Console.ReadLine();
					}
					if(opcao2==2){
						apostar.getJogoR();
						Console.ReadLine();
					}

					break;


				case 4:
					Console.ForegroundColor=ConsoleColor.Magenta;
					Console.Clear();
					Console.WriteLine("-----------------");
					Console.WriteLine("LOTERIA ESPORTIVA");
					Console.WriteLine("-----------------");
					Console.WriteLine("\n");
					if ((opcao2!=1)&&(opcao2!=2)){
						apostaf.getResult();
						Console.ReadLine();
					}
					if(opcao2==1){
					apostaf.getResult();
					Console.ReadLine();
					}
					if(opcao2==2){
						apostar.getResult();
						Console.ReadLine();
					}

					break;

				case 5:
					Console.Clear();
					if(opcao2==2){
						int pontuacao = pontos.PontosAc(apostar.tabelaApostaR, apostar.resultadoJ);
					    Console.WriteLine("\n");
						Console.WriteLine("Você fez " + pontuacao + " pontos");
					    Console.ReadLine();
					}
					if(opcao2==1){
						double pontuacao = pontos.PontosF(apostaf.tabelaApostaF, apostaf.resultadoJ, apostaf.apostaF);
						Console.WriteLine("\n");
						Console.WriteLine("Você fez " + pontuacao + " pontos");
						Console.ReadLine();
					}
					break;
				case 6:
					sair++;
					break;

				}


			}while(sair==1);

		}
	}
}
