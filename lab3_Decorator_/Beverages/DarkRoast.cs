using lab3_Decorator_.Beverages.AbstractClasses;

namespace lab3_Decorator_.Beverages
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast() : base("Кофе из зёрен темной обжарки", 30) { }

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
