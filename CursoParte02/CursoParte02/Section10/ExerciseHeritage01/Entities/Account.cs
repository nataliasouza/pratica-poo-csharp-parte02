
namespace CursoParte02.Section10.ExerciseHeritage01.Entities
{
    internal class Account
    {
        public int Number { get; private set; } //número conta
        public string Holder { get; private set; } //titular
        public double Balance { get; protected set; } //saldo

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //saque
        public void Withdraw(double amount) //quantia
        {
            Balance -= amount;
        }

        //depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }    
}
