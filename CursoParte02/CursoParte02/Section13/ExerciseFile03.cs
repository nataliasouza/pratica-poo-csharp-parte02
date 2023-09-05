//using block
//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement

//Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
//Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser
//manualmente fechados.

//Exemplos: Font, FileStream, StreamReader, StreamWriter

namespace CursoParte02.Section13;

internal class ExerciseFile03
{
    public static void Executar()
    {
        string sourcePath = @"C:\exercicioArquivos\exerciseFile.txt";

        try
        {
            using (StreamReader streamReader = File.OpenText(sourcePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(ex.Message);
        }
    }
}
