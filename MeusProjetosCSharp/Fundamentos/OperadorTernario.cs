using System;
using System.Collections.Generic;
using System.Text;

namespace MeusProjetosCSharp.Fundamentos
{
    public class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 8.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento == true ? "aprovado" : "reprovado";
            Console.WriteLine(resultado);
        }
    }
}