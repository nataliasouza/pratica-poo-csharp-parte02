
namespace CursoParte02.Section15
{
    internal class ExercisePrintService
    {
        public static void Executar()
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("Quantos valores você vai digitar?: ");
            int quantityOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityOfNumbers; i++)
            {
                Console.Write($"Digite o {i+1} número: ");
                int number = int.Parse(Console.ReadLine());
                printService.AddValue(number);
            }

            Console.WriteLine("\nOs números digitados foram: ");
            printService.PrintElements();
            Console.WriteLine("\n\nPrimeiro Elemento: " + printService.FirstElement());
        }
    }
}
