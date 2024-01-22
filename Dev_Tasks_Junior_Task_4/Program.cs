
class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 4, -7, 9, 11 };
        int result = TražiSrednjuVrijednost(arr);

        Console.WriteLine($"Element najbliže srednjoj vrijednosti je : {result}");
    }

    static int TražiSrednjuVrijednost(int[] array)
    {
        int n = array.Length;

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        
        double aritmSred =  (double)sum / array.Length;

        int element = array[0];
        double minRaz = Math.Abs(array[0] - aritmSred);

        for (int i = 1; i < n; i++)
        {
            double razlika = Math.Abs(array[i] - aritmSred);

            if (razlika < minRaz || (razlika == minRaz && array[i] < element))
            {
                element = array[i];
                minRaz = razlika;
            }
        }

        return element;
    }

}
