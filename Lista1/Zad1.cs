using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{

    class Zad1
    {
        /// <summary>
        /// Metoda służąca do wyznaczania połowy obwodu trójkąta. 
        /// </summary>
        /// <param name="a">pierwszy bok trójkąta</param>
        /// <param name="b">drugi bok trójkąta</param>
        /// <param name="c">trzeci bok trójkąta</param>
        /// <returns>połowa obwodu trójkąta</returns>
        private double CalculateP(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        /// <summary>
        /// Metoda służąca do wyznaczania pola trójkąta na podstawie wzoru herona
        /// </summary>
        /// <param name="a">pierwszy bok trójkąta</param>
        /// <param name="b">drugi bok trójkąta</param>
        /// <param name="c">trzeci bok trójkąta</param>
        /// <returns>pole trójkąta o bokach a, b, c</returns>
        public double CalculateTriangleField(double a, double b, double c)
        {
            double p = CalculateP(a, b, c);
            return Math.Sqrt((p-a)*(p-b)*(p-c)*p);
        }
        /// <summary>
        /// Metoda sprawdzająca warunek konstrukcji trójkąta. 
        /// </summary>
        /// <param name="a">pierwszy bok trójkąta</param>
        /// <param name="b">drugi bok trójkąta</param>
        /// <param name="c">trzeci bok trójkąta</param>
        /// <returns>true jeżeli jest spełniony warunek konstrukcji trójkąta, w przeciwnym wypadku false</returns>
        public Boolean CheckValues(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && ((a + b) > c && (a + c) > b && (b + c) > a); //warunek konstrukcji trójkąta
        }
        
        static void Ext()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Podano za mało argumentów wejściowych");
                Ext();
            }
            Zad1 p = new Zad1();
            double a, b, c;
            try {
                a = Double.Parse(args[0]);
                b = Double.Parse(args[1]);
                c = Double.Parse(args[2]);
            } catch (Exception e)
            {
                Console.WriteLine("Podano nieprawidłowe wartości ");
                Ext();
                return;
            }
            if (!p.CheckValues(a, b, c))
            {
                Console.WriteLine("Z tych odcinków trójkąta nie zbudujesz...");
                Ext();
                return;
            }
            double heronField = p.CalculateTriangleField(a, b, c);
            Console.Write(String.Format("Pole trójkąta utworzonego z boków o długości {0}, {1}, {2} wynosi {3}", a, b, c, Math.Round(heronField, 3)));
            Console.Write("\n");
            Ext();
        }
    }
}
