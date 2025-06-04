using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    /*  public delegate double ObliczPole(double x, double y);

     class Program
     {
         static void Main(string[] args)
         {
             ObliczPole poleProstokąta = delegate (double x, double y)
             {
                 return x * y;
             };

             ObliczPole trojkat = delegate (double x, double y)
             {
                 return 0.5 * x * y;
             };
             // Z1
             Console.WriteLine("Pole prostokąta 3,4 (metoda anonimowa): " + poleProstokąta(3, 4));
             Console.WriteLine("Pole Trójkąta 3,4: " + trojkat(3,4));
             // Z2
             WyswietlWKonsoli(8.93);
             WyswietlWKonsoli("Stringi to ja mam na sobie");
             // Z3
             Console.WriteLine("Pole prostokąta 5,7 (funkcja generyczna): " + PoleProstokąta(5,7));
             Console.WriteLine("Pole prostokąta 5.5,7.7 (funkcja generyczna): " + PoleProstokąta(5.5, 7.7));
             // Z4
             Console.WriteLine("Potęga (int): " + ObliczPotege(2,3));
             Console.WriteLine("Potęga (double): " + ObliczPotege(2.3, 3.5));

         }
         static void WyswietlWKonsoli<T>(T wartosc)
         {
             Console.WriteLine("wartość: " + wartosc);
         }
         static T PoleProstokąta<T>(T x, T y) where T : struct, IConvertible
         {
             double a = Convert.ToDouble(x);
             double b = Convert.ToDouble(y);
             return (T)Convert.ChangeType(a * b, typeof(T));
         }
         static double ObliczPotege<T1, T2>(T1 podstawa, T2 wykładnik) where T1 : struct, IConvertible where T2 : struct, IConvertible
         {
             double a = Convert.ToDouble(podstawa);
             double b = Convert.ToDouble(wykładnik);
             return Math.Pow(a, b);
         }
     } */

    /*class Program
    {
        public delegate double Oblicz(double x, double y);
        static void Main(string[] args)
        {
            Oblicz obliczPierwiastek = delegate (double x, double y)
            {
                return Math.Pow(x, 1.0 / y);
            };
            Oblicz obliczPotęge = delegate (double x, double y)
            {
                return Math.Pow(x, y);
            };
            // Z1
            Console.WriteLine("Pierwiastek(metoda anonim): " + obliczPierwiastek(2.3, 5));
            Console.WriteLine("Potęga(metoda anonim): " + obliczPotęge(4, 5.5));
            // Z2
            Console.WriteLine("Pole trójkąta(funkcja generyczna): " + PoleTrojkąta(8.5,7));
            // Z3
            WypiszWKonsoli("Stringi to ja mam na sobie");
            WypiszWKonsoli(123456789);
        }

        static T PoleTrojkąta<T>(T x, T y) where T : struct, IConvertible
        { 
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return (T)Convert.ChangeType(0.5 * a * b, typeof(T));
        }

        static void WypiszWKonsoli<T>(T wartosc)
        {
            Console.WriteLine("wartosc: " + wartosc);
        }
    }*/
    class Program
    {
        public delegate double Obwód(double x, double y);
        public delegate int Oblicz(int x);
        static void Main(string[] args)
        {
            // Z1
            Obwód OProstokąta = delegate (double x, double y)
            {
                return x * 2 + y * 2;
            };
            Obwód OTrójkąta = delegate (double x, double y)
            {
                if ( x > y )
                {
                    return y * 2 + x;
                }
                else if( x < y ) 
                {
                    return x * 2 + y;
                }
                else
                {
                    return 3 * x;
                }
            };
            Console.WriteLine("Obwód prostokąta: "+ OProstokąta(2, 4));
            Console.WriteLine("Obwód trójkąta równoramiennego: " + OTrójkąta(2.4, 5));
            Console.WriteLine("Obwód trójkąta równoramiennego: " + OTrójkąta(5, 5));
            // Z2
            WyswietlTypParam(true);
            // Z3
            Console.WriteLine("Średnia dwóch liczb: " + ObliczSrednia(4.5, 4));
            // Z4
            Console.WriteLine("Logarytm: " + ObliczLogarytm(2.4,7));
            // Z5
            ZamienNaString(5666.44);
            // Z6
            Oblicz Silnia = delegate (int x)
            {
                int wynik = 1;
                for (int i = 1; i <= x; i++)
                {
                    wynik *= i;
                }
                return wynik;
            };
            Oblicz CiągnijSięFibonacci = delegate (int x)
            {
                if (x <= 1)
                {
                    return x;
                }

                int a = 0;
                int b = 1;
                for (int i = 2; i <= x; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            };
            Console.WriteLine("Silnia: " + Silnia(9));
            Console.WriteLine("Ciąg fibonacciego: " + CiągnijSięFibonacci(8));

        }
        static void WyswietlTypParam<T>(T typ)
        {
            Console.WriteLine(typeof(T));
        }
        static T ObliczSrednia<T>(T x, T y) where T : IConvertible
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            double srednia = a + b;
            return (T)Convert.ChangeType(srednia / 2,typeof(T));
        }
        static double ObliczLogarytm<T>(T podstawa, T wartosc) where T : IConvertible
        {
            double a = Convert.ToDouble(wartosc);
            double b = Convert.ToDouble(podstawa);
            return Math.Log(b) / Math.Log(a);
        }

        static void ZamienNaString<T>(T wartosc) where T : IConvertible
        {
            Console.WriteLine("Stringi: " + Convert.ToString(wartosc));
        }
    }
}