
using System.Globalization;

namespace CursoParte02.Section14.ExerciseWithInterface.Entities;

internal class PaymentNote
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public PaymentNote(double rental, double tax)
    {
        BasicPayment = rental;
        Tax = tax;
    }

    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString()
    {
        return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
    }
}
