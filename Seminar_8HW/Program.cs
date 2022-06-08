// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы 
// каждой строки двумерного массива.

*/* Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[,] rowSort = SortRow(array);
PrintArray(rowSort);

int[,] SortRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;
            }
            int tmp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = tmp;
        }
    }
    return array;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random random = new Random();
            matrix[i, j] = random.Next(1, 100);
        }
    }
}
*/
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* int m = 4;

int n = 4;
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
int sum = 0;
int index = 0;
int min = 0;
for (int i = 0; i < m; i++)
{
    sum = 0;
    for (int j = 0; j < n; j++)
    {

        sum = sum + array[i, j];
    }
    Console.WriteLine($"Сумма элементов строки {i + 1} = {sum}");
    if (i == 0)
    {
        min = sum;
    }
    else if (sum < min)
    {
        min = sum;
        index = i;
    }
}
Console.WriteLine($"Наименьшая сумма элементов находится в строке {index+1} = {min}");
*/
// Задача 62. Заполните спирально массив 4 на 4.
int[,] array = new int[4, 4];
FillArray(array.GetLength(0), array.GetLength(1), array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int lastRow, int lastCol, int[,] array)
{
    int value = 1;
    int firstRow = 0;
    int firstCol = 0;

    while (firstRow < lastRow && firstCol < lastCol)
    {
        for (int i = firstCol; i < lastCol; ++i)
        {
            array[firstRow, i] = value++;
        }
        firstRow++;
        for (int i = firstRow; i < lastRow; ++i)
        {
            array[i, lastCol - 1] = value++;
        }
        lastCol--;

        if (firstRow < lastRow)
        {
            for (int i = lastCol - 1; i >= firstCol; --i)
            {
                array[lastRow - 1, i] = value++;
            }
        }

        lastRow--;

        if (firstCol < lastCol)
        {
            for (int i = lastRow - 1; i >= firstRow; --i)
            {
                array[i, firstCol] = value++;
            }
        }

        firstCol++;
    }
    PrintArray(array);
}