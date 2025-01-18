using System;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preco desconto

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preco final sera: {0}",totalComDesconto);

            // IMC

            double peso = 99.5;
            double altura = 1.84;
            double imc = peso/ Math.Pow(altura, 2);
            Console.WriteLine("Imc sera: {0}",imc);

            // Numero par/impar

            int par,impar;
            par = 8;
            impar = 7;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2);
        }
    }
}
