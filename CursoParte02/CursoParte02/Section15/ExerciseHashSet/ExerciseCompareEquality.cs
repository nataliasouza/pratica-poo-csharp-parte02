


using CursoParte02.Section15.ExerciseHashSet.Entities;

namespace CursoParte02.Section15.ExerciseHashSet
{
    internal class ExerciseCompareEquality
    {
        public static void Executar()
        {
            HashSet<Product> set = new HashSet<Product>();
            set.Add(new Product("TV", 2500.0));
            set.Add(new Product("Notebook", 6500.0));

            HashSet<Point> point = new HashSet<Point>();
            point.Add(new Point(3,4));
            point.Add(new Point(5,10));

            Product product = new Product("Notebook", 6500.0);
       
            Console.WriteLine(set.Contains(product));

            Point point1 = new Point(3,4);
            Console.WriteLine(point.Contains(point1));
        }
    }
}
