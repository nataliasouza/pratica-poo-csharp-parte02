
using System.Globalization;
using System.Text;

namespace CursoParte02.Section14.ExerciseInterface.Model.Entities;

internal class Circle : Shape
{
    public double Radius { get; set; }  
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Circle color = {Color}" );
        sb.AppendLine($"Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");

        return sb.ToString();
    }
}
