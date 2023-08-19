
using System.Globalization;

namespace CursoParte02.Section10.ExerciseProduct07.Entities;

internal class Product
{ 
    public string Name { get; protected set; }
    public double Price { get; protected set; }

    public Product() { }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string PriceTag()
    {
        return Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}
