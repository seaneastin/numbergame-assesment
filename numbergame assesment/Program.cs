using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbergame_assesment
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            int minnumber = 1; //min numbers starting value
            int realmaxnumber = 101; //this is set 1 higher than the actual value because random will never reach the top value
            int fakemaxnumber = 100; //this is what console displays
            int guess = 0;
            bool guessing = true;
            bool validanswer = false;
            string playerchoice = "0";
            Console.WriteLine("Think of a number between " + minnumber + " and " + fakemaxnumber); //must minus one as it is accualy from 0 and 100
            Console.WriteLine("when you are done please press a key to continue");
            Console.ReadKey();
            while (guessing)
            {
                validanswer = false;
                guess = random.Next(minnumber, realmaxnumber);
                while (!validanswer)
                {                    
                    Console.WriteLine("is this your number " + guess);
                    Console.WriteLine("pick an option using numbers");
                    Console.WriteLine("1: this is the number i was thinking of");
                    Console.WriteLine("2: the number is greater than the guess");
                    Console.WriteLine("3: the number is less than the guess");
                    playerchoice = Console.ReadLine();
                    if (playerchoice == "1")
                    {
                        Console.WriteLine("computer has guessed your number");
                        Console.ReadKey();
                        guessing = false;
                        validanswer = true;
                    }
                    else if (playerchoice == "2")
                    {
                        minnumber = guess;
                        validanswer = true;
                    }
                    else if (playerchoice == "3")
                    {
                        realmaxnumber = guess + 1;
                        validanswer = true;
                    }
                }
            }

        }
    }
}
