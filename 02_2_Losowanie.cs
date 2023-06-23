namespace Cwiczenia5
{
    internal class _2_Losowanie
    {
        public _2_Losowanie()
        {
            int ileLosowan = 0;
            int liczbyParzyste = 10;
            for (int i = 0; i < liczbyParzyste; i++)
            {
                int rezultatLosowania = Random.Shared.Next(-4, 5) * 2;
                ileLosowan++;

                Console.WriteLine($"{rezultatLosowania}");
            }
            Console.WriteLine($"Liczba wykonanych losowań: {ileLosowan}");
        }
    }
}
