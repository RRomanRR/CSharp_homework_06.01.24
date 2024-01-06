// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write ("Enter the natural number: ");
int n = Convert.ToInt32 (Console.ReadLine ());

if (n<10)
{
    Console.WriteLine (n);
}
else
{
    write (n > 0);
}
int currentDigit = n % 10;
n /= 10;
if (n>0)
{
    Console.Write(currentDigit+",");
}
else
{
    Console.WriteLine(currentDigit);
}