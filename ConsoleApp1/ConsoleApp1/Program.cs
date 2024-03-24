static int ZnajdzMaksimum(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica może być pusta.");
    }

    int maksimum = tablica[0];
    for (int i = 1; i < tablica.Length; i++)
    {
        if (tablica[i] > maksimum)
        {
            maksimum = tablica[i];
        }
    }

    return maksimum;
}