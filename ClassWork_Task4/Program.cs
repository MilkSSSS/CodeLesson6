// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

int[] array = { 1, 2, 3, 4, 5 };

int[] copyArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
copyArray[i] = array[i];
}

Console.WriteLine("Original array:");
foreach (int num in array)
{
Console.Write(num + " ");
}

Console.WriteLine("\nCopied array:");
foreach (int num in copyArray)
{
Console.Write(num + " ");
}

Console.WriteLine();