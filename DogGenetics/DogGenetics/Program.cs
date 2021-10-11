using System;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {

            string petName;
            int grey, whip, salu, deerhnd, wolfhnd;
            Random random = new Random();

            Console.Write("What is your dog's name?");
            petName = Console.ReadLine();

            Console.WriteLine("Well then, I have this highly reliable report on " + petName + "'s prestigious background right here.");

            Console.WriteLine(petName + " is:\n");



            grey = random.Next(1, 21); 
            whip = random.Next(1, 21);
            salu = random.Next(1, 21);
            deerhnd = random.Next(1, 21);
            wolfhnd = 100 - (grey + whip + salu + deerhnd);
           

            Console.WriteLine(grey + " % Greyhound");
            Console.WriteLine(whip + " % Whippet");
            Console.WriteLine(salu + " % Saluki");
            Console.WriteLine(deerhnd + " % Deer Hound");
            Console.WriteLine(wolfhnd + "% Wolf Hound");

            Console.WriteLine();
            Console.WriteLine("Wow, that's QUITE the dog!");

        }
    }
}



//Dog Genetics

//Ever heard of those places that you can mail in some of your dog's hair, and they'll send back a report
//after doing a genetic analysis on it to tell you what kind of dogs are in your most believe pet's ancestry?
//Well, we don't know how to do that. But we DO know how to generate random numbers. And half the time,
//that's good enough. Especially for the Internet.
//Requirements

//This program will be a C# Console Application named DogGenetics.

//    The program asks the user for the name of their dog and then generates a fake DNA background report on the pet dog.
//    It should assign a random percentage to five different dog breeds. The total of the percentages should add up to 100%!

//Here is an example of what the output might look like:

//What is your dog's name? Sir Fluffy McFlufferkins Esquire
//Well then, I have this highly reliable report on Sir Fluffy McFlufferkins Esquire's prestigious background right here.

//Sir Fluffy McFlufferkins Esquire is:

//61 % St.Bernard
//2 % Chihuahua
//29 % Dramatic RedNosed Asian Pug
//1% Common Cur
//7% King Doberman

//Wow, that's QUITE the dog!

