using System;
using System.Collections.Generic;

namespace RPSLS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // welcome amd game explanation
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizzard, Spock");
            Console.WriteLine("Game play is as follows: \nScissors cuts Paper\n  " +
                "Paper covers Rock\nRock crushes Lizard\nLizard poisons Spock" +
                "\nSpock smashes Scissors\nScissors decapitates Lizard\n"+
                "Lizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n"+
                "(and as it always has!) \nRock crushes Scissors");


            // select one or two player
           

            Game play = new Game();
            play.PlayerType();
            play.RunGame();

        }
    }
}
