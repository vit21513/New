//0. Демонстрация решения
//Напишите программу, которая на вход
//принимает число и выдаёт его квадрат (число
//умноженное на само себя).
//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49
//Console.Write("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//int num = 4; // -2.147 до 2.147 млрд
//int res= num * num;
//Console.WriteLine($"Квадрат чмсла {num} ={res}");

//Console.Write("Введите первое число ");
//int first = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите Второе число ");
//int second = Convert.ToInt32(Console.ReadLine());
//if (first == second*second)
//{
//Console.WriteLine("Да");
//}
//else
//Console.WriteLine("Нет");

Console.Write("введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Понедельник");
  
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
  
}
else if (day == 3)
{
    Console.WriteLine("Среда");
  
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
  
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
  
}
else if (day == 6)
{
    Console.WriteLine("Субота");
  
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
  
}
else if (day > 7)
{
    Console.WriteLine("нет больше дней");
  
}