using System;
using System.Security.Cryptography.X509Certificates;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char symbol = char.Parse(args[1]);
            int times = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], symbol, times));
        }  
        private static string Decor(string s, char dec, int num)
        {
            
            string a = new string(dec, num);

            return $"{a} {s} {a}";
        } 
    }
}
