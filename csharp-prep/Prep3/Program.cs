using System;

class Program
{
    static void Main(string[] args)
    {
        //getting the magic number
        Console.WriteLine(" What is your magic number? " );
        int magicNumber = int.Parse(Console.Readline());

        // now using a random number

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        //alternative to use a do whileloop

        while (guess!= magicNumber)
    }

    {

        // getting the guess from user

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        // using loops to know whether its higher or lower
        
        if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}





    }
}