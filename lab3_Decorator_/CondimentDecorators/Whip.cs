using lab3_Decorator_.Beverages.AbstractClasses;

namespace lab3_Decorator_.CondimentDecorators
{
    internal class Whip : CondimentDecorator
    {
        private int price = 5;

        private string name = ", со сливками";

        public Whip(Beverage beverage) : base(beverage.GetDescription(), beverage.Cost(), beverage) { }

        public override int Cost()
        {
            return Beverage.Price + price;
        }

        public override string GetDescription()
        {
            return Beverage.BaseName + name;
        }
    }
}
