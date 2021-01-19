using System;
namespace POO {
    class Program {
        static void Main(string[] args) {
            string[] e = Console.ReadLine().Split(' ');
            int[] n = new int[5];
            for(int i = 0; i < 5; i++) n[i] = int.Parse(e[i]);
            int a = 0, b = 0;
            bool C = true, D = true;
            for(int i = 0; i < 4; i++){
                a = n[i];
                b = n[i + 1];
                if(C && b < a) C = false;
                if(D && b > a) D = false;
                if(!(D) && !(C)) break;
            }
            if(C) Console.WriteLine("C");
            else if(D) Console.WriteLine("D");
            else Console.WriteLine("N");
        }
    }
}
