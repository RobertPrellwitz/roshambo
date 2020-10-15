using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Game
    {
        // Member variables
        public Choices choices;
        public Player player1;
        public Player player2;
        public string player1Play;
        public string player2Play;
        public int player1Score;
        public int player2Score;

        public Game()
        {
            choices = new Choices();
            player1 = new Human();
        }


        public Player PlayerType()
        {
            Console.Clear();
            Console.WriteLine("Do you want to play a game against the player1 or a friend");
            Console.WriteLine("Enter 1 for Single Player Mode and 2 for Two player mode");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                Console.WriteLine("You have selected Single Player, Good Luck");
                player2 = new Computer();
                return player2;
            }
            else if (temp == 2)
            {
                player2 = new Human();
                return player2;
            }
            else
            {
                Console.WriteLine("You did not make a valid selection of '1' or '2', try again");
                PlayerType();
                return null;
                PlayerType(); /// how to start PlayerType over if no valid selection??
            }

        }
        public void GetPlayerName()
        {
            Console.WriteLine("please Enter your name");

            //player1.name = Console.ReadLine();

            //if (player2 == Human) {
            //Player.player2.name = Console.ReadLine}
        }

        public string Selection()
        {
           // Console.Clear();
            Console.WriteLine("Please Select your play for this round");
            for (int i = 0; i < choices.playOptions.Count; i++)
            {
                Console.WriteLine(i + " " + choices.playOptions[i]);

            }
            int temp = Convert.ToInt32(Console.ReadLine());
            string word = choices.playOptions[temp];
            return word;

        }
        public void Player1Turn()
        {
            player1Play = Selection();
            
        }

        public void Player2Turn()
        {
            // if player 2 is human then
            // player2play = selection90;
            Random rand = new Random();
            int temp = rand.Next(4);
            player2Play = choices.playOptions[temp];
            
        }


        // compare selections
        public void Comparison()

        {
            Console.WriteLine("player 1 plays " + player1Play);
            Console.WriteLine("player 2 plays" + player2Play);

            if (player1Play == player2Play)
            {
                Console.WriteLine("its a tie");
            }
            else if (player1Play == "Rock" & (player2Play == "Scissors" || player2Play == "Lizard")) {
                Console.WriteLine("player1 wins\n");
                player1Score = player1Score + 1;
            }

            else if (player1Play == "Scissors" & (player2Play == "Paper" || player2Play == "Lizard"))
            {
                Console.WriteLine("player1 wins\n");
                player1Score = player1Score + 1;

            }
            else if (player1Play == "Paper" & (player2Play == "Rock" || player2Play == "Spock"))
            {
                Console.WriteLine("player1 wins\n");
                player1Score = player1Score + 1;

            }
            else if (player1Play == "Lizard" & (player2Play == "Paper" || player2Play == "Spock"))
            {
                Console.WriteLine("player1 wins\n");
                player1Score = player1Score + 1;
            }
            else if (player1Play == "Spock" & (player2Play == "Scissors" || player2Play == "Rock"))
            {
                Console.WriteLine("player1 wins\n");
                player1Score = player1Score + 1;
            }
            else
            {
                Console.WriteLine(player2 + " Wins\n");
                player2Score = player2Score + 1;
            }
            //if (player1Score > player2Score)
            //{
            //    Console.WriteLine(player1 + "wins");
            //}
            //else
            //{
            //    Console.WriteLine(player2 + "wins");
            //}
          
        }
        public void RunGame()
        {
            while(player1Score<3 & player2Score < 3)
            {
                if (player1Score==3 || player2Score == 3)
                {
                    break;
                }
                Player1Turn();
                Player2Turn();
                Comparison();
            }

        }


    }
}
		





    

   

