
//Problema exemplo

//Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
//de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
//dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
//novamente a reserva com os dados atualizados. O programa não deve aceitar dados
//inválidos para a reserva, conforme as seguintes regras:
//-Alterações de reserva só podem ocorrer para datas futuras
//- A data de saída deve ser maior que a data de entrada

using CursoParte02.Section11.Parte01.Entities;

namespace CursoParte02.Section11.Parte01;

internal class ExerciseExceptions01
{
    public static void Executar()
    {
        Console.Write("Room number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
        DateTime checkin = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
        DateTime checkout = DateTime.Parse(Console.ReadLine());

        if(checkout <= checkin)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after checkin date");
        }
        else
        {
            Console.Clear();
            Reservation reservation = new Reservation(roomNumber, checkin, checkout);
            Console.WriteLine($"RESERVATION: {reservation}");

            Console.WriteLine("\nEnter data to update the reservation: ");
            Console.WriteLine("\nCheck-in date (dd/MM/yyyy):");
            checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCheck-out date (dd/MM/yyyy):");
            checkout = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                Console.WriteLine("\nError in reservation: Reservation dates for update must be future dates");
            }
            else if (checkout <= checkin)
            {
                Console.WriteLine("\nError in reservation: Check-out date must be after check-in date");
            }
            else
            {
                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("\nRESERVATION: " + reservation);
            }
        }        
    }
}
