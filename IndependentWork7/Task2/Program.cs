void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] matrixA = new int[4, 4];

void Coordinates(int position1, int position2)
{
    if (position1 < matrixA.GetLength(0) && position2 < matrixA.GetLength(1))
    {
        Console.WriteLine(matrixA[position1, position2]);
    }
    else
    {
        Console.WriteLine($"{position1};{position2} -> такого числа в массиве нет");
    }
}

FillArray(matrixA);
PrintArray(matrixA);
Console.Write("Введите строку:");
int pos1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец:");
int pos2 = int.Parse(Console.ReadLine()!);
Coordinates(pos1, pos2);