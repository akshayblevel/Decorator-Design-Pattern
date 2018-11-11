using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Theme : WeddingDecorator
    {
        public Theme(IWedding wedding)
            : base(wedding)
        {
            title = "Theme";
            budget = 100000;
        }
    }
}
