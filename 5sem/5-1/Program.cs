//задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
///соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет/
//3; массив [6, 7, 19, 345, 3] -> да

int [] CreateArrayRand (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]  = rnd.Next(min,max+1);
        
    } return arr;


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
       else Console.Write(array[i] + "]");
   }
}

int [] GetNewArray (int array)



int[] CreateArrayRndInd (int size, int min, int max) // 1 пункт
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void GetRivers (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInd(4, -100, 100);

PrintArray(array);
GetRivers(array);
Console.WriteLine();
PrintArray(array);


void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(i == 0) Console.Write("[");
		if(i < array.Length - 1) Console.Write(array[i] + ",");
		else Console.Write(array[i] + "]");
	}
}



///
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInd (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void Elem (int[] array, int search)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] == search)
		{
            Console.WriteLine($"Числа {search} есть в массиве");
            return;
		}
	}
    Console.WriteLine($"Числа {search} нет в массиве");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInd(12, 0, 6);
PrintArray(array);
Console.WriteLine();
Elem(array, num);
