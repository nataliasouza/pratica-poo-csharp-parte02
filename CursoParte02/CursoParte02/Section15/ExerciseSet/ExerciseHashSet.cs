namespace CursoParte02.Section15.ExerciseSet
{
    internal class ExerciseHashSet
    {
        public static void Executar()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");            

            Console.WriteLine("\nItems do conjunto: \n");

            foreach (string item in set) 
            { 
                Console.WriteLine($"{item}" ); 
            }

            Console.WriteLine("\n\nExiste no conjunto a palavra: Notebook");
            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine("\nExiste no conjunto a palavra: Mouse");
            Console.WriteLine(set.Contains("Mouse"));
        }
    }
}
