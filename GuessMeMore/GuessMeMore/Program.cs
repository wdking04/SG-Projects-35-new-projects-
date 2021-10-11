using System;

namespace GuessMeMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "I 've chosen a number between -100 and 100. Bet you can't guess it!";
            int num = rand.Next(1, 101);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == num)
                    {
                        Console.WriteLine("Wow, nice guess!That was it!");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine("Ha, nice try -too high! Try again!");
                    }
                    else
                    {
                        Console.WriteLine("Ha, nice try -too low! Try again!");
                    }
                }

                catch
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }


                i++;
            }
            





        }
    }
}




//Take your original number guessing program and improve it! Save the new version as GuessMeMore.

//    Make the number chosen, a random number between -100 and 100
//    If the user gets it wrong, give them another chance at guessing.

//What You Should See (Example)

//I 've chosen a number between -100 and 100. Bet you can't guess it!
//Your guess: 44

//Ha, nice try -too low! Try again!
//Your guess: 99

//Wow, nice guess!That was it!

