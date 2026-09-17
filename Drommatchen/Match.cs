public class Match
{
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }


    public Match(string hemmalag, string bortalag, string datum) //startvärden
    {
        // spara startvärden permanent i objektets fält 
        _hemmalag = hemmalag;
        Hemmalag = hemmalag;

        _bortalag = bortalag;
        Bortalag = bortalag;

        _datum = datum;
        Datum = datum;
    }

    public void Presentera() // Så man kan presentera vilka som spelar 
    {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} - {Datum}");
    }

    public void AnnounceraMålskytt(Spelare spelare) // Så man kan se vem som gör mål.
    {
        Console.WriteLine($"Mål gjordes av: Nr {spelare.Nummer} {spelare.Namn} som spelar som en {spelare.Position}");
    }
    public bool ÄrMatchhjälte(Spelare spelare) // Visar vem som är matchhjälte genom 1 eller fler mål
    {
        return spelare.Mål >= 1;
    }
}