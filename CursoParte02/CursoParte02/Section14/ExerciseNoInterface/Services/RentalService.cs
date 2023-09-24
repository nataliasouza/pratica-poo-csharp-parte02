﻿
using CursoParte02.Section14.ExerciseNoInterface.Entities;

namespace CursoParte02.Section14.ExerciseNoInterface.Services;

internal class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    private BrazilTaxService _brazilTaxService = new BrazilTaxService();

    public RentalService(double pricePerHour, double pricePerDay)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void ProcessInvoice(CarRental carRental)
    {

        TimeSpan duration = carRental.EndTime.Subtract(carRental.StartTime);

        double basicPayment = 0.0;
        if (duration.TotalHours <= 12.0)
        {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
        }
        else
        {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = _brazilTaxService.Tax(basicPayment);

        carRental.Invoice = new PaymentNote(basicPayment, tax);
    }
}
