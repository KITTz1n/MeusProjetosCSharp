using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar() 
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o seu salario?");
            double salario = double.Parse(Console.ReadLine());
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} tem {idade} anos e ganha R${salario} de salario");

            if (idade >= 18)
            {
                Console.WriteLine("Voce e maior de idade");
            }
            else 
            {
                Console.WriteLine("Voce e menor de idade");
                if (salario > 0)
                {
                    Console.WriteLine($"Parabens {nome} voce ganha antes de fazer 18 anos");
                }
            }
        }
    }
}
