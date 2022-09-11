using System;
internal class Program
{
    static void Main()
    {
        int n;
        bool result = false;
        Console.WriteLine("write your number");
        n = int.Parse(Console.ReadLine());

        if ((n % 9 == 0)|| (n % 11 == 0)|| (n % 13 == 0))
        {
            result = true;
        }




        Console.WriteLine(result);


    }
}