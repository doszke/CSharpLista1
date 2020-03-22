using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    
    /// <summary>
    /// Klasa opisująca matematyczną definicję ciagu geometrycznego
    /// </summary>
    class Geometric
    {
        /// <summary>
        /// pierwszy wyraz ciągu
        /// </summary>
        private double a1;

        /// <summary>
        /// iloraz wyrazu obecnego i wyrazu poprzednego
        /// </summary>
        private double q;

        /// <summary>
        /// Konstruktor tworzący obiekt
        /// </summary>
        /// <param name="a1">pierwszy wyraz ciągu</param>
        /// <param name="q">iloraz wyrazu obecnego i wyrazu poprzednego</param>
        public Geometric(double a1, double q)
        {
            this.a1 = a1;
            this.q = q;
        }

        /// <summary>
        /// Metoda ustawiająca pierwszy wyraz ciagu
        /// </summary>
        /// <param name="a1">pierwszy wraz ciagu</param>
        public void SetA1(double a1)
        {
            this.a1 = a1;
        }

        /// <summary>
        /// Metoda ustawiająca iloraz ciągu
        /// </summary>
        /// <param name="q">iloraz ciągu</param>
        public void SetQ(double q)
        {
            this.q = q;
        }

        /// <summary>
        /// Metoda pobierająca pierwszy wyraz ciągu
        /// </summary>
        /// <returns>pierwszy wyraz ciągu</returns>
        public double GetA1()
        {
            return a1;
        }

        /// <summary>
        /// Metoda pobierająca iloraz ciągu
        /// </summary>
        /// <returns>iloraz ciagu</returns>
        public double GetQ()
        {
            return q;
        }

        /// <summary>
        /// Metoda generująca sekwencję ciągu geometrycznego począwszy od pierwszego wyrazu, o zadanej długości
        /// </summary>
        /// <param name="bound">długość sekwencji</param>
        /// <returns>listę tablicową zawierającą sekwencję ciągu geometrycznego o zadanej długosci</returns>
        public List<Double> GetGeoSequence(int bound)
        {
            List<Double> output = new List<double>();
            double temp = a1;
            output.Add(temp);
            while (output.Count < bound)
            {
                temp *= q;
                output.Add(temp);
            }
            return output;
        }

        static void Ext()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        /// <summary>
        /// Metoda statyczna służąca do generowania elementów ciągu geometrycznego o zadanym pierwszym wyrazie, ilorazie i długości sekwencji.
        /// </summary>
        /// <param name="a1">pierwszy wyraz ciagu</param>
        /// <param name="q">iloraz</param>
        /// <param name="bound">ilość wyrazów w sekwencji ciagu</param>
        /// <returns>lista tablicowa zawierająca elementy ciągu geometrycznego</returns>
        internal static List<Double> GetGeoSequence(double a1, double q, int bound)
        {
            return new Geometric(a1, q).GetGeoSequence(bound);
        }

        static void Main(string[] args)
        {
            /*
            double a1, q;
            int n;
            if (args.Length != 3)
            {
                Console.WriteLine("Podano za mało argumentów wejściowych");
                Ext();
            }
            try
            {
                a1 = Double.Parse(args[0]);
                q = Double.Parse(args[1]);
                n = Int32.Parse(args[2]);
            } catch (Exception e)
            {
                Console.WriteLine("Podano nieprawidłowe dane");
                Ext();
            }
            //w poleceniu było użyć na przykładach, tutaj w razie czego parsowanie z args'ów
             */

            String template = "{0} wyrazów ciągu geometrycznego o parametrach a1={1}, q={2}";

            List<Double> list = GetGeoSequence(1, 0.5, 10);
            Console.WriteLine(String.Format(template, 10, 1, 0.5));
            list.ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine();
            list = GetGeoSequence(1, 0.1, 5);
            Console.WriteLine(String.Format(template, 5, 1, 0.1));
            list.ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine();
            list = GetGeoSequence(10, 2, 3);
            Console.WriteLine(String.Format(template, 3, 10, 2));
            list.ForEach(i => Console.WriteLine(i.ToString()));
            Ext();
        }
    }
}
