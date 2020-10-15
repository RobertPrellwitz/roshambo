using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Choices
    {
        List<string> options;
        public Choices()
        {
            options = new List<string>();
            options.Add("Rock");
            options.Add("Paper");
            options.Add("Scissors");
            options.Add("Lizard");
            options.Add("Spock");
        }
    }
}
