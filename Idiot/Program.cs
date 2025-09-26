using Idiot;

Console.WriteLine("Name your thingie");
Tamagoshi ahhh = new Tamagoshi(Console.ReadLine());

while (ahhh.GetAlive())
{
    Console.WriteLine($"What do you do with {ahhh.name}");
    Console.WriteLine($"- Talk - Feed - teach - stats - nothing -");
    string action = Console.ReadLine();
    if (action.ToLower() == "feed")
    {
        ahhh.Feed();
    }
    else if (action.ToLower() == "teach")
    {
        Console.WriteLine($"What word to teach to {ahhh.name}?");
        ahhh.Teach(Console.ReadLine());
    }
    else if (action.ToLower() == "talk")
    {
        ahhh.Hi();
    }
    else if (action.ToLower() == "stats")
    {
        ahhh.PrintStats();
    }
    ahhh.Tick();
}