
namespace CursoParte02.Section14.ExerciseMultipleInheritance.Entities.Interfaces;

internal class Printer : Device, IPrinter 
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine("Printer processing: " + document);
    }

    public void Print(string document)
    {
        Console.WriteLine("Printer print" + document);
    }
}
