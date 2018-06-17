using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_repos
{
    class Class2
    {
        public double Mult(double a, double b)
        {
            double c;
            c = a * b;
            Console.WriteLine("Mult: " + c);
            return c;
        }
        public double Div(double a, double b)
        {
            double c;
            c = a / b;
            Console.WriteLine("Div: " + c);
            return c;
        }
    }
}
