
using CursoParte02.Section10.ExerciseMethodsAbstract09.Entities.Enums;

namespace CursoParte02.Section10.ExerciseMethodsAbstract09.Entities;

internal class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle() { }

    public Rectangle(double width, double heigth, Color color) : base(color)
    {
        Width = width;
        Height = heigth;
    }

    public override double Area()
    {
        return Width * Height;
    }
}
