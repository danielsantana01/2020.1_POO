using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            double a = double.Parse(e[0]), b = double.Parse(e[1]), c = double.Parse(e[2]);
            Console.WriteLine($"TRIANGULO: {a*c/2:0.000}");
            Console.WriteLine($"CIRCULO: {3.14159*Math.Pow(c,2):0.000}");
            Console.WriteLine($"TRAPEZIO: {(a + b)*c/2:0.000}");
            Console.WriteLine($"QUADRADO: {Math.Pow(b,2):0.000}");
            Console.WriteLine($"RETANGULO: {a*b:0.000}");
        }
    }
}
