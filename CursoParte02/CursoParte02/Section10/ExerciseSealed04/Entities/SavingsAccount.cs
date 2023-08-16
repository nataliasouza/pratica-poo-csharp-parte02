//Classes e métodos selados

//• Palavra chave: sealed

//Classe: evita que a classe seja herdada
//Nota: ainda é possível extender a funcionalidade de uma classe selada usando "extension methods"

namespace CursoParte02.Section10.ExerciseSealed04.Entities;

sealed class SavingsAccount : Account
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

    //Método Sealed: evita que um método sobreposto possa ser sobreposto novamente
    //• Só pode ser aplicado a métodos sobrepostos

    public sealed override void Withdraw(double amount)
    {
        base.Withdraw(amount);
        Balance -= 2.0;
    }
}
