using System;

namespace MenuOfChampions
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizza;
            int strawberryPie;
            int denverOmlet;
            int menu;

            pizza = (int)(decimal)500.00m;
            strawberryPie = (int)(decimal)2.00m;
            denverOmlet = (int)(decimal)1.50m;

            menu = pizza + strawberryPie + denverOmlet;

            Console.WriteLine(@"WELCOME TO RESTAURANT NIGHT VALE!
Todays's Menu Is...


""$"" pizza) ;

        }
    }
}
