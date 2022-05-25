// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Проверка на возможность замены столбцов и строк
bool CheckArray(int m, int n)
{
    bool check = false;
    if (m == n) check = true;
    return check;
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

// замена строк на столбцы
void ReplaceElements(int[,] array)
{
    int bufer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            bufer = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = bufer;
        }
    }
}

int M = 3;
int N = 3;
int[,] Array = CreateArray(M, N);
bool Check = CheckArray(M, N);
if (Check == true)
{
    FillArray(Array);
    PrintArray(Array);
    Console.WriteLine();
    ReplaceElements(Array);
    PrintArray(Array);
}
else Console.WriteLine("Замена строк на столбцы невозможна");



