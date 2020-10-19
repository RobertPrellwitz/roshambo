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

        
    }
}
