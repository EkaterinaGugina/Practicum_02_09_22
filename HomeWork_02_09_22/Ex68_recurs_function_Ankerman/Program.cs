// Ex68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int FunctionAnkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAnkerman(m - 1, 1);
        else if (m > 0 && n > 0) return FunctionAnkerman(m - 1, FunctionAnkerman(m, n - 1));
            else return -1;
}
Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("и число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({M},{N}) = {FunctionAnkerman(M, N)}");