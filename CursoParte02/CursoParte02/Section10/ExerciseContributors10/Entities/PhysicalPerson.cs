
namespace CursoParte02.Section10.ExerciseContributors10.Entities;

internal class PhysicalPerson : Contributors
{
    public double HealthExpenses { get; set; }

    public PhysicalPerson() { }

    public PhysicalPerson(string name, double annualIncome, double healthExpenses) 
        : base(name, annualIncome)
    {
        HealthExpenses = healthExpenses;
    }

    public override double Tax()
    {
        if (AnnualIncome < 20000.0)
        {
            double taxRate = AnnualIncome * 0.15 - HealthExpenses * 0.5;
            return taxRate;
        }

        else
        { 
            double taxRate = AnnualIncome * 0.25 - HealthExpenses * 0.5;
            return taxRate;
        }
    }
}
