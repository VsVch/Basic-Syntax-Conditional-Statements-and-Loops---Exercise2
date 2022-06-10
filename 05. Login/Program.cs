using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string rePassword = string.Empty;

            for (int i = password.Length - 1; i >= 0; i--)
            {
                rePassword += password[i];
            }

            string input = Console.ReadLine();
            int count = 1;
            while (input != rePassword)
            {
                if (count > 3)
                {
                    Console.WriteLine($"User {password} blocked!");
                    break;
                }

                Console.WriteLine($"Incorrect password. Try again.");

               
                

                input = Console.ReadLine();
                count++;
            }
            if (input == rePassword)
            {
                Console.WriteLine($"User {password} logged in.");
            }
                


        }
    }
}
