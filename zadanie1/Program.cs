using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string ciag;
             Console.WriteLine("Podaj ciag znakow dluzszy niz 9");
             ciag = Console.ReadLine();
             if (ciag.Length > 9)
             {
                 Console.WriteLine("Dobrze");
                 Random r = new Random();


                 int x = r.Next(ciag.Length);

                 string partof = ciag.Substring(x);




             }
             else
             {
                 Console.WriteLine("Za malo znakow");
             };

             Console.ReadKey();*/

            string ciag = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            string[] tablica_ciagow = { "napis1", "napis2", "napis3" };
            Console.WriteLine(tablica_ciagow[1]);
            //długosc ciągów
            int dl = ciag.Length;
            //dodawanie ciągów
            string c1 = "01245";
            string c2 = "0123";
            string c3 = c1 + c2;
            string c5 = c3 + c1[2];

            string c4 = String.Join(" ", tablica_ciagow);
            //wycinanie ze string
            string partof;
            partof = ciag.Substring(2, 5);
            //czy dany ciag zawiera
            bool czyzawiera = c1.Contains("2");
            //na której pozycji zawiera
            int pozycja = c1.IndexOf("2");
            // zamiana na duże litery
            string odczyt = "tak";
            string parametr = odczyt.ToUpper();
            //podział stringa
            string do_podzialu = "10.5 12.6 12.0 21.3 23.2";
            string[] temperatury = do_podzialu.Split(' ');
            //podmiana
            string zawiera_spacje = "A BC D EFG";
            string bez_spacji = zawiera_spacje.Replace(" ", "");
            //usuniecie fragmentu
            string do_obrobki = "ABCD0123EFG";
            string po_obrobce = do_obrobki.Remove(4,4);

            string po_obrobce2 = do_obrobki.Remove(do_obrobki.IndexOf(("0123"), 4)) ;





            Console.WriteLine("Podaj ciąg znaków dłuższy niż 12");
            string wejscie = Console.ReadLine();
            string haslo = "";
            while (wejscie.Length < 12)
            {
                Console.WriteLine("Podaj ciąg znaków ponownie ponownie");
                wejscie = Console.ReadLine();
            }
            if (wejscie.Length >= 12 )
            {
                Console.WriteLine("poprawne!");

                Random rand = new Random();

                int size = 16;
                
                for (int i = 0; i < size; i++)
                {
                    int x = rand.Next(wejscie.Length);

                    haslo = haslo + wejscie[x];
                    
                }
                Console.WriteLine(haslo);

                string cztery = haslo.Substring(1, 4);
                haslo = haslo + cztery;

                string ostateczne_haslo = haslo.Remove(0, 2);
                Console.WriteLine(ostateczne_haslo);

            }
            Console.ReadKey();
        } 
    }
}
