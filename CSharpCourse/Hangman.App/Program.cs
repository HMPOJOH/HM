using System;

namespace Hangman.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman!");

            var hangman = new Core.Hangman("MAMMA", 3);

            Console.Write("Your guess: ");
            string guess = Console.ReadLine();

            /*
             M  ==> Correct
             A ==> Correct
             MM ==> Invalid
             # ==> Invalid
             Q ==> Wrong
               ==> AlreadyGuessed
             
             */

            var result = hangman.Guess(guess);

            if (result == Core.GuessResult.IncorrectGuess)
            {
                Console.WriteLine("Incorrect!");
            } else if (result == Core.GuessResult.AlreadyGuessed)
            {
                Console.WriteLine("You've already guessed that letter");
            }

        }
    }
}
