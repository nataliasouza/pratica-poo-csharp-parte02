
using CursoParte02.Section14.ExerciseNoInterface.Entities;
using CursoParte02.Section14.ExerciseNoInterface.Services;

namespace CursoParte02.Section14.ExerciseNoInterface;

internal class ExerciseNoInterface
{
    public static void Executar()
    {
        Console.WriteLine("ENTER A RENTAL DATA");
        Console.Write("Car Model: ");
        string model = Console.ReadLine();

        Console.Write("Enter start time: neste formato => (dd/MM/yyyy:mm): ");
        DateTime startTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter end time: neste formato => (dd/MM/yyyy:mm): ");
        DateTime endTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine());

        Console.Write("Enter price per day: ");
        double pricePerDay = double.Parse(Console.ReadLine());

        CarRental carRental = new CarRental(startTime, endTime, new Vehicle(model));

        RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("PAYMENT NOTE:");
        Console.WriteLine(carRental.Invoice);
    }
}
