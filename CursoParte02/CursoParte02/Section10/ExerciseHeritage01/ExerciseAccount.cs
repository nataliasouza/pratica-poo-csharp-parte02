
//Suponha um negócio de banco que possui uma conta comum e uma conta para
//empresas, sendo que a conta para empresa possui todos membros da conta
//comum, mais um limite de empréstimo e uma operação de realizar empréstimo.

using CursoParte02.Section10.ExerciseHeritage01.Entities;

namespace CursoParte02.Section10.ExerciseHeritage01;

internal class ExerciseAccount
{
    public static void Executar()
    {
        BusinessAccount account = new BusinessAccount(3188, "Mike Souza", 7900.0, 80000.0);

        Console.WriteLine(account.Balance);

        // não permite que seja adiconado ou modificado nenhum valor, devido o modificador
        // de acesso protected na propriedade Balance, mas é possivel alterar o valor em uma 
        //subclasses de Account
        
        //account.Balance = 2000.0;
    }

}
