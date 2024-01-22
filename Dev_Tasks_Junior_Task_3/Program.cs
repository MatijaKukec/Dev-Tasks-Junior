using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "abcdzefazz";
        BrojiPonavljanja(str);
    }

    static void BrojiPonavljanja(string input)
    {
        Dictionary<char, int> ponavljanja = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (ponavljanja.ContainsKey(c))
            {
                ponavljanja[c]++;
            }
            else
            {
                ponavljanja[c] = 1;
            }
        }

        foreach (var x in ponavljanja)
        {
            if (x.Value > 1)
            {
                Console.WriteLine($"Karakter {x.Key} ima {x.Value} ponavljanja.");
            }
        }
    }
}
