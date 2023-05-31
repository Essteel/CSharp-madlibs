Console.WriteLine("What is your name?");
var nameInput = Console.ReadLine();
var playerName = nameInput.Trim();

Console.WriteLine("Please give a mode of transport:");
var transportInput = Console.ReadLine();
var transport = transportInput.Trim();

Console.WriteLine("Please give an out of the way travel destination:");
var destinationInput = Console.ReadLine();
var destination = destinationInput.Trim();

Console.WriteLine("Please give an adverb:");
var adverbInput = Console.ReadLine();
var adverb = adverbInput.Trim();

Console.WriteLine("Please give a plural noun:");
var nounInput = Console.ReadLine();
var noun = nounInput.Trim();

Console.WriteLine("What is your favourite mythical creature?");
var creatureInput = Console.ReadLine();
var creature = creatureInput.Trim();

Console.WriteLine("Please give a superpower:");
var superpowerInput = Console.ReadLine();
var superpower = superpowerInput.Trim();

Console.WriteLine($"{playerName} went on a quest to find the last {creature} of {destination}.");
Console.WriteLine($"{playerName} took the {transport} to {destination} and was sitting {adverb} by themself, when suddenly, hundreds of {noun} appeared and used their secret power of {superpower}.");
Console.WriteLine($"{playerName} was so surprised that they forgot all about their quest, got the next {transport} home and lived happily ever after.");