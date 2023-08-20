
using CursoParte02.Section10.ExerciseMethodsAbstract09.Entities.Enums;

namespace CursoParte02.Section10.ExerciseMethodsAbstract09.Entities;

abstract class Shape
{
    public Color Color { get; set; }

    public Shape() { }

    protected Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();
}