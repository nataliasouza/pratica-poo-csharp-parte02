
//Exercício de fixação

//Fazer um programa para ler os dados de uma conta bancária e depois realizar um
//saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
//ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
//saque da conta.

using CursoParte02.Section11.FixationExercise.Entities;
using CursoParte02.Section11.FixationExercise.Exceptions;
using System.Globalization;

namespace CursoParte02.Section11.FixationExercise;

internal class ExerciseBankAccount
{   
   public static void Executar()
   {
        Console.Write("Digite o número da conta: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do titular: ");
        string holder = Console.ReadLine();

        Console.Write("Digite o saldo inicial: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Digite o limite diário de saque: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
     
        Account account = new Account(accountNumber, holder, balance, withdrawLimit);

        Console.Write("\nDigite o valor do saque R$: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        try
        {
            account.Withdraw(amount);

            Console.WriteLine("\nDados da conta: " +
                "\n" + account.ToString());
        }
        catch (DomainException ex)
        {
            Console.WriteLine("\nError: " + ex);
        }
   }
}
