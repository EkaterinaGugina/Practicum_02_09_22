// Ex66: Задайте значения M и N. Напишите программу, которая найдёт сумму чисел в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 
// ПЕРВЫЙ  СПОСОБ - спомощью рекурсии
int SumMNrecurs(int m, int n)
{                 
    int sumMN = 0;
    if (m == n) return n;
    else return n + SumMNrecurs(m, n - 1);    
}
Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("и число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ПЕРВЫМ СПОСОБОМ: Сумма чисел от {M} до {N} равна {SumMNrecurs(M, N)}");

// ВТОРОЙ  СПОСОБ - по формуле сумма арифм.прогрессии без каких-либо функций и новых переменных выводим на печать

Console.WriteLine($"ВТОРЫМ СПОСОБОМ: Сумма чисел от {M} до {N} равна {(M + N) * (N - M + 1) * 0.5}");
