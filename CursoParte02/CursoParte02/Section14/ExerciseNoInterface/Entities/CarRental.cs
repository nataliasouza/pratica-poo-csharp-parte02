namespace CursoParte02.Section14.ExerciseNoInterface.Entities;

internal class CarRental
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Vehicle Vehicle { get; private set; }
    public PaymentNote Invoice { get; set; }

    public CarRental(DateTime startTime, DateTime endTime, Vehicle vehicle)
    {
        StartTime = startTime;
        EndTime = endTime;
        Vehicle = vehicle;
        Invoice = null;
    }
}
