using System;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota,notaCorte,notaReprova,notaMaxima;

            Console.Write("Escreva sua nota: ");
            double.TryParse(Console.ReadLine(), out nota);
            Console.Write("Escreva a nota de corte: ");
            double.TryParse(Console.ReadLine(), out notaCorte);
            Console.Write("Escreva a nota de reprova: ");
            double.TryParse(Console.ReadLine(), out notaReprova);
            Console.Write("Escreva a nota maxima: ");
            double.TryParse(Console.ReadLine(), out notaMaxima);

            Console.WriteLine("\nNota invalida: {0}", nota > notaMaxima || nota < 0.0);
            Console.WriteLine("Perfeito: {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar: {0}", nota != 10.0);
            Console.WriteLine("Passou na media: {0}", nota >= notaCorte);
            Console.WriteLine("Reprovado: {0}", nota <= notaReprova);
        }
    }
}
