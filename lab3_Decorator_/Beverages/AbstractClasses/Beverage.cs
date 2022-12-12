namespace lab3_Decorator_.Beverages.AbstractClasses
{
    public abstract class Beverage
    {
        public Beverage(string name, int price)
        {
            BaseName = name;
            Price = price;
        }

        public string BaseName { get; protected set; }

        public int Price { get; protected set; }

        public abstract int Cost();

        public abstract string GetDescription();
    }
}
