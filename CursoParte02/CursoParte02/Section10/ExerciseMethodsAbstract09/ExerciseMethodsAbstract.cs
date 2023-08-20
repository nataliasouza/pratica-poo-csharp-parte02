//Métodos abstratos

//• São métodos que não possuem implementação.
//• Métodos precisam ser abstratos quando a classe
//é genérica demais para conter sua implementação.

//• Se uma classe possuir pelo menos um método
//abstrato, então esta classe também é abstrata.

//• Notação UML: itálico

//Fazer um programa para ler os dados de N figuras (N fornecido pelo usuário),
//e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.

using CursoParte02.Section10.ExerciseMethodsAbstract09.Entities;
using CursoParte02.Section10.ExerciseMethodsAbstract09.Entities.Enums;
using System.Globalization;

namespace CursoParte02.Section10.ExerciseMethodsAbstract09;

internal class ExerciseMethodsAbstract
{
    public static void Executar()
    {
        List<Shape> listOfShapes = new List<Shape>();

        Console.Write("Enter the number of shapes: ");
        int numberOfShapes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfShapes; i++)
        {
            Console.WriteLine($"\nShape #{i} data:");
            Console.Write("Rectangle or Circle (r/c)? ");
            char choice = char.Parse(Console.ReadLine());
            
            Console.Write("Color (Black/Blue/Red): ");

            Color color = Enum.Parse<Color>(Console.ReadLine());
            if (choice == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listOfShapes.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listOfShapes.Add(new Circle(radius, color));
            }
        }

        Console.WriteLine();
        Console.WriteLine("SHAPE AREAS:");
        foreach (Shape shape in listOfShapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

