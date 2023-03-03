int count = 0;
void GreaterZero(int[] Arra)
{
    for (int i = 0; i < Arra.Length; i++)
    {
        if (Arra[i] > 0)
        {
            count++;
        }
    }
}
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
GreaterZero(arr);
Console.WriteLine($"Кол-во элементов > 0: {count}");