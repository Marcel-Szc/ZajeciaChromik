

//dodaj(5, 5);
//odejmij(5,5);

//Niejawny delegat

oblicz(5,5,dodaj);
oblicz(7,7,odejmij);
oblicz(7,7,mnozenie);
oblicz(7,7,dzielenie);

loguj("Brak dostępu do bazy danych.", logujDoPliku);
loguj("Brak dostępu do bazy danych.", logujSmsem);
void dodaj(int l1, int l2)
{
    Console.WriteLine(l1+l2);
}

void odejmij(int l1, int l2)
{
    Console.WriteLine(l1-l2);   
}

void mnozenie(int l1, int l2)
{
    Console.WriteLine(l1 * l2);
}

void dzielenie(int l1, int l2)
{
    Console.WriteLine(l1 / l2);
}

void oblicz(int l1, int l2, Action<int,int> operacja)
{
    operacja(l1,l2);
}

void logujDoPliku(string wiadomosc)
{
    Console.WriteLine($"Loguje do pliku wiadomosc {wiadomosc}");
}
void logujDoBazy(string wiadomosc)
{
    Console.WriteLine($"Loguje do bazy wiadomosc {wiadomosc}");
}
void logujSmsem(string wiadomosc)
{
    Console.WriteLine($"Loguje do smsem wiadomosc {wiadomosc}");
}

void loguj(string wiadomosc, Action<string> zaloguj)
{
    zaloguj(wiadomosc);
}