//• Realiza operações com arquivos (create, copy, delete, move, open, etc.) e
//ajuda na criação de objetos FileStream.

//• File
//• static members (simples, mas realiza verificação de segurança para cada operação)
//• https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx

//• FileInfo
//• instance members
//• https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx

namespace CursoParte02.Section13;

internal class ExerciseFile
{
    public static void Executar()
    {
        string sourcePath = @"C:\exercicioArquivos\exerciseFile.txt";
        string targetPath = @"C:\exercicioArquivos\exerciseFile2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
        } 
        catch (IOException ex)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(ex.Message);
        }
    }
}
