using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            Console.WriteLine(GetSpecial(num));
        }
        
        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
