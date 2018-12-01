using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    public class Example
    {
        public static void Main()
        {
            Console.Write("Podaj liczbe: ");
            long intTemp1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Podaj liczbe: ");
            int intTemp2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podales liczby {0} i {1}\n", intTemp1, intTemp2);
            if (intTemp1 > 2)
            {
                Console.Write("\tPierwsza liczba jest wieksza od 2");
            }
            else if (intTemp1 == 2)
            {
                Console.Write("\tPierwsza liczba jest rowna 2");
            }
            else
            {
                Console.Write("\tPierwsza liczba jest mniejsza od 2");
            }
            Thread.Sleep(3000);
            /*
             * Uzytkownik podaje dane osobowe: imie, nazwisko, wiek, miasto, nr telefonu, pesel. Wyswietlic jego dane w tej kolejnosci, 
             * jesli jest dorosly ma wyswietlic 'jestes dorosly', sprawdzasz czy jest kobieta (klasa string-jak znalezc ostatnia litere) i czy jest z warszawy
             * jesli spelnia wszystkie trzy warunki, mam napisac 'wygralas na loterii
            */










            /*
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
            Thread.Sleep(5000);
            */
        }
    }
    // The example displays output similar to the following:
    //       Hello World!
    //       Enter your name: James
    //       Good day, James!
}
