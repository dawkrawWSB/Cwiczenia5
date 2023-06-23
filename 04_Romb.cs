using System.Text;

namespace Cwiczenia5
{
    internal class Romb
    {
        public Romb()
        {
            char[] tablicaKrawedzi = { '#', '@', '|', '*' };
            char[] tablicaWypelniaczy = { '.', ':', '-', '+'};
            int liczbaProb = 0;
            int wysokosc;
            string? input;
            do
            {
                Console.WriteLine("Liczba: ");
                input = Console.ReadLine();
                liczbaProb++;
            } while (!int.TryParse(input, null, out wysokosc) && wysokosc >=3 && wysokosc % 2 ==1 && liczbaProb < 3);
            if(liczbaProb >= 3)
            {
                return;
            }
            char znakKrawedzi = tablicaKrawedzi[Random.Shared.Next(tablicaKrawedzi.Length)];
            char znakWypelniaczy = tablicaWypelniaczy[Random.Shared.Next(tablicaWypelniaczy.Length)];
            int iloscSpacji = wysokosc / 2;
            int wypelniacze = 1;
            for (int i = 1; i <= wysokosc; i++)
            {
                StringBuilder wiersz = new StringBuilder();
                for (int j = 0; j < iloscSpacji; j++)
                {
                    wiersz.Append("  ");
                }

                for (int j = 0; j < wypelniacze; j++)
                {
                    wiersz.Append(" " + ((j == 0 || j == wypelniacze - 1) ? znakKrawedzi : znakWypelniaczy));
                }

                if (i <= wysokosc / 2)
                {
                    iloscSpacji--;
                    wypelniacze += 2;
                }
                else
                {
                    iloscSpacji++;
                    wypelniacze -= 2;
                }
                Console.WriteLine(wiersz.ToString());
            }
        }
    }
}
