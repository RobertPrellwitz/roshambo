using System;
namespace RPSLS
{
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
