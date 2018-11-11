using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class TraditionalWedding : IWedding
    {
        public double Budget()
        {
            return 100000;
        }

        public string Title()
        {
            return " Traditional Weeding";
        }
    }
}
