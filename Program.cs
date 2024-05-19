using System;

class fibonachi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(fib(number));
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
    }
    public static int fib(int number)
    {
        int y = 0;
        int z = 1;
        for (int x = 1; x < number; x++)
        {
            int temp = y;
            y = z;
            z = temp + z;
        }
        return y;
    }

        
}

