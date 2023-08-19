
namespace CursoParte02.Section10.ExerciseEmployeed06.Entities;

internal class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; protected set; }

    public OutsourcedEmployee() { }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
        : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        double payment = base.Payment();
        double calculateAdditionalCharge = AdditionalCharge * 1.1;
        double totalPayment = calculateAdditionalCharge + payment;

        return totalPayment;
    }
}
