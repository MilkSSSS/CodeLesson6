// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Input a side a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a side b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a side c ");
int c = Convert.ToInt32(Console.ReadLine());

if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("This is triangle!");
}
else
{
    Console.WriteLine("This is not triangle");
}