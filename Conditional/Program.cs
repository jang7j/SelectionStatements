using SelectionStatements;

var r = new Random();
var guess = r.Next(1, 1000);

Console.WriteLine("Guess the number: ");
var userInput = int.Parse(Console.ReadLine());

Class.Guess(userInput, guess);


