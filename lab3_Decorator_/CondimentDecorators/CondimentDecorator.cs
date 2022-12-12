using lab3_Decorator_.Beverages.AbstractClasses;

namespace lab3_Decorator_
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; protected set; }

        public CondimentDecorator(string name, int price, Beverage beverage) : base(name, price)
        {
            this.Beverage = beverage;
        }
    }
}
