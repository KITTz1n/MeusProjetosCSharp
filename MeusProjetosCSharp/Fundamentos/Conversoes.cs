using System;
using System.Globalization;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10; // Variavel inteira
            double quebrado = inteiro; // Variavel quebrado com o valor da inteira, transformando a inteira em quebrado
            Console.WriteLine("Quebrado: {0}",quebrado);

            double nota = 9.7; // Variavel double
            int notaTruncada = (int) nota; // Convertendo o double para uma variavel int, a parte
            Console.WriteLine("Nota truncada: {0} \n",notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine(); // Cata o valor doq usuario inseriu
            int idadeInteiro = int.Parse(idadeString); // transforma o valor de string para um inteiro
            Console.WriteLine("Idade inseria: {0} \n",idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado 1: {0} \n",idadeInteiro);

            Console.WriteLine("Digite o primeiro numero");
            string palavra = Console.ReadLine(); // Cata o valor que o usuario digitou
            int numero; // Cria uma variavel numero
            int.TryParse(palavra, out numero); // Tenta transformar a variavel palavra em int, caso nao funcione passara 0
            Console.WriteLine("\nResultado 2: {0} \n",numero);

            Console.WriteLine("Digite o segundo");
            int.TryParse(Console.ReadLine(), out int numero2); // tenta tranformar um valor inserido pelo usario em uma variavel int, caso nao funcione passsara 0
            Console.WriteLine("\nResultado 3: {0} \n",numero2);
        }
    }
}
