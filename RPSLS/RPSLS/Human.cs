using System;
namespace RPSLS
{
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
                if (temp >= 0 && temp <= 4)
                {

                    string gesture = choices.playOptions[temp];

                    return gesture;
                }
                else {
                    Console.WriteLine("You inadvertently selected an incorrect play! \n" +
                  "Please try selecting from the list again.");
                    return ChooseGesture();
                }
            }
            else
            {
                Console.WriteLine("You inadvertently selected an incorrect play! \n" +
                    "Please try selecting from the list again.");
                return ChooseGesture();
            }
        }
    }
}
