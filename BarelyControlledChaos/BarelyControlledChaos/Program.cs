using System;

namespace BarelyControlledChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            string color = RandomColor(); // call color method here
            string animal = RandomAnimal(); // call animal method again here
            string colorAgain = RandomColor(); // call color method again here
            int weight = randomizer.Next(5, 200); // call number method,
                                                  // with a range between 5 - 200
            int distance = randomizer.Next(10, 20); // call number method,
                                                    // with a range between 10 - 20
            int number = randomizer.Next(10000, 20000); // call number method,
                                                        // with a range between 10000 - 20000
            int time = randomizer.Next(2, 6); // call number method,
                                              // with a range between 2 - 6            

            Console.WriteLine("Once, when I was very small...");

            Console.WriteLine("I was chased by a " + color + ", "
                + weight + "lb " + " miniature " + animal
                + " for over " + distance + " miles!!");

            Console.WriteLine("I had to hide in a field of over "
                + number + " " + colorAgain + " poppies for nearly "
                + time + " hours until it left me alone!");

            Console.WriteLine("\nIt was QUITE the experience, "
                + "let me tell you!");
        }

        public static String RandomColor()
        {
            Random randomizer = new Random();
            String[] colors = { "Red", "Orange", "Yellow", "Green", "Blue" };
            int random = randomizer.Next( colors.Length);
            return colors[random];
        }

        public static String RandomAnimal()
        {
            Random randomizer = new Random();
            String[] animals = { "Bird", "Snake", "Dog", "Cat", "Fish" };
            int random = randomizer.Next(animals.Length);
            return animals[random];
        }

        public static int numberRandom(int x, int y)
        {
            Random randomizer = new Random();
            return randomizer.Next(x) + y;
        }


        // ??? Method 1 ???
        // ??? Method 2 ???
        // ??? Method 3 ???
    }
}


//Next, write define and write the methods needed to complete it:

//    Write a method that returns a randomly chosen color (have it choose from at LEAST five different colors!)
//    Write a method that returns a randomly chosen animal (have it choose from at LEAST five different animals!)
//    Write another method that returns a random integer chosen from a range (min/max) that can be either of the two numbers or anything between.

//When you're done defining & implementing these methods, replace the ??? in the main method with a call to the appropriate type.

//Once, when I was very small...
//I was chased by a magenta, 80lb miniature mammoth for over 12 miles!!
//I had to hide in a field of over 4593 periwinkle poppies for nearly 3 hours until it left me alone!

//It was QUITE the experience, let me tell you!