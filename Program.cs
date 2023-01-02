using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            string userNumber = Console.ReadLine();

            FizzBuzzRange(userNumber);

            Console.ReadLine();
        }
        public static void FizzBuzz(int userNumberIn)
        {
            if (userNumberIn%3 == 0 && userNumberIn%5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (userNumberIn%3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (userNumberIn%5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(userNumberIn);
            } 
        }

        public static void FizzBuzzRange(string numPassedToRange)
        {
            int userNumber;

            if (int.TryParse(numPassedToRange, out userNumber)) 
            {
                for (int i = 0; i < 101; i++)
                {
                    FizzBuzz(userNumber + i);
                }
            }
            else
            {
                Console.WriteLine("A value other than a whole number was entered, cannot execute.");
            }
        }
    }
}
