
using CursoParte02.Section14.ExerciseInterface.Model.Entities.Interface;
using CursoParte02.Section14.ExerciseInterface.Model.Enums;

namespace CursoParte02.Section14.ExerciseInterface.Model.Entities;

abstract class Shape : IShape
{
    public Color Color { get; set; }

    public abstract double Area();
}
