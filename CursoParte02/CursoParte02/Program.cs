
using CursoParte02;
using CursoParte02.Section10.ExerciseHeritage01.Entities;

var central = new ExerciseCenter(new Dictionary<string, Action>()
{
    #region "Seção 10 Herança"

    // PROGRAMAÇÃO ORIENTADA A OBJETOS - Seção 10
    // Capítulo: Herança e Polimorfismo

    {"Seção 10 - Exercício Herança", Heritage.Executar},


    #endregion

});

central.SelecionarEExecutar();