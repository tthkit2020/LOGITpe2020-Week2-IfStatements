using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that  checks whether a given number
             * is positive or negative.             
             */

            Console.WriteLine("What's your number?");
            string UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);

            if(Number > 0)
            {
                Console.WriteLine("The number is positive.");
            } else if (Number < 0)
            {
                Console.WriteLine("The number is negative.");
            } else
            {
                Console.WriteLine("The number is 0.");
            }


        }
    }
}
