using lab3_Decorator_.Beverages;

namespace lab3_Decorator_.CondimentDecorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; protected set; }

        public CondimentDecorator(string name, int price, Beverage beverage) : base(name, price)
        {
            Beverage = beverage;
        }
    }
}
