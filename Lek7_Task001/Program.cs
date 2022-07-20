// Рекурурсия. Собрать строку с числами от a до b, a <= b.

string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine("Числа от a до b итеративно: ");
Console.WriteLine(NumberFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine("Числа от a до b рекурсия: ");
Console.WriteLine(NumberRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//  Собрать строку с числами от a до b, a >= b.

string NumberFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumberRec1(int a, int b)
{
    if (a <= b) return NumberRec1(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine("Числа от a до b итеративно: ");
Console.WriteLine(NumberFor1(10, 1)); // 10 9 8 7 6 5 4 3 2 1 
Console.WriteLine("Числа от a до b рекурсия: ");
Console.WriteLine(NumberRec1(1, 10)); // 10 9 8 7 6 5 4 3 2 1 



// Сумма чисел от 1 до n.

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n ==0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine("Сумма чисел от 1 до n  итеративно: ");
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine("Сумма чисел от 1 до n  рекурсия: ");
Console.WriteLine(SumRec(10)); // 55