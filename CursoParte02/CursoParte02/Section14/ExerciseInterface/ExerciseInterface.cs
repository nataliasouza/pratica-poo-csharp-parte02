
using CursoParte02.Section14.ExerciseInterface.Model.Entities;
using CursoParte02.Section14.ExerciseInterface.Model.Entities.Interface;
using CursoParte02.Section14.ExerciseInterface.Model.Enums;

namespace CursoParte02.Section14.ExerciseInterface;

internal class ExerciseInterface
{
    public static void Executar()
    {
        IShape shape1 = new Circle() 
        {
            Radius = 2.0, Color = Color.White
        };

        IShape shape2 = new Rectangle()
        {
            Width = 3.5,
            Height = 4.2,
            Color = Color.Black
        };

        Console.WriteLine(shape1);
        Console.WriteLine(shape2);
    }
}
