using CursoParte02.Section14.ExerciseWithInterface.Entities;
using CursoParte02.Section14.ExerciseWithInterface.Services;
using System.Globalization;

namespace CursoParte02.Section14.ExerciseWithInterface;

internal class ExerciseWithInterface
{
    public static void Executar()
    {
        Console.WriteLine("ENTER A RENTAL DATA");
        Console.Write("Car Model: ");
        string model = Console.ReadLine();

        Console.Write("Enter start time: neste formato => (dd/MM/yyyy HH:mm): ");
        DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter end time: neste formato => (dd/MM/yyyy:mm): ");
        DateTime endTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter price per day: ");
        double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(startTime, endTime, new Vehicle(model));

        RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("\nPAYMENT NOTE:");
        Console.WriteLine(carRental.Invoice);
    }
}
