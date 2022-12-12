using lab3_Decorator_.Beverages;

namespace lab3_Decorator_.CondimentDecorators
{
    internal class Mocha : CondimentDecorator
    {
        private int price = 5;

        private string name = ", с мочей";

        public Mocha(Beverage beverage) : base(beverage.GetDescription(), beverage.Cost(), beverage) { }

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
