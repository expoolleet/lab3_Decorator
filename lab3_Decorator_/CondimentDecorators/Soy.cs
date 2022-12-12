using lab3_Decorator_.Beverages.AbstractClasses;

namespace lab3_Decorator_.CondimentDecorators
{
    internal class Soy : CondimentDecorator
    {
        private int price = 10;

        private string name = ", c соей";

        public Soy(Beverage beverage) : base(beverage.GetDescription(), beverage.Cost(), beverage) { }

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
