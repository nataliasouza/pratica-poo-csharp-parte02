﻿
namespace CursoParte02.Section10.ExerciseHeritage02.Entities;

//Conta Poupança
internal class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount() { }

    public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
    {
        InterestRate = interestRate; //taxa de juros
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }
}
