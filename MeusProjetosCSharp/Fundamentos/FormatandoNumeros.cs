using System;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Formata para ter apenas 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // Formata para ficar aparecendo como dinheiro
            Console.WriteLine(valor.ToString("P")); // Formata multiplicando por 100 e adicionando o simbolo de "%"
            Console.WriteLine(valor.ToString("#.##")); // Formata para ter 2 casas decimais

            CultureInfo cultura = new CultureInfo("en-US"); // Criando uma nova config de cultura para ficar em en-US
            Console.WriteLine(valor.ToString("C3", cultura)); // Passa o valor sem nenhuma casa deciimal e depois passa a config

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // o D10 nao adiciona 10 zeros, ele adiciona 0 ate o num ter 10 casas
            
        }
    }
}
