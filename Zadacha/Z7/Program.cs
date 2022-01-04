int number = new Random().Next(100, 1000);
int first = number / 100;
int third = number  % 10;
Console.WriteLine($"{number} превращается в : {first} {third}");

