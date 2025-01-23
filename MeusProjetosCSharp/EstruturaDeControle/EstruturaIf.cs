using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Executar()
        {
            var bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();
            entrada = entrada.ToLower();

            if (entrada == "s")
            {
                bomComportamento = true;
            }
            else if (entrada == "n")
            {
                bomComportamento = false;
            }
            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra");
            }
        }
    }
}