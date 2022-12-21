using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count, prime, temp; // I assigned these variables at the beginning for clarity and ease when using any of them. 

            // prompt the user for the start and the end values 
            Console.WriteLine("Enter start value = ");
              int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end  value = ");
              int end = int.Parse(Console.ReadLine());

            // I used this condition to swap the start and the end values ,if needed just to avoid confusion. 
            if (start > end)
            {
                temp = start;
                start = end;
                end = temp;
            }
            Console.WriteLine(" Prime numbers between {0} and {1} is ", start, end);

            // I used nested loop to find out and display the prime numbers in the given range.
            for (num = start; num <= end; num++)
            {
                prime = 0; // means that the the current num is a prime numb so far.
                for (count = 2; count < num; count++)
                {
                    if (num % count == 0)
                    {
                        prime = 1; // It means that this num is not a prime number .
                        break;    // I used break here because there is no need to continue this loop. 
                    }
                }
                if (prime == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}