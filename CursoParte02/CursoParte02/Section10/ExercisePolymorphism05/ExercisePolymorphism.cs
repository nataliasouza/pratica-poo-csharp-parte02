
using CursoParte02.Section10.ExercisePolymorphism05.Entities;

namespace CursoParte02.Section10.ExercisePolymorphism05;

internal class ExercisePolymorphism
{
    public static void Executar()
    {
        // A associação do tipo específico com o tipo genérico é feita em tempo de
        //execução(upcasting).

        //• O compilador não sabe para qual tipo específico a chamada do método
        //Withdraw está sendo feita(ele só sabe que são duas variáveis tipo Account):

        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);
        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);
    }
}
