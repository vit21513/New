//void Metod1()
//{
 //   Console.Writeline("cxvfbc");
//}

//Metod1();

//string msg= "fdgdgdg";

//void metod2(string msg)
///{Console.Writeline(msg);}
//metod2(msg);

//void Method21(string msg, int count)
//{
 //   int i=0;
   // while (i<count)
    //{
     //   Console.Writeline(msg);
       // i++;
        
    //}
//}
//Method21(msg: "add text", count: 4)
//int Metgod3()
//{
//    return DateTime.Now.Year;
//}

//int year = Metgod3();
//Console.WriteLine(year);
 
//string Method4 (int count, string text)
//{
//  int i = 0;
//  string result =string.Empty;

//  while (i<count)
//  {
//    result = result + text;
//    i++;
//  }
//  return result;
//}

//string res = Method4(10, "zx");
//Console.WriteLine(res);


//string Method4 (int count, string text)
//{
//    string result =string.Empty;

//  for (int i =0; i<count; i++)
//  {
//    result = result + text;
      
//  }
//  return result;
//}

//string res = Method4(10, "zx");
//Console.WriteLine(res);

//for (int i =2; i <= 10; i++)
//{
//  for (int j =2; j <= 10;j++)
//  {
//    Console.WriteLine($"{i}*{j}= {i*j}");
//
//  }
//  Console.WriteLine(" ");
//}

//дан текст. все пробелы заменить черточками, 
//маленькие к заменить на большие К. большие "С" на маленькие "с"

string text = "- Я думаю, сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадаите мне чаю";
//string s 
//string Replase(string text,char oldValue, char newValue)
//{
//  string result = string.Empty;
//  int lenght = text.Length;
//  for (int i= 0; i< lenght; i++)
//  {
//    if (text[i] == oldValue) result= result + $" {newValue}";
//    else result= result + $"{text[i]}";
//  }
 // return result;

  //}
  //string newText = Replase(text, ' ', '|');
  //Console.WriteLine(newText);
  //Console.WriteLine();
  //newText = Replase(newText, 'к', 'К');
  //  Console.WriteLine(newText);

  // 6,8,3,2,1,4,5,7
int [] arr ={1,5,4,3,2,6,7,1,1};
void PrintArray(int[] array)
{
  int count =array.Length;
  for (int i = 0; i<count; i++)
  {
    Console.Write($" {array[i]}");
  }
  Console.WriteLine(); 
}
PrintArray(arr);
void SelectionSort(int[] array)
{
  for (int i = 0; i<array.Length; i++)
  {int minPosition = i;
  for (int j=i+1;j<array.Length;j++)
  {
    if (array[j] < array[minPosition]) minPosition =j;
    int temporary =array[i];
  array[i] = array[minPosition];
  array[minPosition] = temporary;
    
  }


  
  }

}

SelectionSort(arr);
