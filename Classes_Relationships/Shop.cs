
namespace Assotiation
{
    internal class Shop
    {
        Section[] sections;
        public Shop(string name, params Section[] section)
        {
            Name = name;
            this.sections = section;
        }

        public Shop(string name)
        {
            Name = name;
            sections = new Section[1];
            sections[0] = new("unknown");
        }

        public Shop() : this("unknown")
        {
        }

        public string Name { get; set; }

        private bool CheckProduct(Product product)// Check the availability of the product in the section 
        {
            bool flag = true;
            foreach (var item in sections)
            {
                if (item.products != null)
                {
                    foreach (var good in item.products)
                    {
                        if (good == product) flag = false;
                    }
                }
            }
            return flag;
        }

        private bool CheckSection(Section section) // Check the availability of the section in the shop 
        {
            bool flag = false;
            foreach (var item in sections)
            {
                if (item == section) flag = true;
            }
            return flag;
        }

        public string AddProduct(Product product, Section section) // Add a product in the section
        {
            if (CheckProduct(product) == true && CheckSection(section) == true)
            {
                if (section.products == null) section.products = new Product[0];
                Array.Resize(ref section.products, section.products.Length + 1);
                section.products[section.products.Length - 1] = product;
                return $"Товар {product.Name} успешно добавлен в секцию {section.Name}\n";
            }
            else if (CheckSection(section) == false)
            {
                return $"Cекции {section.Name} нет в магазине {Name}\n";
            }
            else return $"Товар {product.Name} уже был добавлен в секцию {section.Name}\n";
        }

        public override string? ToString()
        {
            string str = $"Магазин {Name} секций {sections.Length}\n";
            foreach (var section in sections)
            {
                str += $"{section.ToString()}\n";
            }
            return str;
        }
    }
}
