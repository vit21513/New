//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

//Console.WriteLine("Введите число ");
//int num = Convert.ToInt32(Console.ReadLine());

//int sum =0;
///for (int i=0; i<= num; i++)
//{
 //   sum = sum + i;
//}
//Console.WriteLine($"сумма чисел от 1 до  {num} = {sum}");


//int Getsum (int number)
//{
//    int sum =0;
//for (int i=0; i<= number; i++)
//{
//    sum = sum + i;


//}
//return sum;
//}

//int result =  Getsum(num);
//Console.WriteLine ($"сумма чисел от 1 до  {num} = {result}");
//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//Console.Clear();
//Console.WriteLine("Введи число:");
//int a = Convert.ToInt32(Console.ReadLine());

//int GetCountNum(int numb)
{
 //   int index = 1;
 //   int x = 0;
 //   while (index <= numb)
 //   {
 //       x = x + 1;
 //       index = index * 10;
 //   }
  //  return x;
}
//int res = GetCountNum(a);
//Console.WriteLine($"Количество цифр в числе = {res}");

//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
//12 мин


//Console.Clear();
//Console.WriteLine("Введи число:");
///int a = Convert.ToInt32(Console.ReadLine());
//int GetMulti(int numb)
{
    int res = 1;
    for (int i = 1; i <= numb; i++)
    {
        res = res * i;
    }
    return res;
}

//int sum = GetMulti(a);
//Console.WriteLine($"произведение чисел от 1 до {a} = {sum}");


//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
////нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//int [] array = new int[8];
//int [] array = {0,1,2,3,4,5,6,7};
//int rndNum = new Random().Next(0, 2);

//int[] array = new int[20];

//for (int i = 0; i < array.Length; i++)
//{
 //   int num = new Random().Next(0, 2);
////    array[i] = num;
//}

//Console.Write("[");
//for (int i = 0; i < array.Length; i++)
//{
//    if (int==0) Console.WriteLine("[");
//    Console.Write(array[i]);
//}
//Console.Write("]");

//int[] array = GetRandomArray(12);//
//WriteArrayToConsole(array);

//int[] GetRandomArray(int arrayLength)
//{
//    Random rnd = new Random();
//    int[] arr = new int[arrayLength];
//
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = rnd.Next(0,2);
//    }
//    return arr;
//}

//void WriteArrayToConsole(int[] array)
//{
//    Console.Clear();
//    Console.Write("[");
//    for (int i = 0; i < array.Length; i++)
    {
//        Console.Write(array[i]);
//        if(i != array.Length -1)
//            Console.Write(",");
    }
//    Console.WriteLine("]");    
//}
