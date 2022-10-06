
namespace lab3_Decorator_.Decorators
{
    internal class Milk : CondimentDecorator
    {
        private int price = 5;

        private string name = ", с молоком";

        public Milk(Beverage b) : base(b.GetDescription(), b.Cost(), b) { }

        public override int Cost()
        {
            return beverage.Price + price;
        }

        public override string GetDescription()
        {
            return beverage.BaseName + name;
        }
    }
}
