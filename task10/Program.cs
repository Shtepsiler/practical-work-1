using System;
internal class Program
{
    static void Main()
    {
        int n, lastDigit;

        Console.WriteLine("write your numbers");
        Console.WriteLine("write n");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("lastDigit is ");

        lastDigit = n % 10;


        Console.WriteLine(lastDigit);


    }
}