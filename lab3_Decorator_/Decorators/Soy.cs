
namespace lab3_Decorator_.Decorators
{
    internal class Soy : CondimentDecorator
    {
        private int price = 10;

        private string name = ", c соей";
        public Soy(Beverage b) : base(b.GetDescription(), b.Cost(), b) { }

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
