// See https://aka.ms/new-console-template for more information

double ObliczSrednia(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica może być pusta.");
    }

    int suma = 0;
    foreach (int liczba in tablica)
    {
        suma += liczba;
    }

    double srednia = (double)suma / tablica.Length;
    return srednia;
}