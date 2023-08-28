
//• Cláusula throw: lança a exceção / "corta" o método

//• O modelo de tratamento de exceções permite que erros sejam tratados de forma
//consistente e flexível, usando boas práticas

//• Vantagens:
//• Lógica delegada
//• Construtores podem ter exceções
//• Código mais simples. Não há aninhamento de condicionais: a qualquer momento que uma
//exceção for disparada, a execução é interrompida e cai no bloco catch correspondente.
//• É possível capturar inclusive outras exceções de sistema

using CursoParte02.Section11.Parte03.Entities;
using CursoParte02.Section11.Parte03.Exceptions;

namespace CursoParte02.Section11.Parte03;

internal class ExerciseExceptions03
{
    public static void Executar()
    {
        try
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
            DateTime checkout = DateTime.Parse(Console.ReadLine());


            Console.Clear();
            Reservation03 reservation = new Reservation03(roomNumber, checkin, checkout);
            Console.WriteLine($"\nRESERVATION: {reservation}");

            Console.WriteLine("\nEnter data to update the reservation: ");
            Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
            checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCheck-out date (dd/MM/yyyy):");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkin, checkout);

            Console.WriteLine("\nRESERVATION: " + reservation);
        }
        catch (DomainException ex) 
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }   
}
