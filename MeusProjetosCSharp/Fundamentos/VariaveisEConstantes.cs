using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Fundamentos
{
    internal class VariaveisEConstantes
    {

        public static void Executar()
        {
            // area da circunferencia

            double quantiaDeDiametro = 4;
            double diametro = 1 * quantiaDeDiametro;
            double raio = diametro/2;
            const double PI = 3;
            double area = PI * raio * raio;
            double circunferencia = 2 * PI * raio;

            Console.WriteLine("Diametro: {0}\nRaio: {1}\nPI: {2}\nArea: {3}" +
                "\nCircunferencia: {4}",diametro,raio,PI,area,circunferencia);

            bool estaChovendo = false;
            Console.WriteLine("Esta chovendo: {0}",estaChovendo);

            byte idade = 45;// byte so > 0
            Console.WriteLine("Idade: {0}",idade);

            sbyte saldoDeGols = sbyte.MinValue;//sinal byte <=> 0
            Console.WriteLine("Saldo de gols: {0}",saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario: {0}",salario);

            int menorValorInt = int.MinValue;// Mais usado dos inteiros!
            Console.WriteLine("Menor valor do Int: {0}",menorValorInt);

            uint populacaoBrasileira = 207_600_000;// Inteiro sem sinal, nao podendo ser negativo
            Console.WriteLine("Populacao brasileira: {0}",populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor do long: {0}",menorValorLong);

            ulong populacaoMundial = 7_600_000_000_000;
            Console.WriteLine("Populacao mundial: {0}",populacaoMundial);

            float precoContador = 1299.9f;//F depois do numeral para atribuir ao tipo float e nao double
            Console.WriteLine("Preco do contador: {0}",precoContador);

            double valorMercadoApple = 1_000_000_000_000_000;//Mais usado em numeros reais!
            Console.WriteLine("Valor do mercado da apple: {0}",valorMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor da distancia entre estrelas: {0}",distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: {0}",letra);

            string frase = "Ola! seja muito bem vindo!";
            Console.WriteLine("Frase: {0}",frase);

        }
    }
}
