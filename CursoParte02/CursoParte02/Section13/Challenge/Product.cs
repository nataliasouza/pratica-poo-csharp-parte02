
namespace CursoParte02.Section13.Challenge;

internal class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount{ get; set; }

    public Product()
    {
        
    }

    public Product(string name, double price,int amount)
    {
        Name = name;
        Price = price;
        Amount = amount;
    }

    public double GetTotalItemValue()
    {
        return Amount * Price;
    }

}
