using System;
using System.Threading;
namespace Part_5._5___Intro_To_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
            Console.WriteLine("Enter 1 for a joke, 2 for a dolphin, 3 for a rabbit, 4 for a horse, or 5 for a knock knock joke.");
            int menuInput;
            while (!int.TryParse(Console.ReadLine(), out menuInput));
            if (menuInput == 1)
            {
                Console.WriteLine("Enter a starting number of bottles");
                int startingBottles = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press ENTER for the joke.");
                Console.ReadLine();
                Joke(startingBottles);
            }
            if (menuInput == 2)
            {
                Thread.Sleep(1000);
                Dolphin();
            }
            if (menuInput == 3)
            {
                Thread.Sleep(1000);
                Rabbit();
            }
            if (menuInput == 4)
            {
                Thread.Sleep(1000);
                Horse();
            }
            if (menuInput == 5)
            {
                Console.WriteLine("Press ENTER for a knock knock joke.");
                Console.ReadLine();
                Thread.Sleep(1000);
                KnockKnock();
            }
                i = i + 2;
            }
        }
        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine(" Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }
        public static void Dolphin()
        {
            Console.WriteLine(@"                (`.              
                 \ `.           
                  )  `._..---._
\`.       __...---`         o  )
 \ `._,--'           ,    ___,'
  ) ,-._          \  )   _,-' 
 /,'    ``--.._____\/--''  ");
        }
        public static void Rabbit()
        {
            Console.WriteLine(@"     / \
    / _ \
   | / \ |
   ||   || _______
   ||   || |\     \
   ||   || ||\     \
   ||   || || \    |
   ||   || ||  \__/
   ||   || ||   ||
    \\_/ \_/ \_//
   /   _     _   \
  /               \
  |    O     O    |
  |   \  ___  /   |                           
 /     \ \_/ /     \
/  -----  |  --\    \
|     \__/|\__/ \   |
\       |_|_|       /
 \_____       _____/
       \     /
       |     |");
        }
        public static void Horse()
        {
            Console.WriteLine(@"                                 |\    /|
                              ___| \,,/_/
                           ---__/ \/    \
                          __--/     (D)  \
                          _ -/    (_      \
                         // /       \_ /  -\
   __-------_____--___--/           / \_ O o)
  /                                 /   \__/
 /                                 /
||          )                   \_/\
||         /              _      /  |
| |      /--______      ___\    /\  :
| /   __-  - _/   ------    |  |   \ \
 |   -  -   /                | |     \ )
 |  |   -  |                 | )     | |
  | |    | |                 | |    | |
  | |    < |                 | |   |_/
  < |    /__\                <  \
  /__\                       /___\");
        }
        public static void KnockKnock()
        {
            Console.Write("Knock knock...");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("You say: 'Who's there?'");
            Thread.Sleep(500);
            Console.Write("It's Joe");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("You say: 'Joe who?'");
            Thread.Sleep(1000);
            Console.WriteLine("JOE MOTHER");
        }
    }
}