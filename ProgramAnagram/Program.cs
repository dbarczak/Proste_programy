void czyJestAnagramem(string slowo, string slowo2)
{
    slowo = slowo.ToLower();
    slowo2 = slowo2.ToLower();
    if (slowo.Count() != slowo2.Count())
    {
        Console.WriteLine("Slowo nie jest anagramem");
        return;
    }
    char[] slowoSorted = slowo.OrderBy(c => c).ToArray();
    Console.WriteLine(slowoSorted);
    char[] slowo2Sorted = slowo2.OrderBy(d => d).ToArray();
    Console.WriteLine(slowo2Sorted);
    for (int i = 0; i < slowo.Length; i++)
    {
        if (slowoSorted[i] != slowo2Sorted[i])
        {
            Console.WriteLine("Slowo nie jest anagramem");
            return;
        }

    }
    Console.WriteLine("Slowo jest anagramem");
}

string slowo;
string slowo2;
Console.WriteLine("Podaj słowo pierwsze");
slowo = Console.ReadLine();
Console.WriteLine("Podaj słowo drugie");
slowo2 = Console.ReadLine();
czyJestAnagramem(slowo, slowo2);
