Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc) //метод
{
    if (xc>0 && yc>0) {return "Первая четверть";}
    if (xc<0 && yc>0) {return "вторая";}
    if (xc<0 && yc<0) {return "третья";}
    if (xc>0 && yc<0) {return "четвертая";}
    return "не корректные координаты";
}

string result = Quarter(x, y); ///вызов метода присваеваем переменной result строковая string
Console.WriteLine(result);


