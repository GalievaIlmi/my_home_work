
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
 int num1 = num / 10000;
 int num2 = num / 1000 % 10;
int num5 = num % 10;
int num4 = num / 10  % 10;
Console.WriteLine("Первые две цифры:" + num1 + num2 + "  " + "Последние две цифры:" + num4 + num5);
 if (num1 == num5 || num2 == num4)
 {
     Console.WriteLine("Заданное число является палиндромом!");
 }
     else
     {
        Console.WriteLine("Заданное число не является палиндромом!"); 
     }
*/

/*
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите кординату первой точки на оси Х :");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату первой точки на оси Y :");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату первой точки на оси Z :");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату второй точки на оси Х :");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату второй точки на оси Y :");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату второй точки на оси Z :");
int c2 = Convert.ToInt32(Console.ReadLine());

double Sqrt1(int a1, int a2, int b1, int b2, int c1, int c2)
{
    return Math.Sqrt((a2-a1)*(a2-a1) + (b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
}
Console.WriteLine(Sqrt1(a1 ,b1, c1, a2, b2, c2 ));
*/

//Задача 23.
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* Console.Write("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"{i} -> {cube} ");
*/