using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusProjetosCSharp.EstruturaDeControle
{
    public class EstruturaForEach
    {
        public static void Executar()
        {
            var palavara = "opaaaaa!";
            
            foreach (var letra in palavara)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Wellington", "Eu", "Mim"};
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}