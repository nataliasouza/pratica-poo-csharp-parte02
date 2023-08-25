//Bloco finally

//• É um bloco que contém código a ser executado independentemente de ter
//ocorrido ou não uma exceção.

//• Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do
//processamento. (veja o exemplo abaixo)


namespace CursoParte02.Section11;

internal class ExerciseProcessFile 
{
    public static void Executar()
    {
        FileStream fileStream = null;
        try
        {
            fileStream = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string line = streamReader.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fileStream != null)
            {
                fileStream.Close();
            }
        }
    }
}
