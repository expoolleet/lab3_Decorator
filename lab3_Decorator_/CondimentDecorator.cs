
namespace lab3_Decorator_
{
    public abstract class CondimentDecorator : Beverage
    {

        protected Beverage beverage;

        public CondimentDecorator(string n, int p, Beverage beverage) : base(n, p)
        {
                this.beverage = beverage;
        }
    }
}
