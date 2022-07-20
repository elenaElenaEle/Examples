// Двумерные массивы string[,] table = new string[2, 3]  row - строка, column - столбец
string[,] table = new string[2, 5]; //задали массив из 2 строк и 5 столбцов
// String.Empty
// table [0, 0]  table [0, 1]  table [0, 2]  table [0, 3]  table [0, 4]  
// table [1, 0]  table [1, 1]  table [1, 2]  table [1, 3]  table [1, 4]

/* table[1, 2] = "слово "; // обращаемся к элементу массива в 1 строкой и 2 стобце

for (int rows = 0; rows < 2; rows++) // цикл в цикле чтобы распечатать массив
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */

void PrintArray(int[,] matr) // метод вывода двумерного массива 
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод заполнения двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
