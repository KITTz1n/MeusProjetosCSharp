using System;

namespace Csharp.Fundamentos//Encontrando o arquivo
{
    class PrimeiroPrograma//Classe do programa
    {
        public static void Executar()//quando iniciar
        {
            Console.WriteLine("Escreva algo:");//quebra uma linha e escreve
            var Escrever = Console.ReadLine();//fala para o cliente escrever algo
            var Cor = ConsoleColor.Blue;//variavel armazenando uma cor
            Console.ForegroundColor = Cor;//muda a cor do texto para o valor da variavel cor
            Console.Write("Primeiro ");//escreve na mesma linha: Primeiro
            Console.WriteLine("Programa");//quebra uma linha e escreve: Programa

            Console.WriteLine("Voce escreveu: {0}", Escrever);//quebra uma linha e escreve o que o cliente escreveu
            Cor = ConsoleColor.Red;//muda o valor da variavel cor para vermelho
            Console.ForegroundColor = Cor;//muda a cor do texto para o valor da variavel cor
            Console.WriteLine("Finalizado!");//quebra e escreve: Finalizado!
            Console.ResetColor();//reseta a cor do consoles
        }
    }
}
