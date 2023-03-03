void FillArray(double[] masiv)
{
    Random rand = new Random();
    for (int i = 0; i < masiv.Length; i++)
        masiv[i] = rand.Next(0, 100); //+ rand.NextDouble();
}
void PrintArray(double[] mas)
{
    int length = mas.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(mas[index]);
        index++;
    }
}
void Difference(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length;)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
        i++;
    }
    Console.WriteLine($"Минимальное значение:{min}");
    Console.WriteLine($"Максимальное значение:{max}");
    double difference = max - min;
    Console.WriteLine($"Разница между самым большим и самым маленьким значением:{difference}");
}


Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
FillArray(array);
PrintArray(array);
Difference(array);