
using CursoParte02;
using CursoParte02.Section10.ExerciseHeritage01;
using CursoParte02.Section10.ExerciseHeritage02;
using CursoParte02.Section10.ExerciseOverlap03;
using CursoParte02.Section10.ExerciseSealed04;
using CursoParte02.Section10.ExercisePolymorphism05;
using CursoParte02.Section10.ExerciseEmployeed06;
using CursoParte02.Section10.ExerciseProduct07;

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

    #endregion

});

central.SelecionarEExecutar();