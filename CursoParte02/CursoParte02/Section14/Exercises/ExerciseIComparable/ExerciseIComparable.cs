//Faça um programa para ler um arquivo contendo funcionários (nome e salário) no
//formato.csv, armazenando - os em uma lista. Depois, ordenar a lista por nome e mostrar
//o resultado na tela. Nota: o caminho do arquivo pode ser informado "hardcode".

using CursoParte02.Section14.Exercises.ExerciseIComparable.Entities;

namespace CursoParte02.Section14.Exercises.ExerciseIComparable;

internal class ExerciseIComparable
{
    public static void Executar()
    {
        string path = @"C:\listaNomes\listaFuncionarios.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();

                foreach (Employee employee in list)
                {
                    Console.WriteLine(employee);
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
