using lab3_Decorator_.Beverages.AbstractClasses;

namespace lab3_Decorator_.Beverages
{
    internal class Expresso : Beverage
    {
        public Expresso() : base("Эспрессо", 20) { }

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
