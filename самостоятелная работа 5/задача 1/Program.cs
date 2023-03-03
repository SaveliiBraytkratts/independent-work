void FillArray(int[] masiv)
{
    int length = masiv.Length;
    int index = 0;
    while (index < length)
    {
        masiv[index] = new Random().Next(100, 999);
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
    int index = 0;
    int variable = 0;
    while (index < length)
    {
        if (number[index] % 2 == 0)
        {
           variable = (variable + 1 );
        }
        index++;
    }
    Console.WriteLine(" ");
    Console.WriteLine(variable);
}

Console.Write("Введите Введите размер массива:");
int N = int.Parse(Console.ReadLine()!);
int[] arrey = new int[N];
FillArray(arrey);
PrintArray(arrey);
CheckEvenness(arrey);