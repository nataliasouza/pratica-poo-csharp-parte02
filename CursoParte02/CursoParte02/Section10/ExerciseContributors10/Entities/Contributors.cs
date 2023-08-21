
namespace CursoParte02.Section10.ExerciseContributors10.Entities;

abstract class Contributors
{
    public string Name { get; set; }
    public double AnnualIncome { get; set; }

    public Contributors() { }

    protected Contributors(string name, double annualIncome)
    {
        Name = name;
        AnnualIncome = annualIncome;
    }

    public abstract double Tax();      
}
