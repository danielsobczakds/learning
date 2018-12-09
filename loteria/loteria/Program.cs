using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imie: \n");
            string Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: \n");
            string Nazwisko = Console.ReadLine();

            Console.Write("Podaj wiek: \n");
            int Wiek = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj miasto, w ktorym mieszkasz: \n");
            string Miasto = Console.ReadLine();

            Console.Write("Podaj numer telefonu: \n");
            long Telefon = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj numer PESEL: \n");
            long Pesel = Convert.ToInt32(Console.ReadLine());

            Console.Write("Twoje dane osobowe: {0} {1}, lat {2}, zamieszkaly w miescie {3}, " +
                "Numer telefonu: {4}, Numer PESEL: {5} \n", Imie, Nazwisko, Wiek, Miasto, Telefon, Pesel);

            if (Wiek >= 18)
            {
                Console.Write("Jestes dorosly \n");
            }
            String[] strings = { Imie };
            foreach (var value in strings)
            {
                bool OstatniaLitera = value.EndsWith("a");
                if (OstatniaLitera == true)
                    if (Wiek >= 18)
                        if (Miasto == "Warszawa")
                {
                    Console.WriteLine("Wygrales na loterii!");
                }
                    }

            Thread.Sleep(50000);
        }
    }
}
