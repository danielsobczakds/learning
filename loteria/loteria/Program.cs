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
            string warunek;
            do
            {
                Console.Write("Podaj imie: \n");
                string imie = Console.ReadLine();

                Console.Write("Podaj nazwisko: \n");
                string nazwisko = Console.ReadLine();

                Console.Write("Podaj wiek: \n");
                int wiek = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj miasto, w ktorym mieszkasz: \n");

                string miasto;
                do
                {
                    miasto = Console.ReadLine();

                } while (!(miasto == "Warszawa" || miasto == "Szczecin" || miasto == "Bytom"));

                Console.Write("Podaj numer telefonu: \n");
                string telefon = Console.ReadLine();
                while (telefon.Length != 9)
                {
                    Console.Write("Podales zly numer. Podaj jeszcze raz\n");
                    telefon = Console.ReadLine();
                }


                Console.Write("Podaj numer pesel: \n");
                long pesel = Convert.ToInt64(Console.ReadLine());

                Console.Write("Twoje dane osobowe: {0} {1}, lat {2}, zamieszkaly w miescie {3}, " +
                    "Numer telefonu: {4}, Numer pesel: {5} \n", imie, nazwisko, wiek, miasto, telefon, pesel);

                if (wiek >= 18)
                {
                    Console.Write("Jestes dorosly \n");
                }
                String[] strings = { imie };
                foreach (var value in strings)
                {
                    bool OstatniaLitera = value.EndsWith("a");
                    if (OstatniaLitera == true)
                        if (wiek >= 18)
                            if (miasto == "Warszawa") 
                            {
                                Console.WriteLine("Wygrales na loterii!");
                            }
                }

                Console.Write("Czy chcesz kontynuowac? (t\\n) ");
                warunek = Console.ReadKey().KeyChar.ToString(); //consolekeyinfo to char to string
                Console.WriteLine();
                //Console.Write(warunek + "\n"); //konkatenacja
            } while (warunek != "n");
        }
    }
}
/* 
 * Uzytkownik podaje dwie liczby. Nastepnie wybiera czy ma byc pionowo czy poziomo, a program rysuje prostokat z podanych wartosci w odpowiednia strone. prostokat ma byc wykonany z "#"
 * w pionie nie moze byc > 6 a w poziomie > 8 
 * 2. prostokat ma byc pusty w srodku (w srodku maja byc spacje). uzytkownik wybiera czy ma byc pusty czy wypelniony #
 * 
 */
