
using CursoParte02.Section14.ExerciseMultipleInheritance.Entities.Interfaces;

namespace CursoParte02.Section14.ExerciseMultipleInheritance.Entities;

internal class ComboDevice : Device, IScanner, IPrinter
{   
    public override void ProcessDoc(string document)
    {
        Console.WriteLine("ComboDevice print " + document);
    }
    public string Scan()
    {
        return "ComboDevice scan result";
    }
    public void Print(string document)
    {
        Console.WriteLine("ComboDevice processing " + document);
    }   
}
