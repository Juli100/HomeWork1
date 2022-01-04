int number = new Random().Next(1, 10000);
int Count = 0;
int current = number;
while (current > 0)
{
    current = current / 10;
    Count ++;
}
Console.WriteLine(number);
if (Count < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int third = number / 100 % 10;
    Console.WriteLine(third);
}