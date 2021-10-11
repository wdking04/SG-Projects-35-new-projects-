using System;

namespace StillPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 389, -447, 26, -485, 712, -884, 94, -64, 868, -776, 227, -744, 422, -109, 259, -500, 278, -219, 799, -311 };

            Console.WriteLine("Gotta stay positive...!");

            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

    }
}

//Project: StillPositive

//Write a program that prints out all positive numbers of the following array:

//    What You Should See

//Gotta stay positive ...!
//389 26 712 94 868 227 422 259 278 799

