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

void AverageValue(int[,] arrey)
{
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            sum = sum + arrey[i, j];
        }
        Console.Write($"{sum / arrey.GetLength(0)} ");
        Console.Write(";");
    }
}

int[,] matrixA = new int[4, 4];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
AverageValue(matrixA);