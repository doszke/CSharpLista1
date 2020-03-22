using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        /// <summary>
        /// Zestaw samogłosek
        /// </summary>
        private static readonly HashSet<Char> VOWELS = new HashSet<char>(new char[] {'a', 'e', 'y', 'u', 'i', 'o', 'ą', 'ę'});

        /// <summary>
        /// Metoda zliczająca ilośc wystąpień samogłosek w podanym ciągu znaków
        /// </summary>
        /// <param name="charSeq">łańcuch znaków</param>
        /// <returns>ilośc samogłosek w łańcuchu znaków</returns>
        public static int CountVowels(String charSeq)
        {
            int counter = 0;
            String input = charSeq.ToLower(); //String jest immutable, charSeq zostaje niezmienione
            foreach (char c in input)
            {
                if (VOWELS.Contains(c))
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Ext()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Write("Witaj w programie zliczającym samogłoski. Podaj tekst. ");
            String input = Console.ReadLine();
            Console.WriteLine(String.Format("W tekście: \"{0}\" znajduje się {1} samogłosek. ", input, CountVowels(input)));
            Ext();
        }
    }
}
