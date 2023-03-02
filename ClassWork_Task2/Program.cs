// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int numb = Convert.ToInt32(Console.ReadLine());
string numbs = string.Empty;

while (numb > 0)
{
    numbs = numb % 2 + numbs;  
    numb = numb / 2;
}
Console.WriteLine(numbs);