// Skapar två nya spelare

Spelare spelare1 = new("Alexia Putellas", "Forward", 9);
Spelare spelare2 = new("Aitana Bonmatí", "Midfielder", 6);

//En match mellan London City Lionesses och Barcelona

Match match = new("London City Lionesses", "Barcelona", "16e September 2026");

// Presentera dagens match

match.Presentera();
match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2); 