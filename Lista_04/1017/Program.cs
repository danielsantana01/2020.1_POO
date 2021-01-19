using System;

namespace _1017 {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a*b/12:0.000}");
        }
    }
}
