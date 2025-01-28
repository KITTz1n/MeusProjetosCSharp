using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.EstruturaDeControle
{
    public class EstruturaBreak
    {
        public static void Executar()
        {
            Random randomico = new Random();
            int numero = randomico.Next(1, 10);

            Console.WriteLine("O numero que queremos e {0}.",numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} <- e o numero que queremos?",i);

                // confirmar a resposta
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nao!");
                }
            }
        }
    }
}