using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements;

internal class Class
{
    public static void Guess(int userInput, int guess)
    {
        if (userInput < guess)
        {
            Console.WriteLine("too low");
        }

        else if (userInput > guess)
        {
            Console.WriteLine("too high");
        }
        else
        {
            Console.WriteLine("You guessed it!!!");
        }

    }

    //Exercise 2

    public static void FavSubject(string userInputs)
    {
        switch (userInputs.ToLower())
        {
            case "math":
                Console.WriteLine($"{userInputs} is my favorite subject too!");
                break;
            case "science":
                Console.WriteLine($"Ah, {userInputs}. Good luck with Physics.");
                break;
            case "history":
                Console.WriteLine($"For me, {userInputs} was only fun when I wasn't learning it in school.");
                break;
            case "english":
                Console.WriteLine($"{userInputs} was fun only when I had good teachers.");
                break;
            case "music":
                Console.WriteLine($"I really enjoyed {userInputs} class in elementary school so I joined the school band until high school.");
                break;
            default:
                Console.WriteLine($"That's great. What are other subjects that you like?");
                break;

        }
    }
}

