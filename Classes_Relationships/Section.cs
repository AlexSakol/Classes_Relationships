

namespace Assotiation
{
    internal class Section
    {
        public string Name { get; set; }
        public Product[]? products;

        public Section(string name)
        {
            Name = name;
        }

        public override string? ToString()
        {
            string str;
            if (products != null)
            {
                string s = $"Секция {Name} товаров {products.Length}\n";
                foreach (var product in products)
                {
                    s += $"{product.ToString()}\n";
                }
                str = s;
            }
            else str = $"В cекции {Name} нет товаров";
            return str;
        }

    }
}
