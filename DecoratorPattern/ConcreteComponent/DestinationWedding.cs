using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DestinationWedding : IWedding
    {
        public double Budget()
        {
            return 1000000;
        }

        public string Title()
        {
            return " Destination Weeding";
        }
    }
}
