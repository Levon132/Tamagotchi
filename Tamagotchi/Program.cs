namespace Tamagotchi;
using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        // Visa ett välkomstmeddelande
        Console.WriteLine("Welcome To Tamagotchi!");
        
        Console.WriteLine("Choose a name for your Tamagotchi.");
        
        // Be användaren välja ett namn för Tamagotchi
        string tamagotchiName = Console.ReadLine();

        // Skapa en instans av Tamagotchi- och PetOwner-klasserna
        Tamagotchi tama = new Tamagotchi(tamagotchiName);
        PetOwner owner = new PetOwner("Levon", tama);

        // Visa det valda Tamagotchins namn
        Console.WriteLine($"Your Tamagotchis name is {tama.Name}");

        // Interagera med Tamagotchi
        owner.PlayWithTamagotchi();
        owner.FeedTamagotchi();

        // Loop för att simulera tiden tills Tamagotchi inte längre är vid liv
        while (tama.GetAlive())
        {
            owner.PassTime();
            owner.CheckStatus();
            owner.FeedTamagotchi();
            owner.PlayWithTamagotchi();
            Console.ReadLine();
        }


        Console.WriteLine($"{tama.Name} has died, GAME OVER");


        Console.ReadLine();
    }
}
