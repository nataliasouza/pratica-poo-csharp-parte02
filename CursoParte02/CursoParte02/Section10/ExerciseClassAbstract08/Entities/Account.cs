//Suponha que em um negócio relacionado a banco, apenas
//contas poupança e contas para empresas são permitidas.
//Não existe conta comum.
//Para garantir que contas comuns não possam ser instanciadas, basta acrescentarmos
//a palavra "abstract" na declaração da classe.

namespace CursoParte02.Section10.ExerciseClassAbstract08.Entities;

abstract class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

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
