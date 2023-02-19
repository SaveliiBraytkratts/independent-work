int index = 1;
void TableCubesNumbers (int N)
{
    while (index <= N)
    {
        int Cubes = index * index * index;
        index++;
        Console.Write(Cubes);
        Console.Write(", ");
    } 
}
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine()!);
TableCubesNumbers (N);