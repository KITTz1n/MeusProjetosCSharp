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

            int numeroSecreto = random.Next(1,16);
            bool numeroCerto = false;
            int tentativas = 0;
            int tentativas_restantes = 5;
            while (numeroCerto == false && tentativas_restantes > 0)
            {
                tentativas++;
                tentativas_restantes--;
                Console.Write("\nTentativa N{0} restam {1} -> Adinhe o numero de 1 a 15: ",tentativas,tentativas_restantes);
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                if (palpite == numeroSecreto)
                {
                    numeroCerto = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acertou miseravi");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite < numeroSecreto)
                {
                    numeroCerto = false;
                    Console.WriteLine("Maior do que isso");
                }
                else if (palpite > numeroSecreto)
                {
                    numeroCerto = false;
                    Console.WriteLine("Menor do que isso");
                }
                else if (palpite >= 16 || palpite <= 0)
                {
                    tentativas--;
                    tentativas_restantes++;
                    numeroCerto = false;
                    Console.WriteLine("Numero Invalido!");
                }
            }
            if (tentativas_restantes == 0 && numeroCerto == false)
            {
                var corAnterior = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("O numero corretor era: {0}",numeroSecreto);
                Console.BackgroundColor = corAnterior;
            }
        }
    }
}