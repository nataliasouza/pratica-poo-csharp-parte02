//Classes abstratas

//• São classes que não podem ser instanciadas

//• É uma forma de garantir herança total: somente subclasses não
//abstratas podem ser instanciadas, mas nunca a superclasse abstrata

using CursoParte02.Section10.ExerciseClassAbstract08.Entities;
using System.Globalization;

namespace CursoParte02.Section10.ExerciseClassAbstract08;

internal class ExerciseClassAbstract
{
    public static void Executar()
    {
        List<Account> listOfAccounts = new List<Account>();

        listOfAccounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
        listOfAccounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        listOfAccounts.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
        listOfAccounts.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

        double sum = 0.0;
        foreach (Account account in listOfAccounts)
        {
            sum += account.Balance;
        }

        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (Account account in listOfAccounts)
        {
            account.Withdraw(10.0);
        }

        foreach (Account account in listOfAccounts)
        {
            Console.WriteLine("Updated balance for account "
                + account.Number
                + ": "
                + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
