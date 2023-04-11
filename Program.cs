// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void PrintReduceNumber(int N)
{
    Console.Write(N + " ");
    if (N > 1) PrintReduceNumber(N - 1);
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintReduceNumber(N);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumSearch(int m, int n)
{
    if (m!=n)
    {
        if (m > n)
        {
            return SumSearch(m - 1, n) + m;
        }
        else
        {
            return SumSearch(m + 1, n) + m;
        }
    }
    return m;
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumSearch(M,N));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Введите первый аргумент M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй аргумент N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(M, N));
