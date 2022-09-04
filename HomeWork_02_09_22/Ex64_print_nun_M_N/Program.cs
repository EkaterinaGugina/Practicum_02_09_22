// Ex64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N в обратном порядке.
//M = 1; N = 5. -> ""5, 4, 3, 2, 1""
//M = 4; N = 8. -> ""8, 7, 6, 5, 4""
void PrintNumMNrevers(int m, int n)
{                 
    if (m <= n) 
    {
        Console.Write($"{n} ");
        PrintNumMNrevers(m, n - 1);
    }
}
Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("и число N = ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumMNrevers(M, N);
