﻿//1. Задача 31: Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. 
//2. Найдите сумму
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна
//-20.
// 3. Выывод результата 

int [] CreateArrayRand (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]  = rnd.Next(min,max+1);
        
    } return arr;
}  

int [] GetSumPosNegeLem (int[] array)
{
    int sumNeg =0; int sumPos =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
            sumNeg+= array[i];
        }
        else
        {
            sumPos += array[i];
        }
        return new int []{sumNeg, sumPos};
      
    }

}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i==0) Console.Write("[");
        if (i<array.Length-1)  Console.Write (array[i] + ",");
        else Console.Write (array[i] + "]");        
    }
}
int[] array = CreateArrayRand (12, -9, 9);
PrintArray (array);
int [] getSumPosNegeLem = GetSumPosNegeLem (array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumposNegelem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumposNegelem[0]}");




//int[] CreateArrayRndInt(int size, int min, int max)
//{
//    int[] arr = new int[size];
//    Random rnd = new Random();

 //   for (int i = 0; i < arr.Length; i++)
 //   {
 //       arr[i] = rnd.Next(min, max + 1);
  //  }
   // return arr;
//}

//int[] GetSumPosNegElem(int[] array)
//{
//    int sumNeg = 0;
 //   int sumPos = 0;
 //   for (int i = 0; i < array.Length; i++)
//{
 //       if (array[i] < 0)
 //       {
 //           sumNeg += array[i];
 //       }
  //      else
 //       {
 //           sumPos += array[i];
 //       }
//    }
//return new int[] {sumNeg, sumPos};
//}
//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if(i == 0) Console.Write("[");
//        if(i < array.Length - 1) Console.Write(array[i] + ",");
//        else Console.Write(array[i] + "]");
//    }
//}

//int[] array = CreateArrayRndInt(12, -9, 9);
//PrintArray(array);
//int[] sumPosNegElem = GetSumPosNegElem(array);
//Console.WriteLine();
//Console.WriteLine($"Сумма положительных чисел = {sumPosNegElem[1]}");
//Console.WriteLine($"Сумма отрицательных чисел = {sumPosNegElem[0]}");

