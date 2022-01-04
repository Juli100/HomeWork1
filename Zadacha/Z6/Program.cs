int max = new Random().Next(10, 100);
Console.WriteLine(max);
int numberA = max / 10;
int numberB = max % 10;
if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else 
{
    Console.WriteLine(numberB);
}

