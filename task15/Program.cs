using System;
internal class Program
{
    static void Main()
    {
        float a, b, c;
        string product;
        Console.WriteLine("write your number");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());

        int n=0;
        if (a < 0)
            n++;
        if (b < 0)
            n++;
        if (c < 0)
            n++;

        if (n == 0 || n == 2)
            product = "positive";
        else
            product = "negative";

        Console.WriteLine(product);



    }
}