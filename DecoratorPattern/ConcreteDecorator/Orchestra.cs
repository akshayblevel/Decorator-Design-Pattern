using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Orchestra : WeddingDecorator
    {
        public Orchestra(IWedding wedding)
            : base(wedding)
        {
            title = "Orchestra";
            budget = 200000;
        }
    }
}
