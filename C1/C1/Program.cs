using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());
            double b = n * (a * (a * 0.04));
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
