using System;
using System.Collections.Generic;
namespace RPSLS
{
    public abstract class Player
    {
        // Memmber variable
        public string name;
        public int score;
        public string gesture;
        public Choices choices;
        //public Choices select;


        public Player()
        {
            choices = new Choices();
            score = 0;
            gesture = "";
        }

        public abstract void SetName();

        public abstract string ChooseGesture();
    }

    public class Human : Player
    {
        
        public Human()
        {
            
        }

        public override void SetName()
        {
            Console.WriteLine("Please enter in your name");
            name = Console.ReadLine();
        }
        public override string ChooseGesture()
        {
            Console.WriteLine("Please Select your play for this round\n" +
                "use the number next to the desired option to play");
            for (int i = 0; i < choices.playOptions.Count; i++)
            {
                Console.WriteLine(i + " " + choices.playOptions[i]);

            }
            int temp; //= Convert.ToInt32(Console.ReadLine());

            bool check = Int32.TryParse(Console.ReadLine(), out temp);
            if (check)
            {
                string gesture = choices.playOptions[temp];

                return gesture;
            }
            else
            {
                Console.WriteLine("You inadvertently selected an incorrect play! \n" +
                    "Please try selecting from the list again.");
                return ChooseGesture();
            }
        }
    }

    public class Computer : Player
    {
        public Computer()
        {

        }
        public override void SetName()
        {
            name = "AMD Ryzen 9";
        }
        public override string ChooseGesture()
        {
            Random rand = new Random();
            int temp = rand.Next(4);
            gesture = choices.playOptions[temp];
            return gesture;
        }
    }
}
