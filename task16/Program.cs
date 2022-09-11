using System;
internal class Program
{
    static void Main()
    {
        int n;
        var product = new string[7];

        product[0] = "Monday";
        product[1] = "Tuesday";
        product[2] = "Wednesday";
        product[3] = "Thursday";
        product[4] = "Friday";
        product[5] = "Saturday";
        product[6] = "Sunday";

        Console.WriteLine("write your number");
        n = int.Parse(Console.ReadLine());
        
        if(n==1|| n == 2 || n == 3 || n == 4 || n == 5|| n == 6 || n == 7)
        {
            Console.WriteLine(product[n - 1]);
        }
        else
        {
            Console.WriteLine("not valid");
        }
     



    }
}