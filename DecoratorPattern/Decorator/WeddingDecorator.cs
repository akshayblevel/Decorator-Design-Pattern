using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class WeddingDecorator : IWedding
    {
        IWedding wedding;

        protected string title = "undefined title";
        protected double budget = 0.0;
        public WeddingDecorator(IWedding wedding)
        {
            this.wedding = wedding;
        }
        public double Budget()
        {
            return wedding.Budget() + budget;
        }

        public string Title()
        {
            return string.Format("{0} with {1}", wedding.Title(), title);
        }
    }
}
