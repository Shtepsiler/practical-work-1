using System;

internal class Program
{
    static void Main()
    {
        int a, b, h;
        float area;

        Console.WriteLine("write your numbers");

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());


        area = (a + b) / 2.0f*h;
        
        Console.WriteLine(area);


    }
}