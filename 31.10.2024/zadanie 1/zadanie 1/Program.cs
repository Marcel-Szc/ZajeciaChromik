using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Zapisz_do_pliku("3TC - 2024/25");
            program.Zapisz_do_pliku_using("4TC - 2025/26");
            string linia = program.Odczytaj_z_pliku();
            Console.WriteLine(linia);
            Console.ReadKey();
        }
        private void Zapisz_do_pliku(string text)
        {
            string path = @".\plik.txt";
            StreamWriter zapisz = new StreamWriter(path, true);
            try
            {
                zapisz.WriteLine(text);
            } catch(Exception)
            {

            }
            finally
            {
                zapisz.Close();
            }
        }
        private void Zapisz_do_pliku_using(string text)
        {
            string path = @".\plik2.txt";
            using(StreamWriter zapisz = new StreamWriter(path, true)){
                zapisz.WriteLine(text);
            }
        }
        private string Odczytaj_z_pliku()
        {
            string text = "";

            using(StreamReader odczytaj = new StreamReader(@".\plik2.txt"))
            {
                text = odczytaj.ReadLine();
                return text;
            }
        }
    }
}
