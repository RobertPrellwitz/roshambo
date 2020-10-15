using System;
using System.Collections.Generic;

namespace RPSLS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool computer;
            Console.WriteLine("Hello World!");

            // welcome amd game explanation
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizzard, Spock");
            Console.WriteLine("Game play is as follows: \n Scissors cuts Paper\n  " +
                "Paper covers Rock\n Rock crushes Lizard\n Lizard poisons Spock" +
                "\n Spock smashes Scissors\n Scissors decapitates Lizard\n"+
                "Lizard eats Paper \nPaper disproves Spock\n Spock vaporizes Rock\n"+
                "(and as it always has) Rock crushes Scissors");


            // select one or two player
            Console.WriteLine("Select 1 or 2 Player Game");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                computer = true;
            }
            computer = false;



            Game play = new Game();
            play.RunGame();

        }
    }
}
