double n;
n = 8;
int index;        
index = 1;
while (index <= n)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
        index = index + 1;
    }
    else
    {
        index = index + 1;
    }
}