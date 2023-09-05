//FileStream
//https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx
//Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura
//e escrita.

//StreamReader
//https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx
//É uma stream capaz de ler caracteres a partir de uma stream binária (ex:
//FileStream).
//Suporte a dados no formato de texto.

namespace CursoParte02.Section13;

internal class ExerciseFile02
{
    public static void Executar()
    {
        string sourcePath = @"C:\exercicioArquivos\exerciseFile.txt";
        //FileStream fileStream = null;
        StreamReader streamReader = null;

        try
        {
            //fileStream = new FileStream(sourcePath,FileMode.Open);
            //streamReader = new StreamReader(fileStream);

            streamReader = File.OpenText(sourcePath);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            
        }
        catch (IOException ex)
        { 
            Console.WriteLine("An error accurred");
            Console.WriteLine(ex.Message);
        }

        finally
        {
            if(streamReader != null) streamReader.Close();
            //if(fileStream != null) fileStream.Close();
        }
    }
}

