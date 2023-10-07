
using System.Globalization;
using System.Text;

namespace CursoParte02.Section14.ExerciseInterface.Model.Entities;

internal class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Rectangle color = {Color}");
        sb.AppendLine($"Width = {Width.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");

        return sb.ToString();
    }
}
