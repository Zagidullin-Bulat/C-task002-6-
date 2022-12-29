// Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, заданных уравнениями 

Console.WriteLine ("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine ("Прямые совпадают");
    }
else if (k1==k2)
    {
        Console.WriteLine ("Прямые параллельны");
    }

else
    {
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine ($"Переменная x={x}, переменная y={y}");
    }