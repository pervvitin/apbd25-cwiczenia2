// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MODYFIKACJA 1");
Console.WriteLine("MODYFIKACJA 2");
Console.WriteLine("MODYFIKACJA 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
 foreach (var liczba in numbers)
    {
        sum += liczba;
    }

    return (double) sum / numbers.Length;
}

int[] numbers = {1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);