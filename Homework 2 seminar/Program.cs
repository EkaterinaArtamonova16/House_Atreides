﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());

if (a/100==0 || a/100 > 9)
{
    Console.WriteLine("This is not correct");
}
else 
{
    a = a % 100;
    a = a / 10;

}
 Console.WriteLine(a);
