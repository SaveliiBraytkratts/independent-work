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
        if (number[index] % 2 == 1)
        {
           variable = (variable + 1 );
        }
        index++;
    }
    Console.WriteLine(variable);
}

int[] arrey = new int[4];
FillArray(arrey);
PrintArray(arrey);
CheckEvenness(arrey);