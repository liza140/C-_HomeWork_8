// В прямоугольной матрице найти строку с наименьшей суммой элементов

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Заполнение массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Поиск суммы элементов каждой строки
int[] SumRowElements(int[,] array)
{
    int[] sumElements = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumElements[i] = sumElements[i] + array[i, j];
        }
    }
    return sumElements;
}

// Печать суммы элементов каждой строки
void PrintSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов {i} строки = {array[i]}");
    }
}

// Поиск строки с наименьшей суммой элементов
int FindMinSumRow(int[] array)
{
    int minP = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minP = i;
        }
    }
    return minP;
}

int M = 4;
int N = 5;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int[] SumElements = SumRowElements(Array);
PrintSum(SumElements);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {FindMinSumRow(SumElements)} строке");
