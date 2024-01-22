using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 6, 8, 1, 6 };

        while (true)
        {
            Console.WriteLine("Ovo je polje s brojkama:");
            Console.WriteLine(string.Join(", ", arr));

            int targetNumber = GetUserInputNumber("Da bi našli parove koje daju sumu određenog broja, upišite određeni broj:");

            Dictionary<int, int> pairs = PretragaParova(arr, targetNumber);

            Console.WriteLine("Pretraga...:");
            Console.WriteLine("Parovi su:");

            Prikaz(pairs);

            Console.Write("Prisnite bilo koju tipku za ponovo... ");
            Console.Write("<Escape> za izlazak... ");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                break;
            }

            Console.Clear(); // Clear console for better readability
        }
    }



    static int GetUserInputNumber(string prompt)
    {
        int result;
        while (true)
        {
            Console.WriteLine($"\n\n{prompt}");
            string input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Nije broj. Pokušajte ponovno.");
            }
        }
    }

    static Dictionary<int, int> PretragaParova(int[] array, int target)
    {
        Dictionary<int, int> pairs = new();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == target)
                {
                    pairs.TryAdd(array[i], array[j]);
                }
            }
        }

        return pairs;
    }

    static void Prikaz(Dictionary<int, int> pairs)
    {
        if (pairs.Any())
        {
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key} i {pair.Value}");
            }
        }
        else
        {
            Console.WriteLine("Nema parova koji daju traženu sumu.");
        }
    }
}
