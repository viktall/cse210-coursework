using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int count = 0;
        int guessNum = -1;

        Console.Write("What is your guess? : ");
        
        while (guessNum != number)
        {

            guessNum = int.Parse(Console.ReadLine());

            if (guessNum < number)
            {
                Console.Write("Guess higher : ");
            }

            else if(guessNum > number)
            {
                Console.Write("Guess lower : ");
            }

            else
            {
                Console.WriteLine("You guessed correctly");
            }

            count += 1;
        }
          Console.WriteLine($"You made {count} guesses");  

        //   Console.Write("Would you like to try again? : ");
        //   string response = Console.ReadLine();

        //   if (response == "yes")
        //   {
        
        //   }
    }

        
}