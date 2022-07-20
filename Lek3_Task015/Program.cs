// Упорядочить массив

int[] arr = {1, 5, 4 , 3, 2, 6, 7, 1, 1 }; // задали массив

void PrintArray(int[] array) // метод вывода массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод упорядочивания массива от меньшего к большему
{
        for (int i = 0; i < array.Length - 1; i++)
    {
            int minPosition = i;
            
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }

            int temporarty = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporarty;
    }
}

void SelectionSortMaxMin(int[] array) // метод упорядочивания массива от большего к меньшему
{
        for (int i = 0; i < array.Length - 1; i++)
    {
            int maxPosition = i;
            
            for (int k = i + 1; k < array.Length; k++)
            {
                if(array[k] > array[maxPosition]) maxPosition = k;
            }

            int temporarty = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temporarty;
    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine("Упорядоченный массив отменьшего к большему");
PrintArray(arr);
SelectionSortMaxMin(arr);
Console.WriteLine("Упорядоченный массив от большего к меньшему");
PrintArray(arr);


