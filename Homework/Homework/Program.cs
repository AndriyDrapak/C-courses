using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());
            int e = Int32.Parse(Console.ReadLine());
            int f = a + b + c + d + e;
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
