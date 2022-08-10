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
}
