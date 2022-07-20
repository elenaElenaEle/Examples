// Вычислить а в степени n.

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerFRec(int a, int n)
{
    // return n == 0 ? 1 : PowerFRec(a, n - 1) * a; //можно записать так
    if (n == 0) return 1;
    else return PowerFRec(a, n-1) * a;
}

Console.WriteLine("а в степени n итеративно: ");
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine("а в степени n рекурсия: ");
Console.WriteLine(PowerFRec(2, 10)); // 1024

int PowerMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerMath (a * a, n / 2);
    else return PowerMath( a, n - 1) * a;
}
Console.WriteLine(PowerMath(2, 10)); // 1024