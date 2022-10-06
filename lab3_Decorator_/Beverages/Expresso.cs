using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
