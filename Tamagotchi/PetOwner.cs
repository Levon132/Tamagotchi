namespace Tamagotchi;
using System;
using System.Collections.Generic;

public class PetOwner
{
    // Ägarens namn och instansen av Tamagotchi
    private string name;
    private Tamagotchi pet;

    // Konstruktor för att göra att ägaren får namn och tamagotchin
    public PetOwner(string ownerName, Tamagotchi tamagotchi)
    {
        name = ownerName;
        pet = tamagotchi;
    }

    // Kontrollera Tamagotchins nuvarande status
    public void CheckStatus()
    {
        Console.WriteLine($"Statuscontrol {name}:");
        pet.PrintStats();
    }

    // gör så att ägaren kan mata tamagotchi
    public void FeedTamagotchi()
    {
        Console.WriteLine($"{name} feeds {pet.Name}.");
        pet.Feed();
    }

    // Leka med Tamagotchi
    public void PlayWithTamagotchi()
    {
        Console.WriteLine($"{name} plays {pet.Name}.");
        pet.Hi();
    }

    // Tiden går för Tamagotchi
    public void PassTime()
    {
        Console.WriteLine($"{name} lets time pass by");
        pet.Tick();
    }
}




