namespace Cwiczenia5
{
    internal class _1_Losowanie
    {
        public _1_Losowanie()
        {
            int ileLosowan = 0;
            int liczbyParzyste = 10;
            for (int i = 0; i < liczbyParzyste; i++)
            {
                int rezultatLosowania;
                do
                {
                    rezultatLosowania = Random.Shared.Next(-8, 9);
                    ileLosowan++;
                } while (rezultatLosowania % 2 != 0);

                Console.WriteLine($"{rezultatLosowania}");
            }
            Console.WriteLine($"Liczba wykonanych losowań: {ileLosowan}");
        }
    }
}
