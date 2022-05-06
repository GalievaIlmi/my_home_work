// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/* int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100 , 1000);
    Console.Write(array[i] + ", ");
}


    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0 )
        {
            counter++;
        }
    }
    Console.WriteLine("Количество четных чисел: " + counter);
    */

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + ", ");
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        sum = sum + array[i];
        Console.WriteLine(sum);
    }
}

*/
// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
     Random rand = new Random();
        array[i] = Math.Round(rand.NextDouble(), 1);
}
void PrintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
}
PrintArray(array);

double minNum = array[0];
double maxNum = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minNum)
    {
        minNum = array[i];
    }
    if (array[i] > maxNum)
    {
        maxNum = array[i];
    }
    
}
Console.WriteLine(" мин. число в массиве - "  + minNum);
Console.WriteLine(" макс. число в массиве - "  + maxNum);

double diff = maxNum - minNum;
Console.WriteLine(" разница между максимальным и минимальным элементов массива равна - " + diff);