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
            Console.WriteLine("Please eneter in your name human!");
            name = Console.ReadLine();
        }
        public override string ChooseGesture()
        {
            Console.WriteLine("Please Select your play for this round");
            for (int i = 0; i < choices.playOptions.Count; i++)
            {
                Console.WriteLine(i + " " + choices.playOptions[i]);

            }
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 0 && temp <= 4)
            {
                string gesture = choices.playOptions[temp];
            }
            else { 
                Console.WriteLine("that is an invalid selection - please use and integer from 0 - 4");
                    ChooseGesture();
                 
            }
         
            //string gesture = choices.playOptions[temp];
            return gesture;
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
