using Cwiczenia5;

List<Type> zadania = new List<Type> { typeof(LiczbyPierwsze), typeof(_1_Losowanie), typeof(_2_Losowanie),typeof(Trojkat), typeof(Romb), typeof(Mnozenie)};

Type? zadanieWybrane = null;
do
{
    Console.WriteLine("Wybierz zadanie wpisujac numer i klikajac enter:");
    foreach (Type zadanie in zadania)
    {
        Console.WriteLine($"{zadania.IndexOf(zadanie)} - {zadanie.Name}");
    }
    string? input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
    {
        zadanieWybrane = zadania.ElementAtOrDefault(result);
    }
} while (zadanieWybrane == null);

Activator.CreateInstance(zadanieWybrane);

