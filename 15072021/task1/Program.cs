﻿Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0)
{
    Console.WriteLine("Первая четверть");
}
else if (x<0 && y>0)
{
    Console.WriteLine("вторая");    
}
else if (x<0 && y<0) 
{
    Console.WriteLine("третья");    
}
else if (x>0 && y<0)
{
    Console.WriteLine("четвртая");
}
else
{
    Console.WriteLine("не корректные координаты");
}


