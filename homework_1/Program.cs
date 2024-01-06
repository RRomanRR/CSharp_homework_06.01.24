// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write ("Enter a number a: ");
int a = Convert.ToInt32 (Console.ReadLine ());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine ("yes");
}
else
{
    Console.WriteLine ("no");
}