// Skapar två nya spelare

Spelare spelare1 = new("Alexia Putellas", "Forward", 9, 0);
Spelare spelare2 = new("Aitana Bonmatí", "Midfielder", 6, 2);

//En match mellan London City Lionesses och Barcelona

Match match = new("London City Lionesses", "Barcelona", "16e September 2026");

// Presentera dagens match

match.Presentera();
match.AnnounceraMålskytt(spelare2);
match.AnnounceraMålskytt(spelare2);

Console.WriteLine($"Är Alexia matchjälten? {match.ÄrMatchhjälte(spelare1)}");
Console.WriteLine($"Är Aitana matchjälten? {match.ÄrMatchhjälte(spelare2)}");