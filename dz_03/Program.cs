int[]weekendDays = {6,7};
int a;

Console.WriteLine("Введите день недели 1-7: ");
a = int.Parse(Console.ReadLine());

bool isWeekendDay = weekendDays.Contains(a);
string result;
if (isWeekendDay) {
    result = "да";
} else {
    result = "нет";
}

Console.WriteLine(result);
