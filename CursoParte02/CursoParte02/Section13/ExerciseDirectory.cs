//Directory, DirectoryInfo
//• Namespace System.IO
//• Operações com pastas (create, enumerate, get files, etc.).
//•
//Directory
//• static members (simple, but performs security check for each operation)
//• https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
//•
//DirectoryInfo
//• instance members
//• https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx

namespace CursoParte02.Section13;

internal class ExerciseDirectory
{
    public static void Executar()
    {
        string path = @"C:\exercicioArquivos";

        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            
            foreach (string item in folders)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("\nFILES: ");

            foreach (string item in files)
            {
                Console.WriteLine(item);
            }

            Directory.CreateDirectory(path + @"\newfoldergit ");
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(ex.Message);
        }
    }
}
