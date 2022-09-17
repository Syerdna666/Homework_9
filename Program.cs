// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


string GetNaturalsBetweenWithRecursion(int m, int n)
{
  if (m == n) return Convert.ToString(n);
  return n + ", " + GetNaturalsBetweenWithRecursion(m, n - 1);
}

System.Console.WriteLine(GetNaturalsBetweenWithRecursion(3, 20));


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumBetween(int M, int N){
    if (M == N) return M;
    return M + GetSumBetween(M + 1, N);
}
System.Console.WriteLine(GetSumBetween(1, 4));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n){
    if (m == 0) return n+1;
    if (n == 0) return Akkerman(m-1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1) );
}

System.Console.WriteLine(Akkerman(3, 2));