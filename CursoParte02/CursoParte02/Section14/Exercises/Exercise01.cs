//Exercício

//Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por
//linha), armazenando - os em uma lista. Depois, ordenar os dados dessa lista e mostra-los
//ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".
//Maria Brown
//Alex Green
//Bob Grey
//Anna White
//Alex Black
//Eduardo Rose
//Willian Red
//Marta Blue
//Alex Brown

namespace CursoParte02.Section14.ExerciseInterfaceIComparable;

internal class Exercise01
{
    public static void Executar() 
    {
        string path = @"C:\listaNomes\nomes.txt";        

        try
        {
            FileInfo fileInfo = new FileInfo(path);
            string[] lines = File.ReadAllLines(path);

            Array.Sort(lines);

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
