using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        int n =121;
        int rem;
        int res=0;
        int temp = n;
        
        while(n!=0)
        {
            rem= n%10;
            res= res*10 +rem;
            n=n/10;
        }
        n=temp;
        
        if(n== res)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }
        
    }
}
