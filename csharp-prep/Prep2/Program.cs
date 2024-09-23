using System;

class Program
{
    static void Main(string[] args)
    {

        string letter = "";
        Console.Write("What percentage did you score? : ");
        string score = Console.ReadLine();

        int percentage = int.Parse(score);

        int lastDigit = percentage % 10;
        
        if(percentage >= 90)
        {
            letter = "A";
        }
        else if(percentage >= 80)
        {
            letter = "B";
        }
        else if(percentage >= 70)
        {
            letter = "C";
        }
        else if(percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (lastDigit >= 7)
        {
            if (letter == "A" || letter =="F")
            {
                Console.WriteLine($"You scored a/an {letter}");
            }
            else
            {
                Console.WriteLine($"You scored a/an {letter}+");
            }
            
        }

        else if(lastDigit <= 3)
        {

            if (letter == "F")
            {
                Console.WriteLine($"You scored a/an {letter}");
            }
            
            else{
                Console.WriteLine($"You scored a/an {letter}-");
            }
            
        }

        else
        {
            Console.WriteLine($"You scored a/an {letter}");
        }

        
        if(percentage >= 70)
        {
            Console.Write("Congratulation! you passed the course");
        }

        else
        {
            Console.Write("Oouchh! You failed. You can do better next time");
        }
    }
}