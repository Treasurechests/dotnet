using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_6_exp1
{
    public class exp_simple
    {
        static exp_simple()
        {
            Console.WriteLine("Static");
        }
        private exp_simple()
        {
            Console.WriteLine("Private");
        }
        public static void rresult()
        {
            exp_simple es = new exp_simple();
            exp_simple es1 = new exp_simple();
        }
        static void Main(string[] args)
        {
            exp_simple.rresult();
        }

    }
}