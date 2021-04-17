using System;

namespace SBSC_INTERNSHIP_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a c# program to check prime number. 
            //Input: 17 
            //Output: prime number 
            //Input: 57 
            //Output: not prime number
             

             // prime no has just two factor, 1 and itself.
            int num;
            int i;
            int count = 0;
            Console.WriteLine("Hi, lemme help you and check for prime number \n Enter the number:");
             num = Convert.ToInt32(Console.ReadLine());

          

           for(i=1; i<=num; i++)
           {
             if(num % i == 0)
             count++;
           }

           if(count == 2)
            Console.Write("{0} is a prime number", num); 
           else
           Console.Write("{0} is not a prime number", num);
        }
    }
}
