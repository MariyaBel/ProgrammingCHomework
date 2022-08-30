// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a == b && b == c)
{
    Console.Write("All numbers are even. There is no max");
    return;
}
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.Write(max);

