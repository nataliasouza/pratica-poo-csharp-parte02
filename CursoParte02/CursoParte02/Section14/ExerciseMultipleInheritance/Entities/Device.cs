
namespace CursoParte02.Section14.ExerciseMultipleInheritance.Entities;

public abstract class Device
{
    public int SerialNumber { get; set; }

    public abstract void ProcessDoc(string document);

}

