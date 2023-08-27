
using CursoParte02.Section11.Parte01.Entities;

namespace CursoParte02.Section11.Parte02.Entities;

internal class Reservation02
{
    public int RoomNumber { get; set; }
    public DateTime Checkin { get; set; }
    public DateTime Checkout { get; set; }

    public Reservation02() { }

    public Reservation02(int roomNumber, DateTime checkin, DateTime checkout)
    {
        RoomNumber = roomNumber;
        Checkin = checkin;
        Checkout = checkout;
    }

    public int Duration()
    {
        TimeSpan duration = Checkout.Subtract(Checkin);
        return (int)duration.TotalDays;
    }

    public string UpdateDates(DateTime checkin, DateTime checkout)
    {
        DateTime now = DateTime.Now;

        if (checkin < now || checkout < now)
        {
            return "\nError in reservation: Reservation dates for update must be future dates";
        }
        
        if (checkout <= checkin)
        {
            return "\nError in reservation: Check-out date must be after check-in date";
        }        

        Checkin = checkin;
        Checkout = checkout;

        return null;
    }

    public override string ToString()
    {
        return $"\n\n\tRoom {RoomNumber}, " +
            $"\n\n\tCheckin: {Checkin.ToString("dd/MM/yyyy")}," +
            $"\n\tCheckout: {Checkout.ToString("dd/MM/yyyy")}," +
            $"\n\tDuration: {Duration()} nigths";
    }
}
