void distance(int xA, int yA, int zA, int xB, int yB, int zB)                    
{
    double d = Math.Pow((Math.Pow(xB - xA, 2) +
                         Math.Pow(yB - yA, 2) +
                         Math.Pow(zB - zA, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Расстояние составляет \n" + d);
    return;
}
void Main()
{
    Console.Write("Введите точку xA:");
    int xA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите точку yA:");
    int yA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите точку zA:");
    int zA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите точку xB:");
    int xB = int.Parse(Console.ReadLine()!);
    Console.Write("Введите точку yB:");
    int yB = int.Parse(Console.ReadLine()!);
    Console.Write("Введите точку zB:");
    int zB = int.Parse(Console.ReadLine()!);
     
    distance(xA, yA, zA, xB, yB, zB);
}
Main();