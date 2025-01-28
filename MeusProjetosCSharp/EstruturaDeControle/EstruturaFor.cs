using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.EstruturaDeControle
{
    public class EstruturaFor
    {
        public static void Executar()
        {
            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine($"o valor de i e: {i}.");
            // }

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 0; i < tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio/tamanhoTurma : 0;
            Console.WriteLine("A media de nota da turma e: {0}",media);
        }
    }
}