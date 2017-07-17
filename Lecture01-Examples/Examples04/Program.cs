using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            float y = (0.1f / 0.2f) * (a + b);
            Console.WriteLine(a + b == c);
            Console.WriteLine(y);
        }
    }
}