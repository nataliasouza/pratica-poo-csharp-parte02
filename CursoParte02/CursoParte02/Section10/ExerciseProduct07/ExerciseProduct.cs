//Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). 
//Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
//Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
//produtos usados possuem data de fabricação. Estes dados específicos devem ser
//acrescentados na etiqueta de preço conforme exemplo (próxima página). Para produtos
//importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.

using CursoParte02.Section10.ExerciseProduct07.Entities;
using System.Globalization;

namespace CursoParte02.Section10.ExerciseProduct07;

internal class ExerciseProduct
{
    public static void Executar()
    {
        List<Product> listOfProducts = new List<Product>();

        Console.Write("Enter the number of products: ");
        int quantityOfProducts = int.Parse(Console.ReadLine());

        for(int i = 0; i < quantityOfProducts; i++) 
        {
            Console.WriteLine($"\nProduto: # {i+1} data");
            Console.Write("Digite apenas a letra correspondente: " +
                "\n\tNovo, usado or importado (n/u/i): ");
            char chosenOption = char.Parse(Console.ReadLine());

            Console.Write("\nDigite o Nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite o Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (chosenOption == 'n')
            {
                listOfProducts.Add(new Product (name, price));
            }
            
            else if(chosenOption == 'u' )
            {
                Console.Write("Digite a data de compra (exemplo: 19/08/2020): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                listOfProducts.Add(new UsedProduct ( name, price, manufactureDate.Date));
            } 
            
            else
            {
                Console.Write("Digite a taxa de importação: ");
                double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listOfProducts.Add(new ImportedProduct ( name, price, customFee));
            }
            Console.Clear();
        }
        Console.Clear();

        foreach (Product product in listOfProducts)
        {
            Console.WriteLine($"\nNome produto: {product.Name}" +
            $"\nPreço: {product.PriceTag()}");
        }
    }}
