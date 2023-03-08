void FillArray(int[,] matr)// метод для заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - возвращает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - возвращает кол-во столбцов
        {
            matr[i, j] = new Random().Next(1, 10);// [1,10)- полуинтервал,т.е. 10- не войдет
        }
    }
}

void PrintArray(int[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintGrowth(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            int max = 0;
            int k = j;
            while (k < matr.GetLength(1))
            {
                if (max < matr[i, k])
                {
                    max = matr[i, k];
                    matr[i, k] = matr[i, j];
                    matr[i, j] = max;
                }
                k++;
            } 
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = new int[3, 4];

FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
PrintGrowth(matrixA);