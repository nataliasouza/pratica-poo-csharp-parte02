//Uma empresa possui funcionários próprios e terceirizados.
//Para cada funcionário, deseja-se registrar nome, horas trabalhadas e valor por hora.
//Funcionários terceirizados possuem ainda uma despesa adicional.
//O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas,
//sendo que os //funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua
//despesa adicional.
//Fazer um programa para ler os dados de N funcionários (N fornecido pelo usuário) e armazená-los
//em uma lista. Depois de ler todos os dados, mostrar nome e pagamento de cada
//funcionário na mesma ordem em que foram digitados.

using CursoParte02.Section10.ExerciseEmployeed06.Entities;
using System.Globalization;

namespace CursoParte02.Section10.ExerciseEmployeed06;

internal class ExerciseEmployeed
{
    public static void Executar()
    {
        Console.Write("Enter the number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        List<Employee> listEmployees = new List<Employee>();
        
        for (int i = 0; i < numberOfEmployees; i++)
        {            
            Console.WriteLine($"\nEmployee # {i +1} data: ");
            Console.Write("\nOutsourced (y/n)?: ");
            char outsourced = char.Parse(Console.ReadLine());

            Console.Write("\nDigite o Nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite as horas trabalhadas: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por hora R$: ");
            double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(outsourced == 'y') 
            {
                Console.Write("Digite o valor da despesa adicional R$: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //listEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                Employee outsourcedEmployee = new OutsourcedEmployee(name,hours,valuePerHours, additionalCharge);
              
                listEmployees.Add(outsourcedEmployee);
            }
            else
            {
                Employee employee = new Employee(name, hours, valuePerHours);

                listEmployees.Add(employee);
            }            
        }

        Console.Clear();

        foreach (Employee employee in listEmployees)
        {
            Console.WriteLine($"\nNome colaborador(a): { employee.Name}" +
                $"\nPagamento: {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }               
    } 
}
