using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_5_exp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            program1.displaycollege();
            program2.displayBranch();
            program3.displaySection();
            Console.ReadLine();
        }
    }
    class program1
    {
        public static void displaycollege()
        {
            Console.WriteLine("This is VVIT");
        }
    }
    class program2
    {
        public static void displayBranch()
        {
            Console.WriteLine("This is CSE");
        }
    }
    class program3
    {
        public static void displaySection()
        {
            Console.WriteLine("This is CSE-B section");
        }
    }

}
