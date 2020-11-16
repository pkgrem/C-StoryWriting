using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program creates a madlibs application in dotnet which allows a user to create their own mad story. 

      Author: Paddy Keogh Goode
      */

      // Let the user know that the program is starting:
      string intro = "The program is running...";
      Console.WriteLine(intro);


      // Give the Mad Lib a title:
      string title = "A story driven by user input";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name for the main character: ");
      string CharacterName = Console.ReadLine(); 

      Console.Write("List a first adjective: ");
      string adjective1 = Console.ReadLine(); 

      Console.Write("List a second adjective: ");
      string adjective2 = Console.ReadLine(); 

      Console.Write("List a third adjective: ");
      string adjective3 = Console.ReadLine(); 

      Console.Write("List a verb: ");
      string verb = Console.ReadLine(); 

      Console.Write("List a first noun: ");
      string noun1 = Console.ReadLine(); 

      Console.Write("List a second noun: ");
      string noun2 = Console.ReadLine(); 

      Console.Write("List an animal: ");
      string animal = Console.ReadLine(); 

      Console.Write("List a food: ");
      string food = Console.ReadLine(); 

      Console.Write("List a fruit: ");
      string fruit = Console.ReadLine(); 

      Console.Write("List a superhero: ");
      string superhero = Console.ReadLine(); 

      Console.Write("List a country: ");
      string country = Console.ReadLine(); 

      Console.Write("List a dessert: ");
      string dessert = Console.ReadLine(); 

      Console.Write("List a year: ");
      string year = Console.ReadLine(); 

      // The template for the story:
      string beginning = "The program is now running...";
      Console.WriteLine(beginning);

      string story = $"This morning {CharacterName} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {CharacterName} texted {superhero}, who flew {CharacterName} to {country} and dropped {CharacterName} in a puddle of frozen {dessert}. {CharacterName} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
