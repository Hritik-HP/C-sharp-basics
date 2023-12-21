// Swaping of two numbers
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int a=10;
       int b=2;
       int temp;
       
       Console.WriteLine("before swaping a={0},b={1}",a,b);
       
       temp=a;
       a=b;
       b=temp;
       Console.WriteLine("After swapping a={0},b={1}",a,b);
    }
}
