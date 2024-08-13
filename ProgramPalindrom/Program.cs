using System.Collections.Specialized;

void czyJestPalindromem(string slowo)
{
    slowo = slowo.ToLower();
    string slowo2 = slowo;
    char litera1, litera2;
    for (int i = 0; i < slowo2.Length; i++)
    {
        litera1 = slowo[i];
        litera2 = slowo[slowo.Length - i - 1];
        if(litera1 != litera2)
        {
            Console.WriteLine("Slowo nie jest palindromem");
            return;
        }
    }
    Console.WriteLine("Slowo jest palindromem");
}

string slowo;
Console.WriteLine("Podaj słowo");
slowo = Console.ReadLine();
czyJestPalindromem(slowo);

