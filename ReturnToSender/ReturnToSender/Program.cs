using System;

namespace ReturnToSender
{
    class Program
    {
        static void Main(string[] args)
        {
            char aMystery = Mystery();
            string totallyUnexpected = Unexpected();
            double aSurprise = Surprise();
            bool itsClassified = Classified();
            int aSecret = Secret();

            Console.WriteLine("The methods have returned! Their results...\n");
            Console.WriteLine("Mysterious: " + aMystery);
            Console.WriteLine("Secret: " + aSecret);
            Console.WriteLine("Surprising: " + aSurprise);
            Console.WriteLine("Classified: " + itsClassified);
            Console.WriteLine("Unexpected: " + totallyUnexpected);
            Console.ReadLine();

        }

        public static int Secret()
        {
            return 42;
        }

        public static double Surprise()
        {
            return 3.14;
        }

        public static char Mystery()
        {
            return 'X';
        }

        public static bool Classified()
        {
            return true;
        }

        public static String Unexpected()
        {
            return "Spanish Inquisition";
        }
    }
}



//Create a new program using the following code.
//    Fix the type definitions to match the return types of the called methods.
//    When everything matches correctly, compile and run it!
//What You Should See (When Completed)

//The methods have returned! Their results...

//Mysterious: X
//Secret: 42
//Surprising: 3.14
//Classified: true
//Unexpected: Spanish Inquisition

