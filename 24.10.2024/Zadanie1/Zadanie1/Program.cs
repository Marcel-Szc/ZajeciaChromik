using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            przyklad();
            int dzielna2;
            Console.WriteLine("Podaj dzielną");
            string text = Console.ReadLine();
            bool error_status = false;

            for (int i = 0; i <text.Length; i++)
            {
                char c = text[i];
                //int intc = Convert.ToInt32(c);
                if (c < 48 || c > 57)
                {
                    error_status = true;
                }
            }
            DataTable tablica = new DataTable();
            tablica.Rows.Add("item");
            if (error_status == true)
            {
                Console.WriteLine("wpisałeś zły znak");
            } else
            {
                dzielna2=Convert.ToInt32(text);
            }

            if(int.TryParse(Console.ReadLine(), out int dzielna))
            {
                Console.WriteLine("Podaj dzielnik");
                int dzielnik = Convert.ToInt32(Console.ReadLine());

                if (dzielnik == 0)
                {
                    Console.WriteLine("Dzielnik nie może być zerem");
                }
                else
                {
                    Zapisz_wynik_dzielenia(dzielna, dzielnik);
                }
            };
            Console.ReadKey();
        }
        static void Zapisz_wynik_dzielenia(int a, int b)
        {
            Console.WriteLine("Wynik dzielenia = " + (a / b).ToString());
        }
        static void przyklad()
        {
            try
            {
                //Kod obsługiwany
                int a = 12;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Wynik dzielenia = " + c.ToString());

            }
            catch(ArgumentOutOfRangeException e) {
                Console.WriteLine("Indeks poza zakresem");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Nie można dzielic przez 0");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: " + e.ToString());
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Nareszcie");
            }
        }
    }
}
