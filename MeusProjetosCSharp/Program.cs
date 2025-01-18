using System;
using System.Collections.Generic;

using Csharp.Fundamentos;
using Csharp.Exercicios;
using MeusProjetosCSharp.Fundamentos;


namespace Csharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Calculadora Diametro - Exercicios meus", calculadora_diametro.Executar},
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Intepolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formantando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}