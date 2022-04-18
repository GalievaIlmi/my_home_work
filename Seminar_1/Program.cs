// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

/* 
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
Console.WriteLine("Большее число: " + number2);
Console.WriteLine("Меньшее число: " + number1);
}
else
{
    Console.WriteLine("Большее число: " + number1);
    Console.WriteLine("Меньшее число: " + number2);
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.

/* Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = number1;
if (maxNumber < number2)
{
    maxNumber = number2;
}
if (maxNumber < number3)
{
    maxNumber = number3;
}

Console.WriteLine("Максимальное число: " + maxNumber); */

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/

/* Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.WriteLine("Чётные числа из диапазона от 1 до " + number);
while (count <= number)
{
    if (count % 2 == 0) 
    {
        Console.Write(count + " ");
    }
    count++;
}

Console.WriteLine(" ");

