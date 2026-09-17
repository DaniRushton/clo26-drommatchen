public class Spelare
{
    private string _namn;
    private string _position;
    private int _nummer;
    private int _mål;

    public string Namn      { get; private set; }
    public string Position  { get; private set; }
    public int Nummer       { get; private set; }
    public int Mål          { get; private set; }

    public Spelare(string namn, string position, int nummer, int mål) //startvärden
    {
        // spara startvärden permanent i objektets fält 
        _namn = namn;
        Namn  = namn;

        _position = position;
        Position  = position;

        _nummer = nummer;
        Nummer  =  nummer;

        _mål = mål;
        Mål = mål;
    }

}