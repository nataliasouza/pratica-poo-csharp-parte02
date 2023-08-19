using System.Globalization;
using System.Text;

namespace CursoParte02.Section10.ExerciseProduct07.Entities;

internal class ImportedProduct : Product
{
    public double CustomFee { get; protected set; }

    public ImportedProduct() { }

    public ImportedProduct(string name, double price, double customFee) : base(name, price)
    {
        CustomFee = customFee;
    }

    public override string PriceTag()
    {
        StringBuilder sb = new ();
        sb.Append($"{base.PriceTag()} " +
            $"\nTaxa importação R$: {CustomFee.ToString("F2",CultureInfo.InvariantCulture)}" +
            $"\nPreço Total: {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }

    public double TotalPrice()
    {
        return Price + CustomFee;
    }
}
