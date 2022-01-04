Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ??"0");
if(number>=100)
{
    int firstThree = number % 1000;
    int first = firstThree / 100;
    Console.WriteLine("третья цифра числа: "+ first);

}
else
    Console.WriteLine("В числе нет третьей цифры");
