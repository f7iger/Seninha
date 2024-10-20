using System;
using System.Collections.Generic;
using System.Linq;

namespace Seninha
{
	class Program
	{
		static void Listar_nums(List<int> l)
		{
			foreach(int n in l)
            {
                Console.WriteLine(n);
            }
		}	
		
		static List<int> Adicionar_nums(int r, Random rndm, List<int> l) // r = range; rnd = random number; l = list
		{
			for (int i = 0; i <= r ; i++)
			{
				int rnd_number = rndm.Next(1, 60);
                l.Add(rnd_number);
			}
			
			return l;
		}
		static int Main(string[] args)
		{
			// Inicio da primeira parte do programa
			
			int escolha, range;
			Random rnd = new Random();
			List<int> lista = new List<int>();
			Validacao tni = new Validacao(); // Tem numero igual = tni	
			Numeros qntNum = new Numeros(); //

			Console.Write("Escolha quantos números quer jogar: ");
			foreach (int i in qntNum.range)
			{
				Console.Write(i + " ");
			}
			Console.Write("\n");
			escolha = int.Parse(Console.ReadLine());
			if (escolha == 14)
			{
				range = qntNum.range[0];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 15)
			{
				range = qntNum.range[1];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 16)
			{
				range = qntNum.range[2];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 17)
			{
				range = qntNum.range[3];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 18)
			{
				range = qntNum.range[4];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 19)
			{
				range = qntNum.range[5];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 20)
			{
				range = qntNum.range[6];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 25)
			{
				range = qntNum.range[7];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 30)
			{
				range = qntNum.range[8];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 35)
			{
				range = qntNum.range[9];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else if (escolha == 40)
            {
				range = qntNum.range[10];
				Console.WriteLine("Voce escolheu {0} numeros", range);
				Adicionar_nums(range, rnd, lista);
			}
			else
			{
				Console.WriteLine("Escolha invalida. Tente novamente.");
                return 1;
			}

			// for(int i = 0; i <= range; i++){
			// 	int rnd_number = rnd.Next(1, 60);
			// 	lista.Add(rnd_number);
			// }

			if (tni.TemNumIgual(lista))
			{
				HashSet<int> n_unico = new HashSet<int>(lista);
				List<int> lista_sem_duplicatas = new List<int>(n_unico);
				lista_sem_duplicatas.Sort();
				Listar_nums(lista_sem_duplicatas);				
			} else {
				Listar_nums(lista);
			}
			return 0;
		}
	}
}
