﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2==0) Console.Write("Yes. Even");
else Console.Write("No. Not an even number");