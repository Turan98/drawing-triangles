int a;
Console.Write("Enter height of triangle: ");
a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    for (int k = 0; k <= i; k++)
    {
        Console.Write(" ");
    }
    for (int j = a; j > i; j--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

for (int i = 0; i < a; i++)
{
    for (int k = a; k>i; k--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < a; i++)
{
    
    for (int j = 0; j <=i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
for (int i = 0; i < a; i++)
{
    for (int k = 0; k < i; k++)
    {
        
    }
    for (int j = a; j >i; j--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}


