namespace lab3_Decorator_.Decorators
{
    internal class Mocha : CondimentDecorator
    {
        private int price = 5;

        private string name = ", с мочей";

        public Mocha(Beverage b) : base(b.GetDescription(), b.Cost(), b) { }

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
