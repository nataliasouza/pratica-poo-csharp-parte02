
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
using CursoParte02.Section13.Challenge;
using CursoParte02.Section14.ExerciseNoInterface;
using CursoParte02.Section14.ExerciseWithInterface;
using CursoParte02.Section14.FixingExerciseInterface;
using CursoParte02.Section14.ExerciseInterface;
using CursoParte02.Section14.ExerciseMultipleInheritance;
using CursoParte02.Section14.ExerciseInterfaceIComparable;
using CursoParte02.Section14.Exercises;
using CursoParte02.Section14.Exercises.ExerciseIComparable;
using CursoParte02.Section15.ExerciseGenerics;
using CursoParte02.Section15.ExerciseRestrictionGenerics;
using CursoParte02.Section15.ExerciseGetHashCodeEquals;
using CursoParte02.Section15.ExerciseSet;

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
    {"Seção 13 - Trabalhando com Arquivos - Using Block", ExerciseFile03.Executar},
    {"Seção 13 - Trabalhando com Arquivos - StreamWriter", ExerciseFile04.Executar},
    {"Seção 13 - Trabalhando com Arquivos - Directory - DirectoryInfo", ExerciseDirectory.Executar},
    {"Seção 13 - Trabalhando com Arquivos - Path", ExercisePath.Executar},
    {"Seção 13 - Trabalhando com Arquivos - Desafio", ExerciseFile05.Executar},

    #endregion

    #region "Seção 14 - Interfaces"

    {"Seção 14 - Problema Exemplo - Solução sem o uso de interface", ExerciseNoInterface.Executar},
    {"Seção 14 - Problema Exemplo - Solução com o uso de interface", ExerciseWithInterface.Executar},
    {"Seção 14 - Exercício para Fixação - Interface", FixingExerciseInterface.Executar},
    {"Seção 14 - Exercício 209 - Herdar vs cumprir contrato", ExerciseInterface.Executar},
    {"Seção 14 - Exercício 210 - Herança Múltipla", MultipleInheritance.Executar},
    {"Seção 14 - Exercício 211 - versão utilizando array e File Info", Exercise01.Executar},
    {"Seção 14 - Exercício 211 - versão utilizando List e StreamReader", Exercise02.Executar},
    {"Seção 14 - Exercício 212 - Interface IComparable", ExerciseIComparable.Executar},
  
    #endregion

    #region "Seção 15 - Generics, Set, Dictionary"

    {"Seção 15 - Exercício Generics - Parte 1 e 2 - Aula 213 e 2014", ExercisePrintService.Executar},
    {"Seção 15 - Exercício Generics - Restrições de Generics - Aula 215", RestrictionGenerics.Executar},   
    {"Seção 15 - Exercício GetHashCode e Equals - Aula 216", ExerciseGetHashCode.Executar},   
    {"Seção 15 - Exercício Conjuntos - HashSet Parte 1 - Aula 217", ExerciseHashSet.Executar},   
    {"Seção 15 - Exercício Conjuntos - SortedSet Parte 2 - Aula 218", ExerciseSortedSet.Executar},   
  
    #endregion

});

central.SelecionarEExecutar();