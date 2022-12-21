using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first prompt the user for the start and the end numbers 
            Console.WriteLine("Enter the start number =  ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number =  ");
            int n2 = int.Parse(Console.ReadLine());

            // then use the for loop to display every perfect number in the given range 
            for (int i = n1; n1 <= n2; n1++)
            {
                
                int result = perfectnumber(n1); // is another method to find out wether n1 is a perfect number or not 

                if (n1 == result) // finally use this condition to check if n1 equals to the sum returned from *perfectnumber* method
                {
                    Console.WriteLine("{0} is a perfect number", n1); 
                }

            }

        }

        static int perfectnumber(int n1)
        {
            int sum = 0;

            for (int i = 1; i < n1; i++) 
            {
                if (n1 % i == 0)
                {
                    sum += i; // that is the sum of the divisors that are less than n1 
                }
            }
            return sum;
        }
    }
}
