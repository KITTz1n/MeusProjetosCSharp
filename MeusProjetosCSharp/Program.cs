using System;
using System.Collections.Generic;

using MeusProjetosCSharp.Exercicios;
using MeusProjetosCSharp.Fundamentos;
using MeusProjetosCSharp.EstruturaDeControle;


namespace Csharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // EXERCICIO
                {"Calculadora Diametro - Exercicios meus", calculadora_diametro.Executar},

                // FUNDAMENTOS
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
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                // ESTRUTURA DE CONTROLE
                {"Estrutura If - Estrutura de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else if - Estrutura de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}