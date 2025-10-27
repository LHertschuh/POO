using System.Runtime.CompilerServices;

namespace Hertschuh_Louis_Tp1;

public class SpaceInvader
{
    public List<Player> joueurs = [];
    public Armory armurerie ;
    public SpaceInvader()
    {
        armurerie = new Armory();
        Init();
        
        
    }

    public static void Main()
    {
        SpaceInvader jeu = new SpaceInvader();
        foreach (Player joueur in jeu.joueurs)
        {
            joueur.ship.ViewShip();
            Console.WriteLine(joueur.ToString());
        }
        

    }

    private void Init()
    {
        joueurs.Add(new Player("damso", "le deuxieme", "dems"));
        joueurs.Add(new Player("Citroen", "xm", "xm"));
        joueurs.Add(new Player("Louis", "Hertschuh", "LHER"));
        
        armurerie.ViewArmory();
        
        
    }
}           