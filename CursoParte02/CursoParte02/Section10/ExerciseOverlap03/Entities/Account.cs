﻿//Sobreposição ou sobrescrita

//É a implementação de um método de uma superclasse na subclasse

//• Para que um método comum (não abstrato) possa ser sobreposto, deve
//ser incluído nele o prefixo "virtual"

namespace CursoParte02.Section10.ExerciseOverlap03.Entities;

internal class Account
{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }

    public Account() { }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public virtual void Withdraw(double amount)
    {
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}