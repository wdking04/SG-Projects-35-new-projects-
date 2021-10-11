using System;

namespace MatchWork
{
    class Program
    {
        
        static void Main(string[] args)
        {
  
            Console.WriteLine(" The word Cart should come before Horse alphabetically : " + ComesBefore("cart","horse"));
            Console.WriteLine(" Half of 42 = " + HalfOf(42));
            Console.WriteLine(" (short) Pi = " + Pi());
            Console.WriteLine(" The first letter of the word Llama is: " + FirstLetter("Llama"));
            Console.WriteLine(" 1337 x 1337 = " + Times1337(1337));
        }

        public static double Pi()
        {
            return 3.14;
        }

        public static int Times1337(int x)
        {
            return x * 1337;
        }

        public static double HalfOf(double y)
        {
            return y / 2;
        }

        public static string FirstLetter(string word)
        {
            return word.Substring(0, 1);
        }

        public static bool ComesBefore(string a, string b)
        {
            return a.CompareTo(b) < 0;
        }

    }
    
}


//Create a new program using the following code.
//    Fix the method calls by changing the ??? to the correct number of literal values.
//    When everything matches correctly, compile and run it.

//What You Should See

//The word Cart should come before Horse alphabetically : true
//Half of 42 = 21.0
//(short) Pi = 3.14
//The first letter of the word Llama is: L
//1337 x 1337 = 1787569

