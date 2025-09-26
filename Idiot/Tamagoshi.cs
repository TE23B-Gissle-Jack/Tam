using System;

namespace Idiot;

public class Tamagoshi
{
    // − hunger: int
    // − boredom: int
    // − words: List<string>
    // − isAlive: bool
    // + Name: string
    int hunger;
    int bordom ;
    List<string> words;
    bool isAlive;
    public String name;

    public Tamagoshi(String name)
    {
        this.name = name;
        this.words = new List<string>();
        this.bordom = 0;
        this.hunger = 0;
        this.isAlive = true;
    }




    //     + Feed(): void
    // + Hi(): void
    // + Teach(word: string): void
    // + Tick(): void
    // + PrintStats(): void
    // + GetAlive(): bool
    // − ReduceBoredom(): void

    public void Feed()
    {
        hunger -= 5;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }
    public void Hi()
    {
        if (words.Count > 0)
        {
            Console.WriteLine($"{name} says {words[Random.Shared.Next(words.Count)]}");
            ReduceBoredom();
        }
        else Console.WriteLine(name + " does not know any words"); 
    }
    public void Teach(string word)
    {
        Console.WriteLine($"you tought {name} {word}");
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        if (hunger >= 10 || bordom >= 10)
        {
            isAlive = false;
            Console.WriteLine(name + " died");
        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"Hunger:{hunger} Boredom: {bordom}");
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    void ReduceBoredom()
    {
        bordom -= 5;
        if (bordom<0)
        {
            bordom = 0;
        }
    }
}
