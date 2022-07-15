Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

WriteSquareTable(n);


void WriteSquareTable(int n)
{
    int i = 1;

    while (i <= n)
    {
        Console.WriteLine($"| {i} | {i * i, 2} |");
        i++;
    }
}
