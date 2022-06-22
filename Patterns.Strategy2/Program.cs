// See https://aka.ms/new-console-template for more information
using Patterns.Strategy2.Ducks;
using Patterns.Strategy2.DuckVoices;

Console.WriteLine("Hello duck!");

// the strategy pattern is all about having some common code and figuring out which bits need to vary in certain situations and 
// pulling those bits that can vary out into their own classes. The common code stays the same, the bits that vary are delt with
// by classes that a specific. This is a terrible explanation, but I understand it and I am too lazy to look at wikipedia for a better one. 

// This is the best pattern and I use it all the time; see MCP services

var paradiseDuck = new Duck(new Quacker());
var rubberDuck = new Duck(new Squeeker());
var mallardDuck = new Duck(new Quacker());
var whio = new Duck(new Whistle());

// these are all types of ducks, but they say different things. Rather than having an 'if then' or a switch statement in the duck class
// that determines what the duck should say based on what it is, we abstract out the bits of the duck that are different - in this case
// it is only the talking. When we compose/create the duck model we pass in something that will do the talking. This means we can have 
// the same class (the Duck class) doing different things as needed.

Console.WriteLine($"The Paradise Duck says {paradiseDuck.Talk()}");
Console.WriteLine($"The Rubber Duck says {rubberDuck.Talk()}");
Console.WriteLine($"The Mallard Duck says {mallardDuck.Talk()}");
Console.WriteLine($"The Whio says {whio.Talk()}");