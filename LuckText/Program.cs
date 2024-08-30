string name;


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Skriv in ditt namn: ");

name = Console.ReadLine();

string food;
Console.WriteLine("Favorit mat: ");

food = Console.ReadLine();

string sport;
Console.WriteLine("Favorit sport: ");

sport = Console.ReadLine();
Console.Clear();    
Console.WriteLine($"Hello my name is {name} and i like to eat {food} while i watch {sport} in my bed");

Console.ReadLine();

