
namespace CursoParte02.Section10.ExerciseSealed04.Entities;

internal class BusinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinessAccount()
    {
    }

    //É possível chamar a implementação da superclasse usando a palavra base.
    public BusinessAccount(int number, string holder, double balance, double loanLimit)
        : base(number, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit)
        {
            Balance += amount;
        }
    }
}
