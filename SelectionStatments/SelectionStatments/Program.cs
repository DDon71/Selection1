// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Number guessing game
var r = new Random();
//var favNumber = r.Next(1, 1000);
//var userInput = int.Parse(Console.ReadLine());
var favNumber = 500;

Console.WriteLine("Pick a number from 1 - 1000");
var userInput = int.Parse(Console.ReadLine());

if(userInput < favNumber)
{
    Console.WriteLine($"{userInput} is too low");
}
else if(userInput > favNumber)
{
    Console.WriteLine($"{userInput} is too high");
}
else
{
    Console.WriteLine("You guessed it");
}