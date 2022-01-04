   
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = (number / 10) % 10;
Console.WriteLine("Вторая цифра трёхзначного числа - " + second);