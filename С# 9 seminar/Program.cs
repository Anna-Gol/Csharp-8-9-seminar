// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


string Numbers(int M, int N)
{
    if (M <= N) return Numbers( M, N - 1) + " " + $"{N}";
    else return String.Empty;
}

Console.WriteLine(Numbers(1, 5));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int M, int N)
{
    if (M <= N) 
    {
        return Sum( M, N - 1) + N;
    }
    else 
    {
        return 0;
    }
}

Console.WriteLine(Sum(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }

    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine(Akkerman(2, 3));
