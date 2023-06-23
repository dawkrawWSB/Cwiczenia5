using System.Text;

namespace Cwiczenia5
{
    internal class Trojkat
    {
        public Trojkat()
        {
            int wysokosc = Pomocnik.DostanLiczbe<int>("Wysokosc trojkata: ", int.MaxValue, int.MinValue);
            int szerokosc = 2 * wysokosc - 1;
            for(int i = 1; i <= wysokosc; i++)
            {
                StringBuilder wiersz = new StringBuilder();
                int iloscPlusow = 2 * i - 1;
                int iloscSpacji = (szerokosc - iloscPlusow) / 2;
                for (int j = 0; j < iloscSpacji; j++)
                {
                    wiersz.Append("  ");
                }
                for (int j = 0;j < iloscPlusow; j++) { wiersz.Append(" +"); }
                Console.WriteLine(wiersz.ToString());
            }
        }
    }
}
