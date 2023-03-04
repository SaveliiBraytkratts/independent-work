void FillArray(double[,] matr)// метод для заполнения матрицы случайными числами
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - возвращает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - возвращает кол-во столбцов
        {
            matr[i, j] = rand.Next(-10, 10) + rand.NextDouble();// [1,10)- полуинтервал,т.е. 10- не войдет    
        }
    }
}

void PrintArray(double[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write("{0,6:F1}", matr[i, j]);

        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine()!);
double[,] matrixA = new double[m, n];

FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();