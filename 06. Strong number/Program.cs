using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int num = numbers;
            int sum = 0;

            while (num > 0)
            {
                int number = num % 10;
                num /= 10;
                int facturiel = 1;
                for (int i = 1; i <= number; i++)
                {
                    facturiel *= i;
                }
                sum += facturiel;
            }

            if (sum == numbers)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
