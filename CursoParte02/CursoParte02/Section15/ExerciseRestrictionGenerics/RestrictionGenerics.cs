using CursoParte02.Section15.ExerciseRestrictionGenerics.Entities;
using CursoParte02.Section15.ExerciseRestrictionGenerics.Services;
using System.Globalization;

namespace CursoParte02.Section15.ExerciseRestrictionGenerics
{
    internal class RestrictionGenerics
    {
        public static void Executar()
        {
            List<Product> listOfProducts = new List<Product>();

            Console.Write("Quantos produtos você vai digitar?: ");
            int quantityOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityOfNumbers; i++)
            {
                Console.Write($"Digite o {i + 1} produto: ");
                string[] vectOfProduct = Console.ReadLine().Split(',');
                string name = vectOfProduct[0];
                double price = double.Parse(vectOfProduct[1], CultureInfo.InvariantCulture);

                listOfProducts.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product biggestPrice = calculationService.BiggestPrice(listOfProducts);

            Console.WriteLine("\nProduto mais caro: \n\n\t\t" + biggestPrice);
           
        }     
    }
}
