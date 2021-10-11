using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI
{
    public static class Menu
    {
        public static void Start()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("SG Bank Application");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Lookup an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawl");

                Console.WriteLine("\nQ to quit");
                Console.Write("\nEnter Selection: ");

                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "Q":
                        return;
                }
            }

        }
    }
}
