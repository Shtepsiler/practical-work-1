using System;
internal class Program
{
    static void Main()
    {
        int n;
        bool result=false;
        Console.WriteLine("write your number");
        n = int.Parse(Console.ReadLine());

        if(n>=20 && (n%2==1) )
        {
            result=true;
        }




        Console.WriteLine(result);


    }
}