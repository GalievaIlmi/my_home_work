// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите тятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 1000;
Console.WriteLine("Первые две цифры заданного числа: " + num1);
int num2 = num % 100;
Console.WriteLine("Последние две цифры заданного числа: " + num2);
if (num1 == num2)
{
    Console.WriteLine("Заданное число является палиндромом!");
}
    else
    {
       Console.WriteLine("Заданное число не является палиндромом!"); 
    }
