//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (n == m) return n;
    else
    {
        return SumNumbers(m, n - 1) +n;
    }
}

Console.WriteLine(SumNumbers(4, 8));