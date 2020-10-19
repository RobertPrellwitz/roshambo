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
        public int gameLength;
        
        public Game()
        {
            choices = new Choices();
            player1 = new Human();   
        }

        public Player PlayerType()
        {
            //Console.Clear();
            Console.WriteLine("Do you want to play a game against the computer or a friend");
            Console.WriteLine("Enter 1 for Single Player Mode and 2 for Two player mode");
            int temp;
            bool check = Int32.TryParse(Console.ReadLine(),out temp);
            if (check)
            {
                if (temp == 1)
                {
                    Console.WriteLine("You have selected Single Player, Good Luck!");
                    player2 = new Computer();
                    return player2;
                }
                else if (temp == 2)
                {
                    Console.WriteLine("You have selected multi-player mode, Good Luck Puny Humans!");
                    player2 = new Human();
                    return player2;
                }
                else
                {
                    Console.WriteLine("You did not make a valid selection of '1' or '2', try again");
                    PlayerType();
                    return null;

                }
            }
            else
            {
                Console.WriteLine("You did not make a valid selection of '1' or '2', try again");
                PlayerType();
                return null;
                
            }

        }
        public int GameLength()  // can also run as void and eliminte the return null doesn't work
        {
            Console.WriteLine("The game is generally best of three, however you can choose any option you\n" +
                "would like. For example best of 7 would require a player to win 4 rounds.  Please input any \n" +
                "integer you would like to customize your game.");
          
            bool check = Int32.TryParse(Console.ReadLine(), out gameLength);
            if (check)
            {
                return gameLength;
            }
            else
            {
                return GameLength();
               
            }
        }
        
        public string Selection()
        {
           // Console.Clear();
            Console.WriteLine("Please Select your play for this round");
            for (int i = 0; i < choices.playOptions.Count; i++)
            {
                Console.WriteLine(i + " " + choices.playOptions[i]);

            }
            int temp;
            bool check = Int32.TryParse(Console.ReadLine(), out temp);
            if (check)
            {
                string word = choices.playOptions[temp];
                return word;
            }
            else
            {
                return Selection();
            }

        }
        public void Player1Turn()
        {
            player1Play = player1.ChooseGesture();
            
        }

        public void Player2Turn()
        {
            
            player2Play = player2.ChooseGesture();
            
        }


        // compare selections
        public void Comparison()

        {
            Console.WriteLine($"{player1.name} plays {player1Play} ");
            Console.WriteLine($"{player2.name} plays {player2Play} ");

            if (player1Play == player2Play)
            {
                Console.WriteLine("its a tie");
            }
            else if (player1Play == "Rock" & (player2Play == "Scissors" || player2Play == "Lizard")) {
                Console.WriteLine($"{player1.name} wins\n");
                player1.score = player1.score + 1;
            }

            else if (player1Play == "Scissors" & (player2Play == "Paper" || player2Play == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins\n");
                player1.score = player1.score + 1;

            }
            else if (player1Play == "Paper" & (player2Play == "Rock" || player2Play == "Spock"))
            {
                Console.WriteLine($"{player1.name} wins\n");
                player1.score = player1.score + 1;

            }
            else if (player1Play == "Lizard" & (player2Play == "Paper" || player2Play == "Spock"))
            {
                Console.WriteLine($"{player1.name} wins\n");
                player1.score = player1.score + 1;
            }
            else if (player1Play == "Spock" & (player2Play == "Scissors" || player2Play == "Rock"))
            {
                Console.WriteLine($"{player1.name} wins\n");
                player1.score = player1.score + 1;
            }
            else
            {
                Console.WriteLine($"{player2.name} wins\n");
                player2.score = player2.score + 1;
            }
                      
        }
        public void RunGame()
        {
            player1.SetName();
            player2.SetName();
            while(player1.score < (gameLength/2+1) & player2.score < (gameLength / 2 + 1))
            {
                if (player1.score== (gameLength / 2 + 1) || player2.score == (gameLength / 2 + 1))
                {
                    break;
                }
                Player1Turn();
                Player2Turn();
                Comparison();
            }
            if (player1.score > player2.score) {
                Console.WriteLine($"{player1.name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{player2.name} wins the game!");
            }
        }
       


    }
}
		





    

   

