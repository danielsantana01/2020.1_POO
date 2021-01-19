using System;

namespace _1042 {
    class Program {
        static void Main(string[] args) {
            string[] e = Console.ReadLine().Split(' ');
            int[] n = new int[3];
            int[] m = new int[3];
            for(int i=0;i<3;i++) n[i] = m[i] = int.Parse(e[i]);
            Array.Sort(m);
            for(int i=0;i<3;i++) Console.WriteLine(m[i]);
            Console.WriteLine();
            for(int i=0;i<3;i++) Console.WriteLine(n[i]);
        }
    }
}
