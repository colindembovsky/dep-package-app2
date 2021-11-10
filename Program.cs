using System;
using superlib1;

namespace dep_package_app1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var calc = new Class1();
            var res = calc.Add(1, 2);
            Console.WriteLine($"Result of 1 + 2 is {res}");
        }
    }
}
