using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.Write("Enter a magic number: ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        
        int magicGuess = -1;

        while (magicGuess != magicNumber)
        {
            Console.Write("What is your guess?");
            magicGuess = int.Parse(Console.ReadLine());
            
            if (magicGuess > magicNumber)
            {
                Console.Write("Lower. Guess again. ");
            }
            else if (magicGuess < magicNumber)
            {
                Console.Write("Higher. Guess again. ");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }



    }
}