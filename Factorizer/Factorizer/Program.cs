using System;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {

            int factorIndex = 0;
            int sum = 0;
            int posUserNum; 
            int possibleFactor;
            //int userNum; 
            int userOutput;// output

            //string userNum;
            while (true)
            {
                Console.WriteLine("Please choose a number to factorize: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out userOutput))
                {
                    if(userOutput < 0)
                    {
                        posUserNum = userOutput * -1;
                    }
                    break;  

                }
                else
                {
                    posUserNum = userOutput;
                    //Console.WriteLine("That's not a number");
                }
            }

            posUserNum = userOutput;
            //length is positive User Num * 2 to account for negative number factors
            int[] factors = new int[(posUserNum * 2)];

            //find factorsconsidering negative
            for (possibleFactor = 1; possibleFactor <= posUserNum; possibleFactor++)
            {
                if (userOutput % possibleFactor == 0)
                {
                    factors[factorIndex] = possibleFactor;
                    factorIndex++;
                    factors[factorIndex] = possibleFactor * -1;
                    factorIndex++;
                }

            }


            //print factors while leaving out the user number and blank spots in array length.
            for (int i = 0; i < factors.Length; i++)
            {
                if (!((0 == factors[i]) || factors[i] == userOutput || factors[i] == (userOutput * -1)))
                {
                    Console.Write("The factors of " + userOutput + " are:");
                    Console.WriteLine(factors[i]);
                }
            }

            //perfect number and print, disclude negatives (negative number can't be perfect)
            if (userOutput >= 0)
            {
                for (int j = 0; j < factors.Length; j += 2)
                {

                    sum += factors[j];
                }

                if (sum / 2 == userOutput)
                {
                    Console.WriteLine( userOutput + " Is a perfect number");
                }
            }
            else
            {
                Console.WriteLine(userOutput + " Is not a perfect number");
            }

            //find if it's a prime and print, do it for positive and negative
            if (userOutput >= 0 && sum == 1 + userOutput)
            {
                Console.WriteLine(userOutput + " Is a prime number");
                //is it negative? how to print if prime
            }
            if (userOutput < 0)
            {
                for (int k = 0; k < factors.Length; k += 2)
                {
                    sum += factors[k];
                }
                if (sum == (posUserNum + 1))
                {
                    Console.WriteLine(userOutput + " Is a prime number");
                }

            }
            else
            {
                Console.WriteLine(userOutput + " Is not a prime number");
            }
        }
    }
    
}


//In this exercise, you will write a program that receives an integer value from a user
//and then calculates and prints out a list that includes all of the factors of that number,
//whether or not the number is perfect, and whether or not the number is prime.


//A perfect number is a number where all the factors of the number, excluding the number
//itself, add up to that number.For example, the first perfect number is 6 because its
//factors 1, 2, and 3 add up to 6.


//A prime number is defined as a number greater than 1 that has only itself and 1 as
//factors.For example, 3 is a prime number, but 4 is not.


//This exercise is provided to give you practice applying the skills you have
//learned in this course, but you will not submit it to your instructor nor will it be
//graded.


//    You should complete this exercise before continuing on with the course.
//    If you have problems completing this exercise, review the course content up to
//    this point and try again.
//    Contact an instructor or TA if you have questions about this exercise or cannot
//    resolve problems on your own.
//    Remember to sync your code with your classwork repository after you have completed
//    the exercise.

//Requirements

//Write your program with the following features:

//    This program must be in a new console application named Factorizer.
//    This program must ask the user for the number the program will factor.
//    The program must print out the original number.
//    The program must print out each factor of the number (not including the number itself).
//    The program must print out the total number of factors for the number.
//    The program must print out whether or not the number is perfect.
//    The program must print out whether or not the number is prime.

//Sample Program Output

//What number would you like to factor? *6*
//The factors of 6 are:
//1 2 3 6
//6 has 4 factors.
//6 is a perfect number.
//6 is not a prime number.

