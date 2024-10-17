using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {  
                    var ini = new plikConfig(@".\config.ini");
                    Console.WriteLine("1 - Utwórz parametr, 2 - Usuń parametr, 3 - Odczytaj parametr");
                    int wybor = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                    if (wybor == 1)
                    {
                        Console.WriteLine("Pobierz dane zgodnie ze strukturą: SEKCJA$PARAMTER%WARTOŚĆ");
                        string daneUtw = Console.ReadLine();
                        int pozycja = daneUtw.IndexOf("$");
                        int pozycja2 = daneUtw.IndexOf("%");
                        string wycinka = daneUtw.Substring(0, pozycja - 1); //sekcja
                        string wycinka2 = daneUtw.Substring(pozycja + 1 , pozycja2 - pozycja - 1);//parametr
                        string wycinka3 = daneUtw.Substring(pozycja2 + 1);//wartosc

                        ini.Write(wycinka2, wycinka3, wycinka);
                        break;
                    }
                    else if (wybor == 2)
                    {
                        Console.WriteLine("Pobierz dane zgodnie ze strukturą: SEKCJA$PARAMTER");
                        string daneUs = Console.ReadLine();
                        int pozycja = daneUs.IndexOf("$");
                        string wycinka = daneUs.Substring(0, pozycja);
                        string wycinka2 = daneUs.Substring(pozycja + 1);

                        ini.DeleteKey(wycinka2, wycinka);
                        break;
                    }
                    else if (wybor == 3)
                    {
                        Console.WriteLine("Pobierz dane zgodnie ze strukturą: SEKCJA$PARAMTER");
                        string daneCzyt = Console.ReadLine();
                        int pozycja = daneCzyt.IndexOf("$");
                        string wycinka = daneCzyt.Substring(0, pozycja);
                        string wycinka2 = daneCzyt.Substring(pozycja + 1);

                        string wys = ini.Read(wycinka2, wycinka);
                        Console.WriteLine(wys);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("3RR0R");
                        break;
                    }
                }
            }
        }
    }

    public class plikConfig
    {
        
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]

        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]

        static extern long GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size,
            string FilePath);

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public plikConfig(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);

        }
    }
}
