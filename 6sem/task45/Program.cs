
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.





int[] CreateArrayRndInd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}



void [] CoppyArray (int [] array)
{
    int lenght = a
    for (int i = 0; i < array.Length i++)
    {
        array[a ]
    }

    return new int (array.Length);
}


int[] Copy(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}
