
namespace CursoParte02.Section10.ExerciseSealed04;

internal class ExerciseSealed
{
    public static void Executar()
    {
        Console.WriteLine("Para saber detalhes de classe e métodos selados, \n\tveja a classe SavingsAccount");
        Console.WriteLine("\nPra quê?\n");
        Console.WriteLine(" ==> SEGURANÇA: ");
        Console.WriteLine("\n\tDependendo das regras do negócio, às vezes é desejável " +
            "garantir que uma classe não seja herdada, \n\tou que um método não seja sobreposto.");
        Console.WriteLine("\n\n\t* Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas " +
            "\n\t podem ser uma porta de entrada para inconsistências");
        
        Console.WriteLine("\n\n ==> PERFORMANCE");
        Console.WriteLine("\n\t Atributos de tipo de uma classe selada são analisados de forma " +
            "mais rápida em tempo de execução.");
        Console.WriteLine("\n\n\t• Exemplo clássico: string");
    }
}
