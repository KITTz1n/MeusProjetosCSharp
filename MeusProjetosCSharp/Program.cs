using System;
using System.Collections.Generic;

using Csharp.Fundamentos;
using Csharp.Exercicios;


namespace Csharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Calculadora Diametro - Exercicios meus", calculadora_diametro.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}