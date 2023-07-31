
namespace Inheritance
{
    internal class Cat: Animal
    {
        readonly string name = "Кошка";
        public Cat(double weight, double height) : base(weight, height)
        {
        }

        public override string Action()
        {
            return "Бегает";
        }

        public override string Meal()
        {
            return "Ест мышей";
        }

        public override string Voice()
        {
            return "Мяукает";
        }

        public override string? ToString()
        {
            return $"{name} вес {Weight} г. рост {Height} см. {Meal()} {Voice()} {Action()}"; ;
        }

    }
}
