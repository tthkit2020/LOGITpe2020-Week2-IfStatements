using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Personality Test
             * People who love cats are homebirds
             * People who love dogs are partygoers
             * People who love other animals are just animal friends
             */
            string UserInput;
            Console.WriteLine("What is your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat")
            {
                Console.WriteLine("You are a homebird.");
            } else if (UserInput == "dog")
            {
                Console.WriteLine("You are a partygoer.");
            } else
            {
                Console.WriteLine($"You are a {UserInput} friend.");
            }

        }
    }
}
