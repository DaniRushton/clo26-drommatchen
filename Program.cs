using System.Runtime.CompilerServices;

public class Spelare
{
    private string _namn;
    private string _position;
    private int _nummer;

    public string Namn
    {
        get { return _namn; }
        private set { _namn = value; }
    }
    public string Position
    {
        get { return _position; }
        private set { _position = value; }
    }
    public int Nummer
    {
        get { return _nummer; }
        private set { _nummer = value; }
    }

    public Spelare(string namn, string position, int nummer) //startvärden
    {
        // spara startvärden permanent i objektets fält 
        _namn = namn;
        _position = position;
        _nummer = nummer;
    }

}

public class Match
{
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    public string Hemmalag
    {
        get { return _hemmalag; }
        private set { _hemmalag = value; }
    }
    public string Bortalag
    {
        get { return _bortalag; }
        private set { _bortalag = value; }
    }
    public string Datum
    {
        get { return _datum; }
        private set { _datum = value; }
    }

    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
    }
    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} - {Datum}");
    }
}