void CountOfPositiveNumber(int limit)
{
    int count = 0;
    for (int i = 0; i < limit; i++)
    {
        Console.Write("Enter the number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b > 0) count += 1;
    }
    Console.Write("Positive count = " + count);
}

Console.Write("Enter the limit: ");
int a = Convert.ToInt32(Console.ReadLine());
CountOfPositiveNumber(a);