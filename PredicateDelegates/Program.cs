
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delwgates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Predicate<char> vowels = new Predicate<char>(CheckVowels);
            Predicatefun(vowels);

            Console.ReadLine();
        }
        static void Predicatefun(Predicate<char> Letter)
        {
            Console.WriteLine(Letter('a'));
            Console.WriteLine(Letter('b'));
            Console.WriteLine(Letter('c'));
            Console.WriteLine(Letter('d'));
            Console.WriteLine(Letter('e'));
            Console.WriteLine(Letter('f'));
            Console.WriteLine(Letter('o'));
        }

        static bool CheckVowels(char value)
        {
            bool ISvowel = false;
            switch (char.ToUpper(value))
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    ISvowel = true;
                    break;
                default:
                    break;
            }

            if (ISvowel)
            {
                return true;
            }
            return false;
        }
    }
}
