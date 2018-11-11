using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWedding wedding = new Jewellery(new Theme(new Orchestra(new DestinationWedding())));
            Console.WriteLine(wedding.Title());
            Console.WriteLine("Budget:" + wedding.Budget());
            Console.ReadLine();
        }
    }
}
