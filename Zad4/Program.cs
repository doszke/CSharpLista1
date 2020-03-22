using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        /// <summary>
        /// Metoda wyświetlająca na standardowym wejściu tabliczkę mnożenia, o największym czynniku len
        /// </summary>
        /// <param name="len">najwyższy czynnik</param>
        internal static int[,] MulMat(int len)
        {
            int[,] matrix = new int[len + 1, len + 1];
            for (int i = 0; i <= len; i++)
            {
                for (int j = 0; j <= len; j++)
                {
                    matrix[i, j] = i * j;
                }
            }
            return FillBorders(matrix);
        }

        /// <summary>
        /// Metoda wyświetlająca na standardowym wejściu tabliczkę mnożenia
        /// </summary>
        /// <param name="matrix">tabliczka mnożenia, zapisana w tablicy dwuwymiarowej</param>
        private static void Visualize(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Metoda wypełniająca lewy i górny brzeg tablicy
        /// </summary>
        /// <param name="t">tabliczka mnożenia</param>
        /// <returns>tabliczka mnożenia z wypełnionym górnym i lewym brzegiem</returns>
        private static int[,] FillBorders(int[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                t[0, i] = i;
                t[i, 0] = i;
            }
            return t;
        }

        static void Ext()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            if (args.Length != 1)
            {
                Console.WriteLine("Podano niepoprawną liczbę argumentów");
                Ext();
            }
            int n;
            try
            {
                n = Int16.Parse(args[0]);
                if (n <= 0) throw new Exception("n musi być dodatnie");
            }
            catch (Exception e)
            {
                Console.WriteLine("Podano niepoprawne dane. Podana liczba musi być całkowita, większa od 0. ");
                Ext();
                return;
            }
            Visualize(MulMat(n));
            Ext();

        }
    }
}

