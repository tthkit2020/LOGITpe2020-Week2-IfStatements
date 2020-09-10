using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task2
             *Write a program that asks user's year of birth
             *and decides if the user is old enough to get permanent 
             *driving license
             
             *Task3
            /* Write a program that accepts two numbers (integers)
             * and checks whether they are equal or not and displays feedback.
             * 
             * int a;
             * int b;
             * if(a == b)
             */

            Console.WriteLine("What is your first number?");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            Console.WriteLine("What is your first number?");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);
        }
    }
}
