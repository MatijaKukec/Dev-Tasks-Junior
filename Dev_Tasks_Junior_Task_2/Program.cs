using System;

class Program
{
    static void Main()
    {
        int[] arr = {2,7,-5,4};
        int[] res = new int[arr.Length];
        for(int x = arr.Length-1; x>=0; x--){
            Console.WriteLine("{0} [{1}]", arr[x],x);
            Console.WriteLine("Pozicija nova: {0}", arr.Length-x-1);
            res[res.Length-x-1] = arr[x];
        }

        Console.WriteLine("Ovo je konačno polje s brojkama:");
        Console.WriteLine(string.Join(", ", res));
    }
}