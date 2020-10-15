using System;
using System.Collections.Generic;
namespace RPSLS
{
    public class Player
    {
        // Memmber variable
       
        public int score;
        //public Choices select;

        public Player()
        {
            score = 0;
        }
    }

    public class Human : Player
    {
        public string name;
        public Human()
        {
            //name = "player";
        }
    }

    public class Computer : Player
    {
        public Computer()
        {

        }
    }
}
