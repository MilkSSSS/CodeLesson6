// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Enter the number of Fibonacci numbers: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c;

Console.Write(a + " " + b + " ");

for (int i = 2; i < n; i++)
{
c = a + b;
a = b;
b = c;

Console.Write(c + " ");
}

Console.WriteLine();