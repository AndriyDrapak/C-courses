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
            int b = Int32.Parse(Console.ReadLine());
            int c = (a + b) * 2;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
