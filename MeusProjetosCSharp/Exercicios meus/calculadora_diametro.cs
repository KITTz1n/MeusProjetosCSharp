using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.Exercicios
{
    internal class calculadora_diametro
    {
        public static void Executar()
        {
            bool sair = false;
            /*
             *      SEMPRE PERGUNTAR O VALOR DE PI
             * caso escolha calcular o diametro, perguntar o raio
             * caso escolha calcular o raio, perguntar o diametro
             * caso escolha calcular a area, perguntar o raio
             * caso escolha calcular a circunferencia, perguntar o raio
             * 
             *              COMO RESOLVER
             * diametro ele sempre vai ser: o dobro do raio
             * raio ele sempre vai ser: o diametro dividido por 2
             * area sera: PI vezes o raio ao quadrado
             * circunferencia sera: 2 vezes PI vezes o raio
             */
            while (sair == false)
            {
                double escolha2 = 0;

                Console.WriteLine("1- Calcular diametro");
                Console.WriteLine("2- Calcular raio");
                Console.WriteLine("3- Calcular area");
                Console.WriteLine("4- Calcular circunferencia");
                Console.WriteLine("5- Sair \n");

                Console.WriteLine("Digite o que voce deseja calcular: \n");

                string escolha = Console.ReadLine();
                
                if (escolha != "")
                {
                    escolha2 = Convert.ToDouble(escolha);
                }
                if (escolha2 == 1)
                {
                    Console.WriteLine("\nDigite a quantia de raio: ");
                    double quantia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o raio: ");
                    double raio_p = Convert.ToDouble(Console.ReadLine());
                    double diametro_r = quantia * (raio_p * 2);
                    Console.WriteLine("\nDiametro: {0}", diametro_r);
                }
                else if (escolha2 == 2)
                {
                    Console.WriteLine("\nDigite a quantia de diametro: ");
                    double quantia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o diametro: ");
                    double diametro_p = Convert.ToDouble(Console.ReadLine());
                    double raio_r = quantia * (diametro_p / 2);
                    Console.WriteLine("\nRaio: {0}", raio_r);
                }
                else if (escolha2 == 3)
                {
                    double raio = 0;
                    Console.WriteLine("\n1- diametro\n2- raio\n\nQual valor voce tem?");
                    double escolha3 = Convert.ToDouble(Console.ReadLine());
                    if (escolha3 == 1)
                    {
                        Console.WriteLine("\nValor do diametro: ");
                        double diametro = Convert.ToDouble(Console.ReadLine());
                        raio = diametro / 2;
                    }
                    else if (escolha3 == 2)
                    {
                        Console.WriteLine("\nValor do raio: ");
                        raio = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Nao temos essa opcao");
                    }

                    Console.WriteLine("\nDigite a quantia: ");
                    double quantia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o PI: ");
                    double PI = Convert.ToDouble(Console.ReadLine());
                    double area = quantia * (PI * (Math.Pow(raio, 2)));
                    Console.WriteLine("\nArea: {0}", area);
                }
                else if (escolha2 == 4)
                {
                    double raio = 0;
                    Console.WriteLine("\n1- diametro\n2- raio\n\nQual valor voce tem?");
                    double escolha3 = Convert.ToDouble(Console.ReadLine());
                    if (escolha3 == 1)
                    {
                        Console.WriteLine("\nValor do diametro: ");
                        double diametro = Convert.ToDouble(Console.ReadLine());
                        raio = diametro / 2;
                    }
                    else if (escolha3 == 2)
                    {
                        Console.WriteLine("\nValor do raio: ");
                        raio = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Nao temos essa opcao");
                    }
                    Console.WriteLine("\nDigite a quantia: ");
                    double quantia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDigite o PI: ");
                    double PI = Convert.ToDouble(Console.ReadLine());
                    double circunferencia = quantia * (2 * PI * raio);
                    Console.WriteLine("\nCircunferencia: {0}", circunferencia);
                }
                else if (escolha2 == 5)
                {
                    sair = true;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Programa Finalizado com sucesso!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nao temos essa opcao\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
