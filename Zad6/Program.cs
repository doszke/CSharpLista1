using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {

        /// <summary>
        /// Dozwolone ograniczniki danych
        /// </summary>
        private static readonly char[] DELIMITERS = {' ', '\t', '\n'};

        /// <summary>
        /// Metoda wczytująca dane z pliku
        /// </summary>
        /// <param name="path">ścieżka do pliku</param>
        /// <returns>kolekcja sparsowanych łańcuchów znaków</returns>
        public static HashSet<String> ReadMyFile(String path)
        {
            HashSet<String> otp = null;
            if (File.Exists(path))
            {
                String content = File.ReadAllText(path).ToLower();
                String[] parts = { };
                for(int i = 0; i < DELIMITERS.Length; i++)
                {
                    parts = content.Split(DELIMITERS[i]);
                    if (parts.Length > 1) break; //jeżeli trafi dobry delimiter, to przechodzi dalej
                }
                //jak nie wysplituje zgłoś wyjątek
                if (parts.Length <= 1) throw new FileLoadException("Niepoprawny separator");
                for (int i = 0; i < parts.Length; i++) parts[i] = parts[i].Trim(); //pozbywanie sie białych znaków
                otp = new HashSet<string>(parts);
            }
            else throw new IOException("Nie znaleziono pliku pod podaną ścieżką");
            return otp;
        }

        /// <summary>
        /// Metoda znajdująca i zwracająca wyrazy obecne w obu kolekcjach. Metoda również sortuje alfabetycznie duplikaty. 
        /// </summary>
        /// <param name="hs1">kolekcja łańcuchów znaków</param>
        /// <param name="hs2">kolekcja łańcuchów znaków</param>
        /// <returns>posortowana kolekcja duplikatów</returns>
        public static List<String> FindDuplicates(HashSet<String> hs1, HashSet<String> hs2)
        {
            List<String> otp = new List<String>();
            foreach(String word in hs1)
            {
                if (hs2.Contains(word)) otp.Add(word);
            }
            otp.Sort();
            return otp;
        }

        static void Ext()
        {
            Console.WriteLine("Naciśnij dowolny przycisk, aby zakończyć");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            HashSet<String> hs1, hs2;
            try
            {
                hs1 = ReadMyFile("C:\\Users\\Jakub Siembida\\source\\repos\\Lista1\\Zad6\\test1.txt");
                hs2 = ReadMyFile("C:\\Users\\Jakub Siembida\\source\\repos\\Lista1\\Zad6\\test3.txt");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Ext();
                return;
            }
            foreach (String s in hs1) Console.WriteLine(s);
            Console.WriteLine("\n");
            foreach (String s in hs2) Console.WriteLine(s);
            Console.WriteLine("\n");

            List<String> otp = FindDuplicates(hs1, hs2);
            foreach (String s in otp) Console.WriteLine(s);
            Ext();
        }
    }
}
