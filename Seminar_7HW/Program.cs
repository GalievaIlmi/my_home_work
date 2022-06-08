// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/* double[,] matrix = new double[5, 3];
 
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = random.Next(100);
        Console.Write("{0,4}", matrix[i, j]);
    }
    Console.WriteLine();
}
*/
//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/* int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Позиция m: ");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Позиция n: ");
int position2 = Convert.ToInt32(Console.ReadLine());

if(position1 == array.GetLength(0) + 1 || position2 == array.GetLength(1) + 1)
{
    Console.WriteLine("Выберите позиции в пределах массива :(");
}
else
{
    Console.WriteLine("Ваше число: " + array[position1 - 1, position2 - 1]);
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Среднее арифметическое элементов столбца {j + 1}: {sum / array.GetLength(0)} ");
}