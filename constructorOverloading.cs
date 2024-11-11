using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_5_exp2
{
    class car
    {
        public car(string brand)
        {
            Console.WriteLine("brand: " + brand);
        }
        public car(int price)
        {
            Console.WriteLine("price:" + price);
        }
        static void Main(string[] args)
        {
            car C1 = new car("porsche");
            Console.WriteLine();
            car c2 = new car(3000000);
            Console.ReadLine();
        }
    }
}