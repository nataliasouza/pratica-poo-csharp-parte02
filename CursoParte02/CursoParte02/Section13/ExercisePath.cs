
namespace CursoParte02.Section13;

internal class ExercisePath
{
    public static void Executar()
    {
        string sourcePath = @"C:\exercicioArquivos\exerciseFile.txt";

        Console.WriteLine("DirectorySeparatorChar:" + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator:" + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(sourcePath));
        Console.WriteLine("GetFileName:" + Path.GetFileName(sourcePath));
        Console.WriteLine("GetExtension:" + Path.GetExtension(sourcePath));
        Console.WriteLine("GetFileNameWithoutExtension:" + Path.GetFileNameWithoutExtension(sourcePath));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
        Console.WriteLine("GetTempPath: " + Path.GetTempPath());
    }
}
