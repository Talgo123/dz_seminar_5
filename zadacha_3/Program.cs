// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.NextDouble() *  (rightRange - leftRange) + leftRange; // от минуса 9 до 10 (10 не включается)
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

double FindDifference(double[] arr)
{
    double max = 0;
    double min = arr[0];
    int i = 0;
    int count = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    for (count = 0; count < arr.Length; count++)
    {
        if (arr[count] < min)
        {
            min = arr[count];
        }
    }
    double diff = max - min;
    return diff;
}

Console.WriteLine("введите размер массива; ");
int size = int.Parse(Console.ReadLine());
int leftRange = 1;
int rightRange = 1000;

double[] array = new double[size];
array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');

double result = FindDifference(array);
Console.WriteLine(result);
