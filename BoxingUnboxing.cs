
using System;

class HelloWorld
{
    static void Main()
    {
        int i =44;
        object boxedObject = i;
        
        int unboxedValue= (int)boxedObject;
        Console.WriteLine("original:"+i);
        Console.WriteLine("Boxed:"+boxedObject);
        Console.WriteLine("Unboxed value:"+unboxedValue);
    }
}
