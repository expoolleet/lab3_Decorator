
namespace lab3_Decorator_.Beverages
{
    internal class HouseBlend : Beverage
    {

        public HouseBlend() : base("Домашнее кофе", 20) { }

        public override int Cost()
        {
            return Price;
        }

        public override string GetDescription()
        {
            return BaseName;
        }

    }
}
