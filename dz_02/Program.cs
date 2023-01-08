int a;

Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine()!);

if (a / 100 > 0)
{
    while (a >= 100)
    {
        a = a / 10;
    }
    int result = a % 10;
    Console.WriteLine($"Вторая цифра числа: {result}");
}
