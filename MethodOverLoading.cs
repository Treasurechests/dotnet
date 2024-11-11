using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_6_exp2
{
    class program
    {
        void display(string a, string b)
        {
            Console.WriteLine("String:" + a);
            Console.WriteLine("String:" + b);
        }
        void method(int a, int b)
        {
            Console.WriteLine("Num1:" + a);
            Console.WriteLine("Num2:" + b);
        }
        static void Main(String[] args)
        {
            program p1 = new program();
            p1.display("porsche", "benz");
            p1.method(100, 200);
            Console.ReadLine();
        }
    }
}