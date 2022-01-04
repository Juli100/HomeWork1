Console.Write("Введите число N: ");
string Number = Console.ReadLine();
int N = int.Parse(Number);
int n = 0 - N;
while (n <= N)
{
    Console.Write(" " + n + " ");
    n = n + 1;
}
Console.WriteLine();