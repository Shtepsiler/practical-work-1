using System;
internal class Program
{
    static void Main()
    {
        int n, number, nDigit;

        Console.WriteLine("write your numbers");
        Console.WriteLine("write number");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("write n");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("nDigit is ");
        nDigit =(int)(number / (Math.Pow(10f, n-1f)) % 10);
        

        Console.WriteLine(nDigit);


    }
}