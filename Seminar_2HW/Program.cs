// **Home Work**
 // 10. Напишите программу, которая принимает 
 //на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

  /* void SecondNumber()
 {
     Console.WriteLine("ВВедите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    int num1 = num/10; 
    int num2 = num1%10;
    Console.WriteLine( " Вторая цифра " + num2);
    
 }
 SecondNumber(); */

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

/* Console.WriteLine("ВВедите трехзначное число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int num1 = num%10;
Console.WriteLine( " Третья цифра цифра : " + num1); */

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine( "Введите цифру  : ");
int num = Convert.ToInt32(Console.ReadLine());
if ( num == 1 )
{
    Console.WriteLine( " День недели - Понедельник . ");
}
if ( num == 2 )
{
    Console.WriteLine( " День недели - Вторник . ");
}
if ( num == 3 )
{
    Console.WriteLine( " День недели - Среда . ");
}
if ( num == 4 )
{
    Console.WriteLine( " День недели - Четверг . ");
}
if ( num == 5 )
{
    Console.WriteLine( " День недели - Пятница . ");
}
if ( num == 6 )
{
    Console.WriteLine( " День недели - Суббота . ");
}
if ( num == 7 )
{
    Console.WriteLine( " День недели - Воскресенье . ");
}
if (num == 0 )
{
    Console.WriteLine( " День недели под данной цифрой не существует . ");
}
if (num > 7 )
{
    Console.WriteLine( " День недели под данной цифрой не существует . ");
}