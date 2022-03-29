int num = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int n)
{
    int f_1 = 1;
    int f_2 = 1;
    int temp = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write(f_1 + " ");
        temp = f_1;
        f_1 = f_2;
        f_2 = temp + f_2;
    }
}
Fibonacci(num);