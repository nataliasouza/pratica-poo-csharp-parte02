
namespace CursoParte02.Section15.ExerciseSet
{
    internal class ExerciseSortedSet
    {
        public static void Executar()
        {
            SortedSet<int> set01 = new SortedSet<int>() { 0, 22, 5, 6, 8, 15 };
            SortedSet<int> set02 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //elementos ordenados
            PrintCollection(set01);

            //union
            SortedSet<int> setUnion = new SortedSet<int>(set01);
            setUnion.UnionWith(set02);
            PrintCollection(setUnion);

            //intersection
            SortedSet<int> setIntersect = new SortedSet<int>(set01);
            setIntersect.IntersectWith(set02);
            PrintCollection(setIntersect);

            //difference
            SortedSet<int> setDifference = new SortedSet<int>(set01);
            setDifference.ExceptWith(set02);
            PrintCollection(setDifference);

            static void PrintCollection<T>(IEnumerable<T>collection)
            {
                foreach (T item in collection)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
