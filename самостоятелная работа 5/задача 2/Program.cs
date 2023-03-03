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
    int index = 1;
    int variable = 0;
    while (index < length)
    {  
    variable = (variable + number[index] );    
    index = index + 2;
    }
    Console.WriteLine(" ");
    Console.WriteLine(variable);
}

int[] arrey = new int[4];
FillArray(arrey);
PrintArray(arrey);
CheckEvenness(arrey);