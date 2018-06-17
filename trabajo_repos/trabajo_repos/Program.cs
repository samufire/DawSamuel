using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_repos
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();

            c2.Mul(10, 5);
            c2.Div(5, 2);

            c1.Suma(3, 4);
            c1.Resta(5, 2);

            Console.ReadKey();

        }
    }
}
