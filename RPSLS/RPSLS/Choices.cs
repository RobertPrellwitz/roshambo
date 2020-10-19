using System;
using System.Collections.Generic;

namespace RPSLS
{ 
    public class Choices
    {
        public int selection;
        public List<string> playOptions;
        public Choices()
        {
        
            playOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            
        }

        //public void SelectPlay()
        //{
        //    Console.WriteLine("Please Select your play for this round");
        //    for (int i = 0; i < playOptions.Count; i++)
        //    {
        //        Console.WriteLine(i + " " + playOptions[i]);
        //        selection = Convert.ToInt32(Console.ReadLine());

        //    }
        //}
    }
}
