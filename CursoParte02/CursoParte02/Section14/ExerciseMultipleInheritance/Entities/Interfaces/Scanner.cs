
namespace CursoParte02.Section14.ExerciseMultipleInheritance.Entities.Interfaces;

internal class Scanner : Device, IScanner
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine("Scanner processing" + document);
    }

    public string Scan() 
    {
        return "Scanner scan result";
    }
}
