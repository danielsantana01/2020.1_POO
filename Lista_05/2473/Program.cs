using System;

namespace POO {
    class Program {
        static void Main(string[] args) {
            string[] flavinho = Console.ReadLine().Split();
            string[] sorted = Console.ReadLine().Split();
            int acertos = 0;
            for (int n = 0; n <= 5; n++)
            {
                if (Equals(flavinho[n], sorted[0]) || Equals(flavinho[n], sorted[1]) || Equals(flavinho[n], sorted[2]) || Equals(flavinho[n], sorted[3]) || Equals(flavinho[n], sorted[4]) || Equals(flavinho[n], sorted[5])) acertos += 1;
            }
            if (acertos == 3) Console.WriteLine("terno");
            else if (acertos == 4) Console.WriteLine("quadra");
            else if (acertos == 5) Console.WriteLine("quina");
            else if (acertos == 6) Console.WriteLine("sena");
            else Console.WriteLine("azar");
        }
    }
}
