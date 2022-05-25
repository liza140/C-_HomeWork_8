// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

// упорядочивание по убыванию элементов каждой строки массива
void ReplaceElements(int[,] array)
{
    int bufer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxP = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxP]) maxP = k;
            }
            bufer = array[i, j];
            array[i, j] = array[i, maxP];
            array[i, maxP] = bufer;
        }
    }
}


int M = 3;
int N = 3;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
ReplaceElements(Array);
PrintArray(Array);




