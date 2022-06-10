using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double priceForOne = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            priceForOne = 8.45;
                            break;
                        case "Saturday":
                            priceForOne = 9.8;
                            break;
                        case "Sunday":
                            priceForOne = 10.46;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceForOne = 10.9;
                            break;
                        case "Saturday":
                            priceForOne = 15.6;
                            break;
                        case "Sunday":
                            priceForOne = 16;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceForOne = 15;
                            break;
                        case "Saturday":
                            priceForOne = 20;
                            break;
                        case "Sunday":
                            priceForOne = 22.5;
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
            double priceForAll = countOfPeople * priceForOne;
            if (type == "Students" && countOfPeople >= 30)
            {
                priceForAll = priceForAll * 0.85;
            }
            if (type == "Business" && countOfPeople >= 100)
            {
                countOfPeople = countOfPeople - 10;
                priceForAll = countOfPeople * priceForOne;
            }
            if (type == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                priceForAll = priceForAll * 0.95;
            }

            Console.WriteLine($"Total price: {priceForAll:f2}");
        }
    }
}
