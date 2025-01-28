using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.EstruturaDeControle
{
    public class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random= new Random();

            int num_min = 0;
            int num_max = 100;

            int numeroSecreto = random.Next(num_min,num_max);
            bool numeroCerto = false;
            bool acabou = false;
            int tentativas = 0;
            int tentativas_restantes = 5;
            while (numeroCerto == false && tentativas_restantes > 0 && acabou == false)
            {
                tentativas++;
                tentativas_restantes--;
                Console.Write("\nTentativa N{0} restam {1} -> Adinhe o numero de {2} a {3}: ",tentativas,tentativas_restantes,num_min,num_max);
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                if (palpite == numeroSecreto)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acertou miseravi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    numeroCerto = true;
                }
                if (palpite < numeroSecreto && palpite <= num_max && palpite >= num_min)
                {
                    numeroCerto = false;
                    Console.WriteLine("Maior do que isso");
                }
                if (palpite > numeroSecreto && palpite <= num_max && palpite >= num_min)
                {
                    numeroCerto = false;
                    Console.WriteLine("Menor do que isso");
                }
                if (palpite > num_max || palpite < num_min)
                {
                    tentativas--;
                    tentativas_restantes++;
                    numeroCerto = false;
                    Console.WriteLine("Numero Invalido!");
                }
            }
            if (tentativas_restantes == 0 && numeroCerto == false)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("O numero corretor era: {0}",numeroSecreto);
                Console.BackgroundColor = ConsoleColor.Black;
                acabou = true;
            }
        }
    }
}