﻿
using System.Globalization;
namespace CursoParte02.Section15.ExerciseRestrictionGenerics.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Erro de comparação, o argumento não é um Produto");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return Name + ","
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
