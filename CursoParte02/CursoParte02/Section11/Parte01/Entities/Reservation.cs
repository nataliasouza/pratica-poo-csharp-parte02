
namespace CursoParte02.Section11.Parte01.Entities;

internal class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime Checkin { get; set; }
    public DateTime Checkout { get; set; }

    public Reservation() { }  

    public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
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

    public void UpdateDates(DateTime checkin, DateTime checkout)
    {
        Checkin = checkin;
        Checkout = checkout;
    }

    public override string ToString()
    {
        return $"\n\n\tRoom {RoomNumber}, " +
            $"\n\n\tCheckin: {Checkin.ToString("dd/MM/yyyy")}," +
            $"\n\tCheckout: {Checkout.ToString("dd/MM/yyyy")},"+
            $"\n\tDuration: {Duration()} nigths";          
    }
}
