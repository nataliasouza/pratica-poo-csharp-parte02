
using CursoParte02.Section14.ExerciseMultipleInheritance.Entities;
using CursoParte02.Section14.ExerciseMultipleInheritance.Entities.Interfaces;

namespace CursoParte02.Section14.ExerciseMultipleInheritance;

internal class MultipleInheritance
{
    public static void Executar()
    {
        Printer printer = new Printer()
        { SerialNumber = 1013 };
        printer.ProcessDoc("My letter");
        printer.Print("My letter");

        Scanner scanner = new Scanner() { SerialNumber = 1014 };
        scanner.ProcessDoc("My Email");
        Console.WriteLine(scanner.Scan());

        ComboDevice comboDevice = new ComboDevice() { SerialNumber = 2201 };
        comboDevice.ProcessDoc("My dissertation");
        comboDevice.Print("My dissertation");
        Console.WriteLine(comboDevice.Scan());
    }
}
