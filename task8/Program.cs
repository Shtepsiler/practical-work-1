using System;

    internal class Program
    {
        static void Main()
        {
        int a,b,c;
        float average;

        Console.WriteLine("write your numbers");

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());


        average = (a + b + c) / 3.0f;

        Console.WriteLine(average);


        }
    }

