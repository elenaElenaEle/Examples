// Подсчет чисел Фибоначи
decimal fRec = 0;
decimal FIte = 0;

decimal FibonscciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonscciRecursion(n - 1) + FibonscciRecursion(n - 2);
}
decimal FibonscciIteration(int n)
{
    FIte++; // кол-во итераций цикла
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1; 
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        FIte++;
    }
    return result;
}
//# 1 2 3 4 5 6
//V 1 1 2 3 5 8
Console.ReadLine();
for (int n = 1; n < 5; n++)
{
    Console.WriteLine($"FibonscciIteration{n}) = {FibonscciIteration(n)} FIte = {FIte.ToString("### ### ###), -15")}");
    FIte = 0;
} 
Console.WriteLine();
Console.ReadLine();
for (int n = 1; n < 5; n++)
{
    Console.WriteLine($"FibonscciRecursion({n}) = {FibonscciRecursion(n)} fRec = {fRec.ToString("### ### ###), -15")}");
    fRec = 0;
}
Console.ReadLine(); 