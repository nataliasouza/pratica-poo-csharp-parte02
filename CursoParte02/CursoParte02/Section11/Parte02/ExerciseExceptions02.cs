
using CursoParte02.Section11.Parte02.Entities;

namespace CursoParte02.Section11.Parte02;

internal class ExerciseExceptions02
{
    public static void Executar()
    {
        Console.Write("Room number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
        DateTime checkin = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
        DateTime checkout = DateTime.Parse(Console.ReadLine());

        if (checkout <= checkin)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after checkin date");
        }
        else
        {
            Console.Clear();
            Reservation02 reservation = new Reservation02(roomNumber, checkin, checkout);
            Console.WriteLine($"RESERVATION: {reservation}");

            Console.WriteLine("\nEnter data to update the reservation: ");
            Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
            checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCheck-out date (dd/MM/yyyy):");
            checkout = DateTime.Parse(Console.ReadLine());

            string error = reservation.UpdateDates(checkin, checkout);

            if (error != null)
            {
                Console.WriteLine("Error: " + error);
            }
            else
            {
                Console.WriteLine("\nRESERVATION: " + reservation);
            }
        }
    }
}
