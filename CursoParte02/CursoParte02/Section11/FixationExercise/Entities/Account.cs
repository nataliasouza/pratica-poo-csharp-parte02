using CursoParte02.Section11.FixationExercise.Exceptions;
using System.Globalization;

namespace CursoParte02.Section11.FixationExercise.Entities;

internal class Account
{
    public int Number { get; protected set; }
    public string Holder { get; protected set; }
    public double Balance { get; protected set; }
    public double WithdrawLimit { get; protected set; } 

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public Account() { }


    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            if (WithdrawLimit >= amount)
            {
                Console.Clear();
                double result = Balance -= amount;
                
                Console.WriteLine($"\nDaily withdrawal value R$: {WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nwithdrawal amount R$: {amount.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nThe value in account R$:  {result.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                throw new DomainException("\nWithdrawal limit exceeded!\n" +
                    $"\nThe allowed amount for this account is R$: " +
                    $"{WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}\n");
            }
        }
        else
        {
            throw new DomainException("\nInsufficient funds!\n");
        }
    }

    //Código da aula

    //public void Withdraw(double amount)
    //{
    //    if (amount > WithdrawLimit)
    //    {
    //        throw new DomainException("The amount exceeds withdraw limit");
    //    }
    //    if (amount > Balance)
    //    {
    //        throw new DomainException("Not enough balance");
    //    }

    //    Balance -= amount;
    //}

    public override string ToString()
    {
        return $"\nCONTA BANCÁRIA: {Number}" +
            $"\nTitular: {Holder} " +
            $"\nSaldo: {Balance}";
    }
}
