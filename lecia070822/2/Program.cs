


//double Factorial(double n)
//{
//    if (n ==1) return 1;
//    else return n*Factorial(n-1);
//}

//for (int i = 1; i < 40; i++)
//{
//    Console.WriteLine($" {i}! {Factorial(i)}");
//}

//Console.WriteLine(Factorial(5));

// f(1) =1
// f(2) =2
// f(n) = f(n-1) + f(n-2)

double Fibanacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibanacci(n-1) + Fibanacci(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibanacci(i));    
}