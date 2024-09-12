using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaNr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Witaj 3ct");
           // Console.WriteLine("Witaj 3ct");

           // Console.Write("witaj 3 tc" + Convert.ToChar(13) + Convert.ToChar(10));
            //Console.Write("hgfjgfhghfg" + Convert.ToChar(0));

            while (true)
            {
                Console.Write(DateTime.Now.ToString() + Convert.ToChar(13));
            }

            Console.ReadKey();
        }
    }
}
