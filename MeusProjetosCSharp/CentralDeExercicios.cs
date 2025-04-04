﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp {
    public class CentralDeExercicios {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios) {
            Exercicios = exercicios;    
        }

        public void SelecionarEExecutar() {

            int i = 1;
            
            foreach (var exercicio in Exercicios) {
                Console.WriteLine("{0} -> {1}", i, exercicio.Key);
                i++;
            }
            var numero_sair = i;
            Console.WriteLine("{0} -> Sair",numero_sair);

            Console.Write("\nEscolha (vazio para o último):\n");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= numero_sair;
            if (num == numero_sair)
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                num = numValido ? num -1 : Exercicios.Count -1;

                string nomeDoExercicio = Exercicios.ElementAt(num).Key;
                Console.Write("\nExecutando exercício ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nomeDoExercicio);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(String.Concat(
                    Enumerable.Repeat("-", nomeDoExercicio.Length + 21)) + "\n");
                Action executar = Exercicios.ElementAt(num).Value;
                try {
                    executar();
                } catch(Exception e) {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                    Console.ResetColor();

                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}