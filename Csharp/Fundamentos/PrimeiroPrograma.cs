using System;

namespace Csharp.Fundamentos//encontrando o arquivo
{
    class PrimeiroPrograma//classe do programa
    {
        public static void Executar()//quando iniciar
        {
            Console.WriteLine("Escreva algo:");//quebra uma linha e escreve
            var Escrever = Console.ReadLine();//fala para o cliente escrever algo
            var Cor = ConsoleColor.Blue;//variavel armazenando a cor
            Console.ForegroundColor = Cor;//falando que a cor do texto e igual a var cor
            Console.Write("Primeiro ");//escreve na mesma linha
            Console.WriteLine("Programa");//quebra uma linha e escreve
            Console.WriteLine("Voce escreveu: {0}", Escrever);//
            Cor = ConsoleColor.Red;
            Console.ForegroundColor = Cor;
            Console.WriteLine("Finalizado!");
            Console.ResetColor();
        }
    }
}
