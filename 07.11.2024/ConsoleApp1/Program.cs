using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public DataTable tablica;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.inicjalizuj_tablice();
            program.utworz_strukture();
            program.zapisz_do_tablicy();
            //program.usun_z_tablicy();
            program.odczytaj_z_tablicy();
            program.select_z_tablicy();

            Console.ReadKey();
        }
        private void inicjalizuj_tablice()
        {
            tablica = new DataTable();
        }
        private void utworz_strukture()
        {
            DataColumn DataTime = new DataColumn("DataTime", typeof(string));
            DataColumn LogItem = new DataColumn("LogItem", typeof(string));

            tablica.Columns.Add(DataTime);
            tablica.Columns.Add(LogItem);
        }
        private void zapisz_do_tablicy()
        {
            int y = tablica.Rows.Count;

            string item = "Wpis do tablicy";
            DataRow dr;
            dr = tablica.NewRow();
            dr["DataTime"] = (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            dr["LogItem"] = item;
            tablica.Rows.Add(dr);
            tablica.AcceptChanges();

            y= tablica.Rows.Count;
        }
        private void usun_z_tablicy()
        {
            int y = tablica.Rows.Count;
            tablica.AcceptChanges();
            y = tablica.Rows.Count;
            // 1 sposób usunięcia danych
            int index =0;
            tablica.Rows.RemoveAt(index);
            if(tablica.Rows.Count > 0)
            {
                // 2 sposób usunięcia danych
                DataRow dr;
                dr = tablica.Rows[index];
                tablica.Rows.Remove(dr);
                // 3 sposób usunięcia danych
                tablica.Rows.Clear();
            }
        } private void odczytaj_z_tablicy()
        {
            Console.WriteLine(tablica.Rows[0]["DataTime"].ToString() + " "+ tablica.Rows[0]["LogItem"].ToString());
        }
        private void select_z_tablicy()
        {
            DataRow[] dr;
            dr = tablica.Select("LogItem='Wpis do tablicy'");
            Console.WriteLine(dr[0]["DataTime"].ToString());
        }
    }
}
