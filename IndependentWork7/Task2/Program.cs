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

int [,] matrixA = new int [4,4];

void Coordinates(int position1, int position2 )
{
    if (position1 < 0 | position1 > matrixA.GetLength(0) | position2 < 0 | position2 > matrixA.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
        return;
    }
    

}

FillArray(matrixA);
PrintArray(matrixA);
Console.Write("Введите строку:");
int pos1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец:");
int pos2 = int.Parse(Console.ReadLine()!);
Coordinates(pos1, pos2);
// Console.WriteLine();
// int[,] matrixA = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// FillArray(matrixA);
Console.WriteLine(matrixA[pos1, pos2]);