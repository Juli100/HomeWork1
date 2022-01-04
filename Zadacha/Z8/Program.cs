Console.WriteLine("Введите большее число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите меньшее число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA < numberB)
{
    Console.WriteLine("не делится");
}
else
{

if (numberA % numberB == 0)
{
    Console.WriteLine($"{numberA} Кратно {numberB}");
}
else
{
    Console.Write("Не кратно. Остаток: ");
    Console.WriteLine (numberA % numberB);
}
}
