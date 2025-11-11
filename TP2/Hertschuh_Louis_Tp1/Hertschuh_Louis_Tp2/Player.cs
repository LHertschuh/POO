using System.Runtime.CompilerServices;

namespace Hertschuh_Louis_Tp1;

public class Player
{
    private string firstName { get; set; }
    private string lastName { get; set; }
    private string alias { get; set; }
    public string name { get; set; }
    public Spaceship ship { get; private set; }

    public Player(string firstName, string lastName, string alias)
    {
        this.firstName = FormatString(firstName);
        this.lastName = FormatString(lastName);
        this.alias = alias;
        this.name = string.Format("{0} {1}", this.firstName, this.lastName);
        ship = new Rocinante();
    }

    private static string FormatString(string nom)
    {
        return string.Format("{0}{1}",char.ToUpper(nom[0]),nom.Substring(1).ToLower());
    }

    public override string ToString()
    {
        return string.Format("{0} ({1})", this.alias, this.name);  
    }

    public override bool Equals(object? obj)
    {
        return obj.ToString() == this.ToString();
    }
    
    
}           