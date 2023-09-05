
using CursoParte02;
using CursoParte02.Section10.ExerciseHeritage01;
using CursoParte02.Section10.ExerciseHeritage02;
using CursoParte02.Section10.ExerciseOverlap03;
using CursoParte02.Section10.ExerciseSealed04;
using CursoParte02.Section10.ExercisePolymorphism05;
using CursoParte02.Section10.ExerciseEmployeed06;
using CursoParte02.Section10.ExerciseProduct07;
using CursoParte02.Section10.ExerciseClassAbstract08;
using CursoParte02.Section10.ExerciseMethodsAbstract09;
using CursoParte02.Section10.ExerciseContributors10;
using CursoParte02.Section11;
using CursoParte02.Section11.Parte01;
using CursoParte02.Section11.Parte02;
using CursoParte02.Section11.Parte03;
using CursoParte02.Section11.FixationExercise;
using CursoParte02.Section12;
using CursoParte02.Section13;

var central = new ExerciseCenter(new Dictionary<string, Action>()
{
    #region "Seção 10 Herança"

    // PROGRAMAÇÃO ORIENTADA A OBJETOS - Seção 10
    // Capítulo: Herança e Polimorfismo

    {"Seção 10 - Exercício Herança", ExerciseAccount.Executar},
    {"Seção 10 - Exercício Upcasting e Downcasting", ExerciseUpDownCasting.Executar},
    {"Seção 10 - Exercício Sobreposição ou Sobrescrita", ExcerciseOverlap.Executar},
    {"Seção 10 - Exercício Classes e Métodos selados", ExerciseSealed.Executar},
    {"Seção 10 - Introdução ao Polimorfismo - Exercício de Revisão", ExercisePolymorphism.Executar},
    {"Seção 10 - Introdução ao Polimorfismo - Exercício de Fixação", ExerciseEmployeed.Executar},
    {"Seção 10 - Introdução ao Polimorfismo - Exercício Proposto", ExerciseProduct.Executar},
    {"Seção 10 - Classes Abstratas - Exercício Conta Bancária", ExerciseClassAbstract.Executar},
    {"Seção 10 - Métodos Abstratos - Exercício Calcular área das formas", ExerciseMethodsAbstract.Executar},
    {"Seção 10 - Classes e Métodos Abstratos - Exercício Calcular imposto de contribuintes", ExerciseContributors.Executar},

    #endregion

    #region "Seção 11 Tratamento e Exceções"

    // PROGRAMAÇÃO ORIENTADA A OBJETOS - Seção 11
    // Capítulo: Tratamento e Exceções

    {"Seção 11 - Tratamento e Exceções - Estrutura try-catch", ExerciseTryCatch.Executar},
    {"Seção 11 - Tratamento e Exceções - Bloco finally", ExerciseProcessFile .Executar},
    {"Seção 11 - Criando exceções personalizadas - Solução 1 (muito ruim) - Parte 01", ExerciseExceptions01.Executar},
    {"Seção 11 - Criando exceções personalizadas - Solução 2 (ruim) - Parte 02", ExerciseExceptions02.Executar},
    {"Seção 11 - Criando exceções personalizadas - Solução 3 (melhor) - Parte 03", ExerciseExceptions03.Executar},
    {"Seção 11 - Exercício de Fixação - Conta Bancária", ExerciseBankAccount.Executar},

    #endregion

    #region "Seção 12 - Projeto: Sistema de Jogo de Xadrez"

    {"Seção 12 - Sistema de Jogo de Xadrez", ChessGame.Executar},

    #endregion

 
    #region "Seção 13 - Trabalhando com Arquivos"

    {"Seção 13 - Trabalhando com Arquivos - File, FileInfo, IOException", ExerciseFile.Executar},
    {"Seção 13 - Trabalhando com Arquivos - FileStream, StreamReader", ExerciseFile02.Executar},

    #endregion

});

central.SelecionarEExecutar();