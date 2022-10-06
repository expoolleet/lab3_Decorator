
namespace lab3_Decorator_
{
    public abstract class Beverage
    {
        public Beverage(string n, int p)
        {
            BaseName = n;
            Price = p;

        }

        public string BaseName { get; protected set; }

        public int Price { get; protected set; }

        public abstract int Cost();

        public abstract string GetDescription();

    }
}
