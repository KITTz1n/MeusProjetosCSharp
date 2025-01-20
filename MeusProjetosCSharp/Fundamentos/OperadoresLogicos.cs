using System;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            // && <- usado como and( e )
            // || <- usado como or( ou )
            // ^ <- usado como xor( exclusivo -> significado: exige que apenas 1 valor de correto, caso passe de 1 dara falso )
            // ! <- usado como not( negacao )

            var executouTask1 = true;
            var executouTask2 = false;
            var comprouTV50 = executouTask1 && executouTask2;
            var comprouSorvete = executouTask1 || executouTask2;
            var comprouTV32 = executouTask1 ^ executouTask2;

            Console.WriteLine("Comprou a TV 50: {0}",comprouTV50);
            Console.WriteLine("Comprou o Sorvete: {0}",comprouSorvete);
            Console.WriteLine("Comprou a TV 32: {0}", comprouTV32);
            Console.WriteLine("Saudavel: {0}", !comprouSorvete);

        }
    }
}
