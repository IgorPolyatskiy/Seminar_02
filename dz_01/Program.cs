int a;

Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine()!);

if (a / 100 > 0)
{
    while (a >= 1000)
    {
        a = a / 10;
    }
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число имеет менее 3 знаков");
}

