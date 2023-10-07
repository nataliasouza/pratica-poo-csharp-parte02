
namespace CursoParte02.Section14.Exercises;

internal class Exercise02
{
    public static void Executar()
    {
        string path = @"C:\listaNomes\nomes.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<string> list = new List<string>();
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
                list.Sort();
                foreach (string str in list)
                {
                    Console.WriteLine(str);
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
