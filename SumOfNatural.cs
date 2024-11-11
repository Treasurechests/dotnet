using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_4_exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                s = s + i;
            }
            Console.WriteLine("Sum of numbers={0}", s);
            Console.ReadLine();
        }
    }
}