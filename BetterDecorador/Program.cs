using System;
using System.Security.Cryptography.X509Certificates;

namespace BetterDecorador
{
    /// <summary>
    /// Class that contains the several methods
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Calls the Decor method with the arguments passed in the command line
        /// </summary>
        /// <param name="args">Arguments received from the command line</param>
        /// <returns></returns>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                char symbol = char.Parse(args[1]);
                int times = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], symbol, times));
            }
        }  
        /// <summary>
        /// Utilizes arguments to create a string with a character dec times num
        ///  on each side of a string s
        /// </summary>
        /// <param name="s">A string received from the arguments in the command 
        /// line</param>
        /// <param name="dec">A char received from the arguments in the command 
        /// line</param>
        /// <param name="num">An int received from the arguments in the command 
        /// line</param>
        /// <returns>a string composed by a character dec times num on each side 
        /// of a string s</returns>
        private static string Decor(string s, char dec, int num)
        {
            
            string a = new string(dec, num);

            return $"{a} {s} {a}";
        } 
        /// <summary>
        /// Utilizes the decor method to print a string that lets the user know 
        /// they didn't specify any arguments
        /// </summary>
        /// <returns>a string that tells the user they didn't specify any 
        /// arguments, a character to put on either side of the string, and a 
        /// number of times the character will be printed</returns>
        private static string Decor()
        {
           return Decor("User did not specify args!", '=', 3);
        }
    }
}
