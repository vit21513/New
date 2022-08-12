int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}



//void Binary(int num)
//{
//    int num2 = num;
//    int count= 0; 
//while (num>0)
//    {

//        int bin = num % 2;
//        num = num / 2;
//        count++;
//    }


//int [] array = new int[] 

//    while (num>0)
//    {

//        int bin = num % 2;
//        num = num / 2;
//        Console.Write($"{bin} ");
//    }



//}

int numbers = UserInputInt("введите любое число");
//Binary(numbers);


void Tobin(int n)
{
    if (n ==0) return;
    Tobin(n/2);
    Console.Write(n%2);
}
Tobin (numbers);
