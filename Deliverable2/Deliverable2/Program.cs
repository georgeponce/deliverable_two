using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //declare variables
        string headsOrTailsGuess;
        var numberOfFlips = 0;
        float correctCount;
        var heads = 0;
        var tails = 0;
        Random coinflip = new Random();
        //ask user to guess heads or tails
        Console.WriteLine("Guess which will have more: heads or tails?");
        headsOrTailsGuess = Console.ReadLine();
        //ask user how many times to flip coin
        Console.WriteLine("How many times shall we flip a coin?");
        numberOfFlips = Convert.ToInt32(Console.ReadLine());
        //create break between #of coin flips and results
        Console.WriteLine();
        //coinflip and list of results
        for (var i = 0; i < numberOfFlips; i++)
        {
            var flip = coinflip.Next(1, 3);
            if (flip == 1)
            {
                heads++;
                Console.WriteLine("heads", i);
            }
            else
            {
                tails++;
                Console.WriteLine("tails", i);
            }
        }
        //correctCount if statement
        if (headsOrTailsGuess == "heads")
        {
            correctCount = heads;
        }
        else
        {
            correctCount = tails;
        }
        // if statement telling user how many times their guess came up and percentage
        if (headsOrTailsGuess == "heads")
        {
            //create break between end of results and next statement and percentage
            Console.WriteLine();
            Console.WriteLine("You're guess, " + headsOrTailsGuess
               + ", came up " + heads + " time(s).");
            Console.WriteLine("That's " + (correctCount / numberOfFlips * 100) + "%.");
        }
        else
        {
            //create break between end of results and next statement
            Console.WriteLine();
            Console.WriteLine("You're guess, " + headsOrTailsGuess
               + ", came up " + tails + " time(s).");
            Console.WriteLine("That's " + (correctCount / numberOfFlips * 100) + "%.");
        }
    }
}