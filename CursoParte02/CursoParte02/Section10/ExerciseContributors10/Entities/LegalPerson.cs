
namespace CursoParte02.Section10.ExerciseContributors10.Entities;

internal class LegalPerson : Contributors
{
    public int NumberOfEmployees { get; set; }

    public LegalPerson() { }

    public LegalPerson(string name, double annualIncome, int numberOfEmployees) 
        : base(name, annualIncome)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    public override double Tax()
    {
        if (NumberOfEmployees >= 10)
        {
            double taxRate = AnnualIncome * 0.14;
            return taxRate;
        }
        else 
        {
            double taxRate = AnnualIncome * 0.16;
            return taxRate;
        }                
    }
}
