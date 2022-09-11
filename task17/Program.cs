using System;


    internal class Program
    {
        static void Main()
        {

        int n, factorial=1;

        Console.WriteLine("write your number");

      n = int.Parse(Console.ReadLine());

        for(int i=2; i<=n; i++)
            factorial = factorial * i;

        Console.WriteLine($"factorial {n} is {factorial}" );

    }
    }

