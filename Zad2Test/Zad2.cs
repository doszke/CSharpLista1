using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Zad2
    {
        
        /// <summary>
        /// Metoda generująca n wyrazów ciągu fibonacciego począwszy od zadanych wartości
        /// </summary>
        /// <param name="x">pierwszy wyraz</param>
        /// <param name="y">drugi wyraz</param>
        /// <param name="n">liczba wyrazów ciągu</param>
        /// <returns>tablica przechowująca sekwencję n liczb fibonacciego począwszy od wartości x i y</returns>
        public int[] Fibonacci(int x, int y, int n)
        {
            int[] table = new int[n];
            table[0] = x;
            table[1] = y;
            for (int i = 2; i < table.Length; i++)
            {
                table[i] = NextFibonacci(table[i - 1], table[i - 2]);
            }
            return table;
        }

        /// <summary>
        /// Metoda generująca kolejną liczbę fibonacciego na podstawie dwóch poprzednich
        /// </summary>
        /// <param name="x">obecna liczba fibonacciego</param>
        /// <param name="y">poprzednia liczba fibonacciego</param>
        /// <returns></returns>
        private int NextFibonacci(int x, int y)
        {
            return x + y;
        }

        static void Ext()
        {
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Zad2 zad2 = new Zad2();
            int a, b, n;
            try
            {
                a = Int16.Parse(args[0]);
                b = Int16.Parse(args[1]);
                n = Int16.Parse(args[2]);
                if (a < 0 || b < 0 || ((a == b && b == 0))) throw new Exception();
            } catch (Exception e)
            {
                Console.WriteLine("Podano dane, które nie są nieujemnymi liczbami całkowitmi");
                Ext();
                return;
            }

            if (n <= 2)
            {
                Console.WriteLine("Podano liczbę wyrazów mniejszą, lub równą 2");
                Ext();
                return;
            }

            int[] seq1 = zad2.Fibonacci(a, b, n);
            string seq = "";
            foreach(int nb in seq1)
            {
                seq += nb + ", ";
            }
            Console.WriteLine("Elementy wygenerowanego ciągu: {0}", seq);

            Ext();
            
        }
    }
}
