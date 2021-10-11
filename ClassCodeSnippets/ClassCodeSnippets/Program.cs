using System;

namespace ClassCodeSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSharpTypes(); //Types
            //ExampleType et = new ExampleType(); //Variables
            //et.Method(10);
            //NullableSimpleTypes();
            //UsePersonClass();
            //ExpressionsAndOperators();  //Expressions & Operators use for Debugging too
            //TwoPersonObjects();
            ConsoleInputOutput();
            //IfStatements();
            //SwitchStatements();
            //LotsOfLoops();
            //RandomObject();
            //Console.WriteLine(MethodsThatReturn(10));
            //PrintCurrentDate();
            //UseSportsRecorderClasses();
            //UsePassingValues();
            //PassParameters();
            //UseAddTogether();
            //UseTryParse();
            //UsingOptionalParameters();
            //ParamsKeyword();
            //Console.WriteLine("Using a loop:  " + Factorial1(4));
            //Console.WriteLine("Using recursion:  " + Factorial2(4));
            //ALotOfArrays();
            //StringsAreCharArrays();
            //FormattingOutput();
            //StringMethods();

            Console.ReadLine();
        }

        private static void CSharpTypes()
        {
            Console.WriteLine("C# Types");

            //Now let's look at the string class
            //String is the class and myStringType and mySubstring are the objects
            //Length is a property of the String class
            //Substring is a method of the String class
            string myStringType = "My String Type Properties and Methods";
            int myStringLength = myStringType.Length;
            string mySubstring = myStringType.Substring(0, 15);
            int mySubstringLength = mySubstring.Length;
            Console.WriteLine($"By using Substring my length went from {myStringLength} to {mySubstringLength}.");

            //Go to Object Browser and look up System.String
        }

        private class ExampleType
        {
            private int _field;

            //try changing public to private and see what happens in the main method
            public void Method(int parameter)
            {
                int localVariable;
                int uninitialized;
                int initialized = 5;
                //uncomment to see the error
                //Console.WriteLine(uninitialized);
                Console.WriteLine(_field); //automatically initialized to 0
                Console.WriteLine(parameter);
            }
        }

        private static void NullableSimpleTypes()
        {
            //What is null?
            //int nullInt = null;    // error
            int? nullableInt = 5; // ok         

            //change nullableInt to an int
            if (nullableInt.HasValue)
            {
                Console.WriteLine(nullableInt.Value);
            }

        }

        private class Person
        {
            //try changing public to private and see what happens in UsePersonClass method
            public string Name;
            public int Age;
        }

        private static void UsePersonClass()
        {
            //Person object will go in Heap and p1 with pointer to Person will go in Stack
            Person p1 = new Person();
            //p2 with pointer will go in Stack and point to the Person object already there
            Person p2 = p1;

            p1.Name = "Nestor";
            p2.Age = 45;
            Console.WriteLine(p2.Name);
            Console.WriteLine(p1.Age);

            p1.Name = "Kaladan";
            Console.WriteLine(p2.Name);
            Console.WriteLine(p1.Name);

            int personAge = 20;
            Console.WriteLine(personAge);
            personAge = 25;
            Console.WriteLine(personAge);

            Console.WriteLine(p1 == p2);
            //Value types are on Stack and when data is passed it is a copy so changes to
            //one copy does not affect any others
            //Reference types are on the Heap and only a copy of pointer is made so changes 
            //will affect other copies of pointer
        }

        private static void ExpressionsAndOperators()
        {
            int result1, result2, result3;

            int x = 5;
            int y = 10;

            int[] nums = { 3, 5 };

            //using methods and array elements in expressions
            result1 = Add(x, y) + Add(2, 3);  //20
            result2 = Add(Add(x, y), y);      //25
            result3 = nums[0] * nums[1];      //15

            Console.WriteLine($"Result1 = {result1}, Result2 = {result2}, Result3 = {result3}");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void TwoPersonObjects()
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.Name = "Nestor";
            p2.Name = "Nestor";
            p1.Age = 45;
            p2.Age = 45;

            Console.WriteLine(p1 == p2);
            //This time since we created 2 person objects so both are now in the Heap

            Person p3 = p1;
            Console.WriteLine(p3 == p1);
            //Now both variables are pointing to the same object
        }

        private static void NumericLierals()
        {
            //just uncomment so you can see the intellisense before we add the suffix char
            //float myFloat = 1234.567; //f or F
            //double myDouble = 1234.567;
            //decimal myDecimal = 1234.567; //m or M
            //int myInt = 1234567;
            //long myLong = 1234567; //l or L
        }

        private static void ConsoleInputOutput()
        {
            //using a while(true) loop to check for user input until something is entered
            string requiredString1 = "";
            while (true)
            {
                Console.WriteLine("Please enter something!!");
                requiredString1 = Console.ReadLine();

                if (string.IsNullOrEmpty(requiredString1))
                {
                    Console.WriteLine("You did't enter anything");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"You entered {requiredString1}\n");


            //using a while loop that checks the IsNullOrEmpty property of string
            Console.WriteLine("Let's do this again and enter something else.");
            string requiredString2 = Console.ReadLine();
            while (string.IsNullOrEmpty(requiredString2))
            {
                Console.WriteLine("You didn't enter anything, again!");
                Console.WriteLine("Please try again and enter something!!");
                requiredString2 = Console.ReadLine();
            }
            Console.WriteLine($"You entered {requiredString2} and earlier you entered {requiredString1}.\n");


            //using the TryParse() method of int to check user input
            //int.TryParse(string s, out int result)  //uncomment to see intellisense
            int outputInt;
            while (true)
            {
                Console.Write("Enter a number between 1 and 10: ");
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out outputInt))
                {
                    if (outputInt >= 1 && outputInt <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That number was not between 1 and 10!\n");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!\n");
                }
            }
            Console.WriteLine($"You entered this number:  {outputInt}");
        }

        private static void IfStatements()
        {
            int x = 5;
            int y = 10;

            //NOTE:  if there is only one line of code after the if condition
            //you don't have to use brackets
            if (x == 5)
                Console.WriteLine("x does = 5");

            //will this execute?
            if (x == 7)
                Console.WriteLine("Wow!  x equals 7!!");


            //if x = 5 and y = 10 then all 3 conditions are met,
            //but only the first condition that is true will be evaluated
            if (x < 20 && y < 20)
            {
                Console.WriteLine("Both values are less than 20");
                //Execution will stop here because this is true
            }
            else if (x < 15 && y < 15)
            {
                Console.WriteLine("Both values are less than 15");
            }
            else if (x < 10 && y < 10)
            {
                Console.WriteLine("Both values are less than 10");
            }
            else
            {
                Console.WriteLine("None of the above");
            }
        }

        private static void SwitchStatements()
        {
            int x = 5;

            switch (x)
            {
                // single case
                case 0:
                    Console.WriteLine("x is 0");
                    break;
                // multiple cases, aka "fall through"
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("x is 1, 2, or 3");
                    break;
                //default is like the else in an if else statement
                default:
                    Console.WriteLine("x is not 0, 1, 2, or 3");
                    break;
            }
        }

        private static void LotsOfLoops()
        {
            int x = 1;  //change 1 to 5 and see what happens

            //While loop
            while (x < 4)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine("While Loop is completed!\n");

            x = 5;
            //Do...While Loop
            //even though x is greater than 4, it will 'do' once
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 4);
            Console.WriteLine("Do...While Loop is completed!\n");

            //For Loop
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("Simple For Loop is completed!\n");

            //For Loop with a Switch Loop inside
            string s = "hello world";
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                switch (current)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine(current);
                        break;
                }
            }
            Console.WriteLine(string.Format("For Loop went through {0} chars to get the vowels!\n", s.Length));


            //break if divisable by 3
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    break;  //will exit loop
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine(" - For Loop is completed after the break!\n");

            //continue
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue; //will skip processing and go back to beginning of loop
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine(" - For Loop is completed, but continued till end!!");
        }

        private static void RandomObject()
        {
            Random random = new Random();

            int randomInteger = random.Next(10); //will generate between 0-9
            Console.WriteLine($"The number {randomInteger} is between 0 and 9!");

            string[] names = new string[] { "Kaladan", "Jasnah", "Navali", "Keith", "Roger" };
            int randomIndex = random.Next(names.Length);
            Console.WriteLine($"Which name was randomly returned?  {names[randomIndex]}");

            int randomRangeNumber = random.Next(-100, 101);
            Console.WriteLine($"This number is between -100 and 100:  {randomRangeNumber}");

            double randomDouble = random.NextDouble();
            Console.WriteLine($"This number will be between 0.0 to 1.0 (exclusive):  {randomDouble}");

            double randomRangeDouble = random.NextDouble() * (13.2 - -7.5) + -7.5;
            Console.WriteLine($"This number will be between -7.5 to 13.2:  {randomRangeDouble}");
        }

        private static int MethodsThatReturn(int x)
        {
            //all paths must return an int
            if (x > 0)
            {
                return x;
            }
            //comment out to see the error
            return 0;
        }

        private static void PrintCurrentDate()
        {
            //we can use return in a void method to exit out
            DateTime today = DateTime.Today;

            if (today.DayOfYear == 1)
            {
                Console.WriteLine("Happy New Years!");
                return; // immediately exit method
            }

            Console.WriteLine($"Today is day {today.DayOfYear} of the current year.");
            // no return needed here, we can let a void method end
        }

        private class SportsRecorder1
        {
            public void TurnOnTv()
            {
                Console.WriteLine("1.  Turn on TV.");
            }

            public void TurnOnCableBox()
            {
                Console.WriteLine("2.  Turn on CableBox.");
            }

            public void TuneToSportsChannel()
            {
                Console.WriteLine("3.  Tune to Sports Channel.");
            }

            public void StartRecording()
            {
                Console.WriteLine("4.  Start Recording.");
            }
        }

        private class SportsRecorder2
        {
            public void ExecuteProcess()
            {
                TurnOnTv();
                TurnOnCableBox();
                TuneToSportsChannel();
                StartRecording();
            }

            private void TurnOnTv()
            {
                Console.WriteLine("1.  Turn on TV.");
            }

            private void TurnOnCableBox()
            {
                Console.WriteLine("2.  Turn on CableBox.");
            }

            private void TuneToSportsChannel()
            {
                Console.WriteLine("3.  Tune to Sports Channel.");
            }

            private void StartRecording()
            {
                Console.WriteLine("4.  Start Recording.");
            }
        }

        private static void UseSportsRecorderClasses()
        {
            //Look at intellisense and see what is available
            Console.WriteLine("Using class with all Public methods");
            SportsRecorder1 recorder1 = new SportsRecorder1();
            recorder1.TurnOnCableBox();
            recorder1.StartRecording();
            recorder1.TuneToSportsChannel();
            recorder1.TurnOnTv();

            Console.WriteLine("");
            Console.WriteLine("Using class with private methods and one public method");
            SportsRecorder2 recorder2 = new SportsRecorder2();
            recorder2.ExecuteProcess();
        }

        //remove static from a method and show how to use it in the main method
        //we need to instantiate the program class to use a non-static method

        private static void PassingValues(int valueType, Person referenceType)
        {
            valueType = 5;
            referenceType.Name = "Nestor";
            referenceType.Age = 45;
        }

        private static void UsePassingValues()
        {
            //assign our values
            int x = 1;
            Person p = new Person();
            p.Name = "Navani";
            p.Age = 40;

            //call the PassingValues method
            PassingValues(x, p);

            //display the values
            Console.WriteLine(x);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            //why don't we see Navani and 40 as our values
        }

        private static void PassByValue(int numb)
        {
            numb = 5;
        }

        private static void PassByReference(ref int numb)
        {
            numb = 5;
        }

        private static void PassParameters()
        {
            int x = 1;

            Console.WriteLine("Passing x by value.");
            PassByValue(x);
            Console.WriteLine(x);

            Console.WriteLine("Passing x by reference.");
            PassByReference(ref x);
            Console.WriteLine(x);
        }

        //Overloading AddTogether method
        private static int AddTogether(int x, int y)
        {
            return x + y;
        }

        private static int AddTogether(int x, int y, int z)
        {
            return x + y + z;
        }

        private static double AddTogether(double x, double y)
        {
            return x + y;
        }

        private static double AddTogether(int x, int y, double z)
        {
            return x + y + z;
        }

        private static double AddTogether(double x, int y, int z)
        {
            return x + y + z;
        }

        //// invalid, there is already an Add(int, int)
        //private int AddTogether(int a, int b)
        //{
        //    return a + b;
        //}

        private static void UseAddTogether()
        {
            //use intellisense to see all of the overloaded methods
            Console.WriteLine("Add together with int, int:  " + AddTogether(2, 3));
            Console.WriteLine("Add together with double, double:  " + AddTogether(2.2, 3.3));
            Console.WriteLine("Add together with double, int, int:  " + AddTogether(2.2, 2, 3));
            Console.WriteLine("Add together with int, int, int:  " + AddTogether(2, 3, 4));
            Console.WriteLine("Add together with int, int, double:  " + AddTogether(2, 3, 4.4));
        }

        private static bool TryParse(string s, out int value)
        {
            // check if each character is a digit
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    // found a non-digit character, fail
                    value = int.MinValue;
                    return false;
                }
            }

            // all characters are digits, set the output param
            value = int.Parse(s);

            // return success
            return true;
        }

        private static void UseTryParse()
        {
            int output;  //this will hold the value of the output after calling TryParse()
            string input = "hello";
            if (!TryParse(input, out output))
            {
                Console.WriteLine($"{input} could not be converted.");
            }

            input = "52";
            if (TryParse(input, out output))
            {
                Console.WriteLine($"{input} was converted to {output}");
            }
        }

        private static int Add(int x, int y = 0, int z = 0)
        {
            return x + y + z;
        }

        private static void UsingOptionalParameters()
        {
            Console.WriteLine(Add(5));
            Console.WriteLine(Add(5, 10));
            Console.WriteLine(Add(5, 10, 15));
        }

        private static int Sum(params int[] numbers)
        {
            //params allows us to pass any number od same data type as an array
            // no numbers? 0
            if (numbers.Length < 1)
                return 0;

            int sum = 0;
            // loop the array indexes
            for (int i = 0; i < numbers.Length; i++)
            {
                // add the current number to sum
                sum += numbers[i];
            }
            return sum;
        }

        private static void ParamsKeyword()
        {
            Console.WriteLine("Add just one int?:  " + Sum(5));
            Console.WriteLine("Add two ints:  " + Sum(5, 10));
            Console.WriteLine("Add three ints:  " + Sum(5, 10, 15));
            Console.WriteLine("Add ten ints:  " + Sum(5, 10, 15, 20, 25, 30, 35, 40, 45, 50));
        }

        private static int Factorial1(int number)
        {
            int product = number;
            number--;

            // keep multiplying until we hit zero
            //we countdown in a loop
            while (number > 0)
            {
                product *= number;
                number--;
            }
            return product;
        }

        private static int Factorial2(int number)
        {
            if (number <= 1)
            {
                return number; // stop recursion
            }
            else
            {
                // next recursive step
                //we call the method again and countdown the number that is passed
                return number * Factorial2(number - 1);
            }
        }

        private static void ALotOfArrays()
        {
            // create a new array with 4 elements (default 0 for int)
            // int[] numbers = new int[] { 0, 0, 0, 0 };
            int[] numbers1 = new int[4];

            // auto-initialize 1 dimensional array
            int[] numbers2 = new int[] { 3, 5, 2, 0 };

            // 2 dimensional array - think of a table
            int rows = 2;
            int columns = 3;
            int[,] table = new int[rows, columns];
            //int[,] table = new int[2, 3];

            // auto-initialize 2 dimensional array
            int[,] autoInitTable = new int[,] { { 5, 3, 1 }, { 2, 4, 6 } };

            // array with 3 elements that are each an array
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5, 6 };
            jagged[2] = new int[] { 7, 8, 9 };

            // accessing elements in arrays
            int[] numbers = new int[] { 3, 5, 2, 0 };
            Console.WriteLine($"The 4th element in numbers array:  {numbers[3]}");
            Console.WriteLine($"The 2nd column in the 1st row of autoInitTable:  {autoInitTable[0, 1]}");
            Console.WriteLine($"The 3rd column in the 2nd row of autoInitTable:  {autoInitTable[1, 2]}");
            Console.WriteLine($"The 2nd element in the 3rd jagged array:  {jagged[2][1]}");
            //changing value in array
            numbers[3] = 9;
            Console.WriteLine($"The 4th element in numbers array is now:  {numbers[3]}");

            //looping thru array
            int sum = 0; // keep running total
            Console.WriteLine("\nLooping thru array with for loop and getting sum.");
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.WriteLine($"i={i} = {numbers[i]}, current sum={sum}");
            }
            Console.WriteLine($"Final sum: {sum}");

            Console.WriteLine("\nLooping thru array with foreach loop and getting sum.");
            sum = 0;
            foreach (int numb in numbers)
            {
                sum += numb;
                Console.WriteLine($"x = {numb}, current sum={sum}");
            }
            Console.WriteLine($"Final sum: {sum}");

            ////what happens when we access an element not in array
            ////try
            ////{
            //    int numbFromArray1 = numbers[2];
            //    int numbFromArray2 = numbers[5];
            //    Console.WriteLine($"Lets display our 2 ints:  {numbFromArray1}, {numbFromArray2}");
            ////}
            ////catch(IndexOutOfRangeException ex)
            ////{
            ////    Console.WriteLine($"\n{ex.Message}");
            ////}
        }

        private static void StringsAreCharArrays()
        {
            string str = "Hello big world!";
            string backwardsStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                // print string backwards
                backwardsStr += str[i];
            }
            Console.WriteLine(backwardsStr);

            //// invalid, strings are immutable and cannot be changed
            //str[3] = 'a';
        }

        private static void FormattingOutput()
        {
            string name = "Kaladan";
            int age = 29;
            string message1 = string.Format("Hi {0}, you are {1} years old", name, age);
            Console.WriteLine("Using string.Format():  \n{0} \n{0} \nOoops!!  We have a dupe!!", message1);

            decimal formattedNumb = 1234.567m;
            string message2 = string.Format("\nGeneral Decimal: {0:G}\nCurrency:  {0:C}\nFixed Format:  {0:F}" +
                "\nFixed Format with Commas:  {0:N1}\nPercentage:  {0:P}\nExponential Notation:  {0:E}", formattedNumb);
            Console.WriteLine(message2);

            // left align two 10-character values 
            // then right align a 10 character value in currency format
            // putting a space and literal pipe character in between
            string format = "{0,-10} | {1,-10} | {2,10:C}";
            Console.WriteLine("\nFirst Name | Last Name  | Balance");
            Console.WriteLine("====================================");

            Console.WriteLine(format, "Bob", "Jones", 101.25M);
            Console.WriteLine(format, "Mary", "Moore", 2100.53M);
            Console.WriteLine(format, "Susan", "Smith", 563.77);
        }

        private static void StringMethods()
        {
            //Replace is case sensitive
            string message1 = "Wow and wow!!";
            string message2 = message1.Replace("w", "p");
            Console.WriteLine(message1 + "\n" + message2 + "\n");

            string message3 = "I love to read!";
            string message4 = $"The message is:  {message3}\nThe length of message is:  {message3.Length}" +
                $"\nThe message contains 'read': {message3.Contains("read")}\nRemove everything " +
                $"after love:  {message3.Remove(6)}\nAll uppercase:  {message3.ToUpper()}";
            Console.WriteLine(message4);

            string message5 = "\nWe need to only display, Life is good, from this message! Use substring!!";
            Console.WriteLine(message5);
            Console.WriteLine(message5.Substring(26, 12));

            //use split to get the words without puctuation - chars use single quotes
            char[] delimiters = { ',', '!', '.', ' ' };
            string[] words = message5.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            //using Join()
            string[] names = { "Nestor", "Navani", "Kaladan", "Jasnah", "Shallon", "Dalanar" };
            Console.WriteLine("\n" + string.Join(",", names));
            Console.WriteLine(string.Join("|", names));
        }

    }
}
