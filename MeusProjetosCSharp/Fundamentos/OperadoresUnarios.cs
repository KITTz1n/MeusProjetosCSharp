using System;
using System.Collections.Generic;
using System.Text;

namespace MeusProjetosCSharp.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++;
            Console.WriteLine(num1);
            
            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2); // sera true pois o num1 esta com o ++ apos a variavel, dando sentido para fazer a incrementacao apos a comparacao
        }
    }
}