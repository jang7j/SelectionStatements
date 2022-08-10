using SelectionStatements;

var r = new Random();
var guess = r.Next(1, 1000);

Console.WriteLine("Guess the number: ");
var userInput = int.Parse(Console.ReadLine());

Class.Guess(userInput, guess);


//Exercise 2

Console.WriteLine("What is your favorite subject?");
var userInput2 = Console.ReadLine();
Class.FavSubject(userInput2);



