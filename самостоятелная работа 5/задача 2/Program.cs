void FillArray(int[] masiv)
{
    int length = masiv.Length;
    int index = 0;
    while (index < length)
    {
        masiv[index] = new Random().Next(10, 99);
        index++;
    }

}

void PrintArray(int[] mas)
{
    int length = mas.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(mas[index]);
        index++;
    }
}

void CheckEvenness(int[] number)
{
    int length = number.Length;
    int index = 1;
    int variable = 0;
    while (index < length)
    {
        variable = (variable + number[index]);
        index = index + 2;
    }
    Console.WriteLine(" ");
    Console.WriteLine(variable);
}

Console.Write("Введите размер массива:");
int N = int.Parse(Console.ReadLine()!);
int[] arrey = new int[N];
FillArray(arrey);
PrintArray(arrey);
CheckEvenness(arrey);