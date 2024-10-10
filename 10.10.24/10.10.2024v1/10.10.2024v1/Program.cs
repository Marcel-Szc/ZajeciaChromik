using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace _10._10._2024v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lekcja programowania");

            var ini = new configFile(@".\config.ini");
            string wartosc_parametru;

            wartosc_parametru = ini.Read("ipAdress", "Drukarka");
            Console.WriteLine("adres Ip = "+ wartosc_parametru);

            wartosc_parametru = ini.Read("port", "Drukarka");
            Console.WriteLine("port = " + wartosc_parametru);

            string nazwa_drukarki;
            wartosc_parametru = ini.Read("nazwa_drukarki", "Drukarka");
            if(string.IsNullOrEmpty(wartosc_parametru))
            {
                nazwa_drukarki = "default_name";
                ini.Write("nazwa_rukarki", nazwa_drukarki, "Drukarka");
            } else if(!string.IsNullOrEmpty(wartosc_parametru))
            {
                nazwa_drukarki = wartosc_parametru;
            }

            Console.ReadLine();

        }
    }
    public class configFile
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

        public configFile(string IniPath=null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);

        }
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }
















    }