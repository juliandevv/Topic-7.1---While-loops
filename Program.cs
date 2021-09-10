using System;

namespace Topic_7._1___While_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Julian

            double balance; //users coins
            bool run = true; //main game loop condition
            bool betting = true; //betting game loop condition
            int game = 1; //stores the round number
            double bet = 0; //stores the users bet
            int uInput1, uInput2; //various user inputs
            Random generator = new Random(); //rand genertaor
            int flipResult, guess; //stores random number, stores users guess

            Console.WriteLine("Welcome to coinmaster 4030! To begin, press enter");//starting text
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("To get started I am giving you 30 free coins. Use them wisely.");
            balance = 30; //updates users coins
            Console.WriteLine("Current balance = " + balance); //displays users balance
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Alright now that you have some coins to play with, lets get started!");
            Console.WriteLine("I am going to roll a dice and you have to try and guess the result.");
            Console.WriteLine("If you are correct, I will add your bet to your balance and if you lose, I'll subtract it.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            while (run == true) //main game loop
            {
                Console.WriteLine("====================Round " + game + "=================="); //displays round number
                Console.WriteLine();

                while (betting == true)//betting screen
                {
                    Console.WriteLine("What will you wager on this dice roll?");
                    bet = Convert.ToDouble(Console.ReadLine());

                    if (bet >= balance)
                    {
                        bet = balance;
                    }

                    else if (bet <= 0)
                    {
                        bet = 1;
                    }

                    Console.WriteLine("You are about to bet " + bet); //confirms users bet
                    Console.WriteLine("1. Confirm  2.Bet again");
                    uInput1 = Convert.ToInt32(Console.ReadLine());

                    if (uInput1 == 1)
                    {
                        betting = false;
                    }

                    else if (uInput1 == 2)
                    {

                    }

                    else
                    {
                        Console.WriteLine("That is not an option!");
                    }
                }

                Console.WriteLine("What number do you think the die will reveal?");
                guess = Convert.ToInt32(Console.ReadLine()); //stores users guess
                Console.WriteLine("I will now roll the die. Cross your fingers!");
                Console.WriteLine();
                flipResult = generator.Next(1, 7); //rolls the die
                
                if (guess == flipResult)
                {
                    Console.WriteLine("Congratulations! you have correctly guessed the die roll. The result was " + flipResult + "."); //user guesses correctly
                    Console.WriteLine("You win " + bet + " coins");
                    balance = balance + bet;
                    Console.WriteLine("Current balance = " + balance); //displays users balance

                    Console.WriteLine();
                    Console.WriteLine("Would you like to play again?"); //prompts user to play again or quit
                    Console.WriteLine("1.Yes  2.No");
                    uInput2 = Convert.ToInt32(Console.ReadLine());

                    if (uInput2 == 1)
                    {
                        betting = true;
                        ++game;
                    }

                    else
                    {
                        run = false;
                    }
                }

                else
                {
                    Console.WriteLine("Sorry, you have not correctly guessed the die roll. The result was " + flipResult + "."); //user guesses incorrectly
                    Console.WriteLine("You lose " + bet + " coins");
                    balance = balance - bet;
                    
                    if (balance == 0)
                    {
                        Console.WriteLine("You ran out of coins!"); //user runs out of coins and game closes
                        run = false;
                    }

                    else
                    {
                        Console.WriteLine("Current balance = " + balance);


                        Console.WriteLine();
                        Console.WriteLine("Would you like to play again?");
                        Console.WriteLine("1.Yes  2.No");
                        uInput2 = Convert.ToInt32(Console.ReadLine());

                        if (uInput2 == 1)
                        {
                        betting = true;
                        ++game;
                        }

                        else
                        {
                        run = false;
                        }
                    }
                    

                }

               
            }

            Console.WriteLine("===================Game over====================");
        }
    }
}
