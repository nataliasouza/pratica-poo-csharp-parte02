
namespace CursoParte02.Section14.ExerciseNoInterface.Services;

internal class BrazilTaxService
{
    public double Tax(double amount)
    {
        if (amount <= 100.00)
        {
            return amount * 0.2;
        }
        else
        {
            return amount * 0.15;
        }
    }
}
