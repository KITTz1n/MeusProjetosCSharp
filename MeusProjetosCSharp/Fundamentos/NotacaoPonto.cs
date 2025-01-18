using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Ola".ToUpper().Insert(3," World").Replace("World","Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine(saudacao.Length);

            string valorImportante = null;
            // Console.WriteLine(valorImportante.Length);
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
