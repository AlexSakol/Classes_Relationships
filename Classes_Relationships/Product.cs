
namespace Assotiation
{
    internal class Product
    {
        private double? price;

        public Product(string name, double? price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double? Price
        {
            get => price;
            set
            {
                if (value < 0) price = null;
                else price = value;
            }
        }

        public override string? ToString()
        {
            return $"Товар {Name} цена {Price}";
        }

    }
}
