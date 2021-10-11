using System;

namespace RockPaperScissors
{
    class Program
    {

        static void Main(string[] args)
        {


            int roundCount = 0;
            int[] winner; //Wins, Losses, Ties
            Random r = new Random();
            do
            {
                winner = new int[3] { 0, 0, 0 }; //Ties, Wins, Losses

                if (!PromptRounds(out roundCount))
                {
                    break;
                }
                if (roundCount < 1 || roundCount > 10)
                {
                    break;
                }

                for (int i = 0; i < roundCount; i++)
                {
                    winner[PlayRound(r)]++;
                }
                EndingStats(winner);
                PrintResultTable(winner);



            } while (PlayAgain());

            Console.WriteLine("Goodbye!");
        }

        static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                return false;
            }
        }

        static bool PromptRounds(out int roundCount)
        {
            Console.WriteLine("How many rounds would you like to play? Enter 1-10");
            return int.TryParse(Console.ReadLine(), out roundCount);
        }

        static int PlayRound(Random r)
        {
            int playerChoice = 0;



            Console.Write("Enter 1 for Rock, 2 for Paper, or 3 for Scissors: ");
            string playerInput = Console.ReadLine();
            if (!int.TryParse(playerInput, out playerChoice))
            {
                Console.WriteLine("That wasn't a number. I'll pick");
                //playerChoice = r.Next(1, 4);
            }
            else if (playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("That's not a valid choice. I'll pick");
                //playerChoice = r.Next(1, 4);
            }


            int compChoice = r.Next(1, 4);
            return WhoWon(playerChoice, compChoice);
        }


        static int WhoWon(int player, int computer)
        {

            Console.Write("Player: ");
            WriteChoice(player);
            Console.Write("Computer: ");
            WriteChoice(computer);

            //0 tie, 1 player win, 2 comp win.

            ValidMoves computerMove = (ValidMoves)computer;
            ValidMoves playerMove = (ValidMoves)player;

            if (player == computer)
            {
                Console.WriteLine("Tie");
                return 0;
            }

            else if (playerMove == ValidMoves.Rock)
            {
                if (computerMove == ValidMoves.Scissors)
                {
                    Console.WriteLine("Rock breaks Scissors to win");
                    return 1;
                }
                if (computerMove == ValidMoves.Paper)
                {
                    Console.WriteLine("You loose");
                    return 2;
                }
                else
                {
                    Console.WriteLine("You loose");
                    return 2;
                }
            }
            else if (playerMove == ValidMoves.Paper)
            {
                if (computerMove == ValidMoves.Rock)                  // problem here, says
                {
                    Console.WriteLine("Paper covers rock to win");
                    return 1;
                }
                if (computerMove == ValidMoves.Scissors)
                {
                    Console.WriteLine("You loose");
                    return 2;
                }
                else
                {
                    Console.WriteLine("You loose");
                    return 2;
                }
            }
            else if (playerMove == ValidMoves.Scissors)
            {
                if (computerMove == ValidMoves.Paper)
                {
                    Console.WriteLine("Scissors cut Paper to win");
                    return 1;
                }
                if (computerMove == ValidMoves.Rock)
                {
                    Console.WriteLine("you loose");
                    return 2;
                }
                else
                {
                    Console.WriteLine("you loose");
                    return 2;
                }
            }

            else

                return 0;
        }

        static void WriteChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Rock");
                    break;
                case 2:
                    Console.WriteLine("Paper");
                    break;
                case 3:
                    Console.WriteLine("Scissors");
                    break;
            }
        }

        static void EndingStats(int[] results)
        {
            if (results.Length != 3)
            {

                Console.WriteLine("Something went wrong");
                return;
            }
            Console.WriteLine("The results are in!");
            if (results[1] == results[2])
            {
                Console.WriteLine($"It\'s a tie at {results[1]} win(s) each!");

                return;
            }
            else
            {
                Console.WriteLine("The winner is....!");
                Console.Write("The ");
                int winningScore = 0;

                if (results[1] > results[2])
                {
                    Console.Write("Player");
                    winningScore = results[1];
                }
                else
                {
                    Console.Write("Computer");
                    winningScore = results[2];
                }
                Console.WriteLine($", with {winningScore} win(s)!");

            }
        }

        static void PrintResultTable(int[] results)
        {
            if (results.Length != 3)
            {
                Console.WriteLine("Something went seriously wrong.");
                return;
            }
            Console.WriteLine("|Ties------|Player----|Computer--|");
            Console.Write("|");
            foreach (int score in results)
            {
                Console.Write("{0,-10}|", score);
            }
            Console.WriteLine();
        }
    }


    public enum ValidMoves
    {
        Rock,
        Paper,
        Scissors
    }
}


////BETTER EXAMPLE  ALL IN THE MAIN METHOD

//Random random = new Random();

//while (true)
//{
//    Console.WriteLine("Hi. Welcome to Rock Paper Scissors.");
//    Console.Write("How many rounds would you like to play between 1 and 10? ");
//    string inputRounds = Console.ReadLine();

//    if (int.TryParse(inputRounds, out int numberOfRounds))
//    {
//        if (1 <= numberOfRounds && numberOfRounds <= 10)
//        {
//            int computerWins = 0;
//            int userWins = 0;
//            int numberOfTies = 0;

//            for (int i = 1; i <= numberOfRounds; i++)
//            {

//                Console.Write("Please choose: 1 = Rock, 2 = Paper, 3 = Scissors:\n");
//                string userSelection = Console.ReadLine();
//                if (int.TryParse(userSelection, out int userChoice))
//                {
//                    if (1 <= userChoice && userChoice <= 3)
//                    {
//                        int compChoice = random.Next(1, 4);

//                        if (userChoice == compChoice)
//                        {
//                            Console.WriteLine("We made the same choice. Tie");
//                            numberOfTies++;
//                        }
//                        else if (userChoice == 1 && compChoice == 2)
//                        {
//                            Console.WriteLine("You chose rock. I chose paper. I win");
//                            computerWins++;
//                        }
//                        else if (userChoice == 1 && compChoice == 3)
//                        {
//                            Console.WriteLine("You chose rock. I chose scissors. You win.");
//                            userWins++;
//                        }
//                        else if (userChoice == 2 && compChoice == 1)
//                        {
//                            Console.WriteLine("You chose paper. I chose rock. You win.");
//                            userWins++;
//                        }
//                        else if (userChoice == 2 && compChoice == 3)
//                        {
//                            Console.WriteLine("You chose paper. I chose scissors. I win.");
//                            computerWins++;
//                        }
//                        else if (userChoice == 3 && compChoice == 1)
//                        {
//                            Console.WriteLine("You chose scissors. I chose rock. I win.");
//                            computerWins++;
//                        }
//                        else if (userChoice == 3 && compChoice == 2)
//                        {
//                            Console.WriteLine("You chose scissors. I chose paper. You win.");
//                            userWins++;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Please enter a number 1 - 3.");
//                        computerWins++;
//                    }
//                }
//                else  // if user fails to enter a number when asked to choose 1, 2 or 3:
//                {
//                    Console.WriteLine("Please enter a number 1 - 3.");
//                    continue;
//                }
//            }
//            Console.WriteLine($"User wins = {userWins}. Computer Wins = {computerWins}. Ties = {numberOfTies}.");

//            Console.Write("Would you like to play again (y/n)?\n");
//            string replay = Console.ReadLine().ToLower();

//            if (String.IsNullOrEmpty(replay) || replay.ToLower() == "n")
//            {
//                Console.WriteLine("Thanks for playing!");
//                break;
//            }
//            else
//            {
//                continue;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a number 1 - 10.\n");
//            continue;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Please enter a number.\n");
//        continue;
//    }
//}
//Console.ReadLine();




////////BETTER EXAMPLE THAT USES METHODS
///
//class Program
//{
//    static int ties = 0;
//    static int userWin = 0;
//    static int compWin = 0;

//    static void Main(string[] args)
//    {
//        StartTheGame();
//    }

//    static void StartTheGame()
//    {
//        PlayTheGameCore(HowManyRounds());
//        PlayAgain();
//    }

//    static int GenerateComputerChoice()
//    {
//        Random r = new Random();
//        return r.Next(1, 4);
//    }

//    static int HowManyRounds()
//    {
//        Console.Write("How many rounds do you want to play? (1-10) ");
//        if (int.TryParse(Console.ReadLine(), out int userChoice))
//        {
//            if (userChoice > 0 && userChoice < 11)
//            {
//                return userChoice;
//            }
//            Console.WriteLine("ERROR: The number was not between 1 to 10");
//            return 0;
//        }
//        Console.WriteLine("ERROR: This is not a correct INT");
//        return 0;
//    }

//    static void PlayTheGameCore(int rounds)
//    {
//        for (int i = 0; i < rounds; i++)
//        {
//            Console.WriteLine("What is your choice?");
//            Console.WriteLine("1 = Rock");
//            Console.WriteLine("2 = Paper");
//            Console.WriteLine("3 = Scissors");

//            string strInput = Console.ReadLine();

//            if (!int.TryParse(strInput, out int userChoice) || userChoice < 1
//                || userChoice > 3)
//            {
//                Console.WriteLine("Please select 1 - 3.");
//                i--;
//                continue;
//            }

//            string winner;
//            int compChoice = GenerateComputerChoice();

//            if ((userChoice == 1 && compChoice == 3) || (userChoice == 2
//                && compChoice == 1) || (userChoice == 3 && compChoice == 2))
//            {
//                winner = "User";
//                userWin++;
//            }
//            else if ((userChoice == 1 && compChoice == 2) || (userChoice == 2
//                && compChoice == 3) || (userChoice == 3 && compChoice == 1))
//            {
//                winner = "Computer";
//                compWin++;
//            }
//            else
//            {
//                winner = "Tie";
//                ties++;
//            }

//            Console.WriteLine($"User chose:   {userChoice} | Computer chose:  {compChoice}");
//            Console.WriteLine($"WINNER: {winner}! ");
//            Console.WriteLine($"Ties:{ties} | User Wins: {userWin} | " +
//                $"Computer Wins: {compWin}\n");
//        }
//    }

//    static void PlayAgain()
//    {
//        Console.Write("Do you want to play again? (y/n)");
//        string userPlayAgain = Console.ReadLine();
//        if (userPlayAgain.ToLower().Equals("y"))
//        {
//            StartTheGame();
//        }
//        else if (userPlayAgain.ToLower().Equals("n"))
//        {
//            Console.WriteLine("Thank you for playing!");
//            Console.ReadLine();
//        }
//        else PlayAgain();
//    }
//}



//In this lab, you will write a program that plays the game Rock, Paper, Scissors.

//Your Task List:

//    Create a flowchart.
//    Show your flowchart to your instructor.
//    After receiving approval for your flowchart, begin writing code.

//Rules

//The rules of the game are as follows:

//    Each player chooses Rock, Paper, or Scissors.
//    If both players choose the same thing, the round is a tie.
//    Otherwise:
//        Paper wraps Rock to win
//        Scissors cut Paper to win
//        Rock breaks Scissors to win

//Requirements

//This program will be a C# Console Application called RockPaperScissors.

//    The program first asks the user how many rounds he/she wants to play.
//        Maximum number of rounds = 10, minimum number of rounds = 1.If the user asks for something outside this range, the program prints an error message and quits.
//        If the number of rounds is in range, the program plays that number of rounds.Each round is played according to the requirements below.
//    For each round of Rock, Paper, Scissors, the program does the following:
//        The computer asks the user for his/her choice (Rock, Paper, or Scissors).
//            Hint: 1 = Rock, 2 = Paper, 3 = Scissors
//        After the computer asks for the user's input, the computer randomly chooses Rock, Paper, or Scissors and displays the result of the round (tie, user win, or computer win).
//            Hint: use the Random class.
//    The program must keep track of how many rounds are ties, user wins, or computer wins.
//        Hint: Create three variables to keep track of these items and update them correctly after each round.
//    The program must print out the number of ties, user wins, and computer wins and declare the overall winner based on who won more rounds.
//    After all rounds have been played and the winner declared, the program must ask the user if he/she wants to play again.
//        If the user says No, the program prints out a message saying, “Thanks for playing!” and then exits.
//        If the user says Yes, the program starts over, asking the user how many rounds he/she would like to play.

