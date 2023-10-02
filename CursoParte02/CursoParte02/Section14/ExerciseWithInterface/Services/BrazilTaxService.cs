﻿
namespace CursoParte02.Section14.ExerciseWithInterface.Services;

internal class BrazilTaxService : ITaxService
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
