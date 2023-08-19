
namespace CursoParte02.Section10.ExerciseProduct07.Entities;

internal class UsedProduct : Product
{   
    public DateTime ManufactureDate { get; protected set; }

    public UsedProduct() { }

    public UsedProduct(string name, double price, DateTime manufactureDate) 
        : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        return base.PriceTag() + 
            $"\nData de Fabricação: {ManufactureDate.ToShortDateString()}";
    }
}
