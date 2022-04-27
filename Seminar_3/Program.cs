// 
/* int FindQvart(int x, int y)
{
    if(x >0 && y>0)
    return 1;
    else if(x <0 && y>0)
    return 2;
    else if(x < 0 && y < 0)
    return 3;
    else if(x > 0 && y < 0)
    return 4; 
    else
    return 0;
}
Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());
int qvartNum = FindQvart(xDot, yDot);
if (qvartNum == 0)
Console.WriteLine("Dot located  on the axes");
else
Console.WriteLine("Nunder of qrart is " + qvartNum); */

// Напишите программу , которая по заданному номеру четверти,  
// показывает диапозон возможных координат точек в этой четверти ( х и у ).

/* void FindQvart(int qvart)
{
    if( qvart == 1)
    Console.WriteLine("Координаты точки х > и y > 0");
    else if ( qvart == 2)
Console.WriteLine("Координаты точки х < 0 и y > 0");
    else if ( qvart == 3)
    Console.WriteLine("Координаты точки х < 0 и y < 0");
   else if ( qvart == 4)
   Console.WriteLine("Координаты точки х > 0 и y < 0");
    else
   Console.WriteLine( "Координаты точки на оси" );
}

Console.Write("number qvart: 1 - 4 ");
int QvartNum = Convert.ToInt32(Console.ReadLine());
if (QvartNum > 4 || QvartNum < 0 )
Console.WriteLine( "Некорректно введена четверть координат " );
else
FindQvart(QvartNum);
*/

// Напишите программу которая принимает на вход координаты двух точек и находит расстояние м\у ними в 2д пространстве.

/*Console.Clear();
double Sqrt1(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
}
Console.WriteLine("Введите координату х первой точки:   ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:   ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки:   ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:   ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sqrt1(x1 ,y1 ,x2 ,y2 ));
*/

// Напишите программу, которая на вход принимает число N и выдает таблицу квадратов от 1 до N.
void g