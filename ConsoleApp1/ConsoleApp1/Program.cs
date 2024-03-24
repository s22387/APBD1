static int ZnajdzMaksimum(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica nie może być pusta.");
    }

    int maksimal = tablica[0];
    for (int i = 1; i < tablica.Length; i++)
    {
        if (tablica[i] > maksimal)
        {
            maksimal = tablica[i];
        }
    }

    return maksimal;
}