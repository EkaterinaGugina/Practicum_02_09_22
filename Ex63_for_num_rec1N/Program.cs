// Ex63: Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.
//N = 5. -> ""1, 2, 3, 4, 5""
void PrintNum1N(int n)                  //заполнение и печать массива
{
    if (n == 1) Console.Write($"{n}");
    else 
    {
        PrintNum1N(n - 1);
        Console.WriteLine($"{n} ");
    }
}

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNum1N(N);
