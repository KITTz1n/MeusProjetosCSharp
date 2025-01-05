using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Pc Gamer";
            string marca_processador = "AMD";
            string modelo_processador = "Ryzen 5 5600 6 core";
            double preco_processador = 889.99;

            Console.WriteLine("Eu tenho um " + nome);
            Console.WriteLine("Tenho um {0} com um processador da marca {1} {2} que foi R${3}",nome,marca_processador,modelo_processador,preco_processador);
            Console.WriteLine($"A marca {marca_processador} do processador {modelo_processador} e muito boa!");
            Console.WriteLine($"1+1 = {1 + 1}!");
        }
    }
}
