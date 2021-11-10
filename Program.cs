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
            var res = calc.Add(10, 12);
            Console.WriteLine($"Result of 10 + 12 is {res}");
        }
    }
}
