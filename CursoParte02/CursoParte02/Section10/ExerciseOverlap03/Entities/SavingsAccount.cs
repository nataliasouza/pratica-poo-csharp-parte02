
namespace CursoParte02.Section10.ExerciseOverlap03.Entities;

internal class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount() { }

    public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

    //Ao sobrescrever um método, devemos incluir nele o prefixo "override"
    public override void Withdraw(double amount)
    {
        base.Withdraw(amount);
        Balance -= 2.0;
    }
}
