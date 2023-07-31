

namespace Inheritance
{
    internal sealed class Worm: Animal 
    {
        readonly string name = "Червь";
        double lehgth;

        public double Lehgth { get => lehgth; set => lehgth = value; }

        public Worm()
        {
        }

        public Worm(double lehgth, double weight, double height) : base(weight, height)
        {
            Lehgth = lehgth;
        }

        public override string Action()
        {
            return "Копает";
        }

        new public string Meal()
        {
            return base.Meal() + " и землю";
        }
        public override string Voice()
        {
            return "Молчит";
        }

        public override string? ToString()
        {
            return $"{name} длина {Lehgth} см. вес {Weight} г. рост {Height} см. {Meal()} {Voice()} {Action()}";
        }
    }
}
