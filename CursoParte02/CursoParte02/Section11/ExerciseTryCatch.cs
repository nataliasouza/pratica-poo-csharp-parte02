﻿//Por que exceções?

//• O modelo de tratamento de exceções permite que erros sejam
//tratados de forma consistente e flexível, usando boas práticas.

//• Vantagens:

//• Delega a lógica do erro para a classe / método responsável por conhecer as
//regras que podem ocasionar o erro.
//• Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes.
//• A exceção pode carregar dados quaisquer.
//Estrutura try-catch

//Bloco try
//• Contém o código que representa a execução normal do trecho de código que
//pode acarretar em uma exceção

// Bloco catch
//• Contém o código a ser executado caso uma exceção ocorra
//• Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)

namespace CursoParte02.Section11;

internal class ExerciseTryCatch
{
    public static void Executar()
    {
        try
        {
            Console.Write("Enter first division number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second division number:");
            int number2 = int.Parse(Console.ReadLine());
            
            int divisionResult = number1 / number2;
            Console.WriteLine($"\n\tDivision result: {divisionResult}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error! " + e.Message);
        }
    }
}
