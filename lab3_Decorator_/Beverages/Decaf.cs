using lab3_Decorator_.Beverages;

namespace lab3_Decorator_.Beverages
{
    internal class Decaf : Beverage
    {
        public Decaf() : base("Напиток без кофеина", 15) { }

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
