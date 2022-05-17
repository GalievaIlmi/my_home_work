// Задача 41: Пользователь вводит с клавиатуры М чисел.Посчитайте, сколько чисел больше 0 ввел пользоратель.
/*
int input = 5;
int count = 0;
while (input > 0)
{
    Console.WriteLine("введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
    input--;
} 
Console.WriteLine("Количество чисел больше 0 =" + count);
*/
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*Console.WriteLine(" Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string digit = String.Empty;
while (num > 0) 
{
    
    if (num % 2 == 0)
    {
        int result = num / 2;
        digit = 0 + digit;
        num = result;
    }   
    else 
    {
        int result = num / 2;
        digit = 1 + digit;
        num = result;
    }
}
//Console.WriteLine(num);
Console.WriteLine(digit);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("введите точку № 1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку № 2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку № 3 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку № 4 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * (b2 - b1)/(k1 - k2)  + b1;
Console.WriteLine($"Точка пересечения:  ({x};{y})");