namespace Cwiczenia5
{
    internal class Mnozenie
    {
        public Mnozenie()
        {
            int x = Pomocnik.DostanLiczbe<int>("x: ", int.MaxValue, 1);
            int n = Pomocnik.DostanLiczbe<int>("n: ", int.MaxValue, 1);
            
            int rezultat = x;

            for (int i = 1; i < n; i++)
            {
                int liczbaMnozona = rezultat;

                for (int j = 1; j < x; j++)
                {
                    rezultat += liczbaMnozona;
                }
            }

            Console.WriteLine($"Wynik: {rezultat}");

        }
    }
}
