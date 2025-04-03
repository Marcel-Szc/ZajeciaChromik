
Console.WriteLine(SilniaIt(5));
Console.WriteLine(SilniaRe(5));
double SilniaIt(long n)
{
    long wynik = 1;
    for(int i =1; i<=n;i++)
    {
        wynik = wynik * i;

    }
    return wynik;
}

double SilniaRe(long n)
{
    if(n == 0)
        return 1;

    return n * SilniaRe(n - 1);
}
/** Dla SilniaRe(3)
 * 
 * Wywołanie: SilniaRe(3)--> n=3
 * czy n==0? --> NIE
 *  return SilniaRe(2)--> n==2
 *   czy n==0? --> NIE
 *    return SilniaRe(1)--> n==1
 *     czy n==0? --> NIE
 *      return SilniaRe(0)--> n==0
 *       czy n==0? --> TAK
 *        return 1
 *       return 1*1 --> 1
 *      return 2*1 --> 2
 *     return 3*2 --> 6
 *    return 6