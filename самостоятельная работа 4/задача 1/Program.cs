int index = 1;
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int result = number;
void naturalDegree (int number, int degree)
{
    while ( index < degree )
    {
        result = (result * number);
        index++;
    }
}
Console.Write("Введите степень:");
int degree = int.Parse(Console.ReadLine()!);
naturalDegree(number, degree );
Console.Write(result);