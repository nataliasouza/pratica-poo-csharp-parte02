
using CursoParte02.Section15.ExerciseGetHashCodeEquals.Entities;

namespace CursoParte02.Section15.ExerciseGetHashCodeEquals
{
    internal class ExerciseGetHashCode
    {
        public static void Executar()
        {
            Client client = new Client 
            { 
                Name = "Mallu", 
                Email = "mallu@gmail.com" 
            };

            Client client02 = new Client
            {
                Name = "Mike",
                Email = "mike@gmail.com"
            };

            Client client03 = new Client
            {
                Name = "Max",
                Email = "mike@gmail.com"
            };

            Console.WriteLine(client.Equals(client02));//comparação feita pelo conteúdo, no caso compara os emails.
            Console.WriteLine(client02.Equals(client03));//Comparação verdadeira, pois possuem o mesmo e-mail.
            Console.WriteLine(client == client02); //comparando referência de mémoria.
            Console.WriteLine(client.GetHashCode());
            Console.WriteLine(client02.GetHashCode());
        }
    }
}
