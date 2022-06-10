using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBels = double.Parse(Console.ReadLine());

            int freeBelts = (countOfStudents / 6);
           
            

            double neededMoney = priceOfLightSabers * Math.Ceiling((countOfStudents + countOfStudents * 0.1)) + priceOfRobes * countOfStudents + priceOfBels * (countOfStudents - freeBelts);

            if (amountOfMoney >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(neededMoney - amountOfMoney):f2}lv more.");
            }
        }
    }
}
