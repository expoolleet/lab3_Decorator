using lab3_Decorator_.Beverages;

namespace lab3_Decorator_.CondimentDecorators
{
    internal class Milk : CondimentDecorator
    {
        private int price = 5;

        private string name = ", с молоком";

        public Milk(Beverage b) : base(b.GetDescription(), b.Cost(), b) { }

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
