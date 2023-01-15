// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else if (n <= 0 || n < 1)
        Console.WriteLine ("Ошибка!");
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
            return m;
}

Console.WriteLine(NaturalNumber(n, m));