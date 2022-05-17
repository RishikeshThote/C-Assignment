using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int operation(int a, int b);
    class Program
    {

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }

        static int multiplication(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            operation AddObj = new operation(Program.Addition);
            operation SubObj = new operation(Program.subtract);
            operation MulObj = new operation(Program.multiplication);
            Console.WriteLine("Addition is={0}", AddObj(56, 54));
            Console.WriteLine("Subtraction is={0}", SubObj(87, 77));
            Console.WriteLine("Mutliplication is={0}", MulObj(93, 34));
            Console.ReadLine();
        }
    }
}


