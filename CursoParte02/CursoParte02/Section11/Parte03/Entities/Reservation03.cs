
using CursoParte02.Section11.Parte03.Exceptions;

namespace CursoParte02.Section11.Parte03.Entities;

internal class Reservation03
{
    public int RoomNumber { get; set; }
    public DateTime Checkin { get; set; }
    public DateTime Checkout { get; set; }

    public Reservation03() { }

    public Reservation03(int roomNumber, DateTime checkin, DateTime checkout)
    {
        if (checkout <= checkin)
        {
            throw new DomainException("Check-out date must be after check-in date.");
        }

        RoomNumber = roomNumber;
        Checkin = checkin;
        Checkout = checkout;
    }

    public int Duration()
    {
        TimeSpan duration = Checkout.Subtract(Checkin);
        return (int)duration.TotalDays;
    }

    public void UpdateDates(DateTime checkin, DateTime checkout)
    {
        DateTime now = DateTime.Now;

        if (checkin < now || checkout < now)
        {
            throw new DomainException("\nError in reservation: Reservation dates for update must be future dates.");
        }

        if (checkout <= checkin)
        {
            throw new DomainException("\nError in reservation: Check-out date must be after check-in date.");
        }

        Checkin = checkin;
        Checkout = checkout;            
    }

    public override string ToString()
    {
        return $"\n\n\tRoom {RoomNumber}, " +
            $"\n\n\tCheckin: {Checkin.ToString("dd/MM/yyyy")}," +
            $"\n\tCheckout: {Checkout.ToString("dd/MM/yyyy")}," +
            $"\n\tDuration: {Duration()} nigths";
    }
}
