using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelConsonantProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a Character");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') 
            {
                Console.WriteLine("Character is Vowel");
            }
            else
            {
                Console.WriteLine("Character is Consonant");
            }
            Console.ReadLine();
        }
    }
}
