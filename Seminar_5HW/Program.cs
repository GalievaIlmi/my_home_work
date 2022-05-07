// Задача 1: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Math.Pow(numA, numB);
// Console.WriteLine("numA^numB= " + Math.Pow(numA, numB));

/* Console.WriteLine("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
   int result = 1;
for (int i = 0; i < numB; i++)
{
result = result * numA;
}

Console.WriteLine("degree of number B = "+ result);

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/* int[] array  = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ");
}
PrintArray(array);*/

//Задача 2: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(num>0)
{
int dig = num % 10;
result = dig + result;
num = num / 10;
}
Console.WriteLine(result);