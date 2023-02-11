Console.WriteLine("ввод b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("ввод k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("ввод b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("ввод k2: ");
int k2 = int.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Линии параллельны");

    if (b1 == b2)
    {
        Console.WriteLine("Линии совпадают");
    }
    else
    {
        Console.WriteLine("Линии не пересекаются");
    }
}
else
{
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;

    Console.WriteLine("Прямые пересекаются в точке (" + x + "," + y + ")");
}
