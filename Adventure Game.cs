using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //story part 1:
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            string noiseChoice2 = noiseChoice.ToUpper();
            if (noiseChoice2 == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\n THE END.");
            }
            else if (noiseChoice2 == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\n You walk towards it. Do you open it or knock?");
            }
            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine().ToUpper();
            if (doorChoice == "KNOCK")
            {
                Console.Write("A voice behind the door speaks. It says, \"Answer this riddle: ",
                    "Poor people have it. Rich people need it. If you eat it you die. What is it?");
                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine().ToUpper();
                if (riddleAnswer == "NOTHING".ToUpper())
                {
                    Console.Write("The door opens and NOTHING is there. \n You turn off the light and run back to your room and lock the door. \n THE END.");
                }
                else
                {
                    Console.Write("You answered incorrectly. The door doesn't open. \n THE END.");
                }

            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine().ToUpper();
                switch (keyChoice)
                {
                    case "1":
                        Console.Write("You choose the first key. Lucky choice! \n The door opens and NOTHING is there. Strange... \n THE END.");
                        break;
                    case "2":
                        Console.Write("You choose the second key. The door doesn't open. \n THE END.");
                        break;
                    case "3":
                        Console.Write("You choose the third key. The door doesn't open. \n THE END.");
                        break;
                }
            }

        }
    }
}
