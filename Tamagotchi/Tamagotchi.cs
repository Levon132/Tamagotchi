namespace Tamagotchi;
using System;
using System.Collections.Generic;

public class Tamagotchi
{
    // Olika egenskaper hos Tamagotchi
    protected int hunger;
    private int boredom;
    private List<string> words;
    private bool isAlive;
    private Random generator;
    private string name;

    // Hämta och sätta Tamagotchins namn
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Konstruktor för att göra så att tamagotchi får dessa värden.
    public Tamagotchi(string tamagotchiName)
    {
        Name = tamagotchiName;
        hunger = 0;
        boredom = 0;
        words = new List<string>();
        isAlive = true;
        generator = new Random();
    }

    // Tamagotchis stats
    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Alive: {isAlive}");
    }

    //  Mata Tamagotchi
    public void Feed()
    {
        Console.WriteLine("Im less hungry now");
        hunger--;

        ReduceBoredom();
    }

    // Tamagotchi säger något
    public void Hi()
    {
        if (words.Count > 0)
        {
            int r = generator.Next(words.Count);
            Console.WriteLine($"{Name} says: {words[r]}");

            ReduceBoredom();
        }
        else
        {
            Console.WriteLine($"{Name} does not know any words yet.");
        }
    }

    // Lära Tamagotchi ett nytt ord
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    // Uppdatera Tamagotchins egenskaper
    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger == 10 || boredom == 10)
        {
            isAlive = false;
        }
    }

    // Kontrollera om Tamagotchi fortfarande är vid liv
    public bool GetAlive()
    {
        return isAlive;
    }

    // Minska boredom
    private void ReduceBoredom()
    {
        boredom--;
    }
}