using System;
public class Tamagotchi
{
    private int hunger;

    private int boredom;
    private List<string> words = new();
    private bool isAlive;
    private Random generator;

    public string name;

    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Alive: {isAlive}");
    }
    public void Feed()
    {
        Console.WriteLine("Im now less hungry");
        hunger--;

    }

    public void Hi()
    {
        Random generator = new Random();

        int r = generator.Next(words.Count);
        Console.WriteLine(words[r]);

        ReduceBoredom();
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger == 10)
        {
            isAlive = false;
        }
        if (boredom == 10)
        {
            isAlive = false;
        }


    }
    public bool GetAlive()
    {
        return true;
    }
    private void ReduceBoredom()
    {

        boredom--;
    }
}

