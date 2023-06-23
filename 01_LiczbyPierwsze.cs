using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Cwiczenia5
{
    internal class LiczbyPierwsze
    {
        public LiczbyPierwsze()
        {
            int liczba = Pomocnik.DostanLiczbe<int>("Ile liczb pierwszych podac: ", int.MaxValue, int.MinValue);
            int iloscPierwszych = 0;
            int liczbaSzukana = 0;
            while(iloscPierwszych < liczba)
            {
                if (CzyLiczbaJestPierwsza(liczbaSzukana))
                {
                    iloscPierwszych++;
                    Console.WriteLine(liczbaSzukana);
                }
                liczbaSzukana++;
            }
        }

        public bool CzyLiczbaJestPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
