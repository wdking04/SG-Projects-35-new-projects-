using System;

namespace MiniMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun1;
            string adjective1;
            string noun2;
            int number;
            string adjective2;
            string pluralNoun1;
            string pluralNoun2;
            string pluralNoun3;
            string verbPresentTense;
            string sameVerbPastTense;


            
            Console.WriteLine("Let's play MAD LIBS! \n\n I need a noun: ");
            noun1 = Console.ReadLine();

            Console.WriteLine("Now an adjective: ");
            adjective1 = Console.ReadLine();


            Console.WriteLine("Now another noun: ");
            noun2 = Console.ReadLine();
            
            Console.Write("And a number: ");
            number= Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Another adjective: ");
            adjective2 = Console.ReadLine();
            
            Console.WriteLine("A plural noun: ");
            pluralNoun1 = Console.ReadLine();
            
            Console.WriteLine("Another one: ");
            pluralNoun2 = Console.ReadLine();
            
            Console.WriteLine("One more: ");
            pluralNoun3 = Console.ReadLine();

             Console.WriteLine("A verb (infinitive form): ");
            verbPresentTense = Console.ReadLine();
            
            Console.WriteLine("Same verb (past participle): ");
            sameVerbPastTense = Console.ReadLine();

            Console.WriteLine("*** NOW LET'S GET MAD (libs) ***");
            Console.Write($"{noun1}: The {adjective1} frontier. These are the voyages of the starship {noun2}. It's {number} - year mission: To explore strange {adjective2}{pluralNoun1}, seek out {adjective2}{pluralNoun2} and {adjective2}{pluralNoun3}, to boldly {verbPresentTense} where no one has {sameVerbPastTense} before.");
            
            
            

        }
    }
}
