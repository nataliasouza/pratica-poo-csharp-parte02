//StreamReader
//https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx

//É uma stream capaz de ler caracteres a partir de uma stream binária (ex:
//FileStream).

//Suporte a dados no formato de texto.
//Instanciação:
//• Vários construtores
//• File / FileInfo

namespace CursoParte02.Section13;

internal class ExerciseFile04
{
    public static void Executar()
    {
        string sourcePath = @"C:\exercicioArquivos\exerciseFile.txt";
       
        string targetPath = @"C:\exercicioArquivos\exerciseFile2.txt";
        try
        {
            string[] lines = File.ReadAllLines(sourcePath);
            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
