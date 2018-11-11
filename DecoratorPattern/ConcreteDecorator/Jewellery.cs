using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Jewellery : WeddingDecorator
    {
        public Jewellery(IWedding wedding)
            : base(wedding)
        {
            title = "Jewellery";
            budget = 500000;
        }
    }
}
