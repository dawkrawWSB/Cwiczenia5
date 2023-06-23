using System.Numerics;

namespace Cwiczenia5
{
    internal class Pomocnik
    {
        public static T DostanLiczbe<T>(string tekst, T limitGorny, T limitDolny, int maksymalnaLiczbaProb = int.MaxValue) where T : INumber<T>, IMinMaxValue<T>
        {
            T result;
            int liczbaProb = 0;
            string? input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
                liczbaProb++;
            } while ((!T.TryParse(input, null, out result) || (result >= limitGorny || result <= limitDolny)) && liczbaProb < maksymalnaLiczbaProb);
            if(liczbaProb > maksymalnaLiczbaProb)
            {
                return default;
            }
            return result;
        }
    }
}

