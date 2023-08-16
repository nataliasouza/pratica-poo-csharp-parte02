﻿
using CursoParte02;
using CursoParte02.Section10.ExerciseHeritage01;
using CursoParte02.Section10.ExerciseHeritage02;
using CursoParte02.Section10.ExerciseOverlap03;

var central = new ExerciseCenter(new Dictionary<string, Action>()
{
    #region "Seção 10 Herança"

    // PROGRAMAÇÃO ORIENTADA A OBJETOS - Seção 10
    // Capítulo: Herança e Polimorfismo

    {"Seção 10 - Exercício Herança", ExerciseAccount.Executar},
    {"Seção 10 - Exercício Upcasting e downcasting", ExerciseUpDownCasting.Executar},
    {"Seção 10 - Exercício Sobreposição ou sobrescrita", ExcerciseOverlap.Executar},


    #endregion

});

central.SelecionarEExecutar();