void Base10to2(int a)
{
    string n = string.Empty;
    while (a > 0)
    {
        n = Convert.ToString(a % 2) + n;
        a /= 2;
    }
    Console.WriteLine(n);
}

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Base10to2(num);