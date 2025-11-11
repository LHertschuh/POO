using System.Runtime.CompilerServices;

namespace Hertschuh_Louis_Tp1;

public class SpaceInvader
{
    public List<Player> joueurs = [];
    public List<Spaceship> ennemis = [];
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
            while (joueur.ship.IsDestroyed == false)
            {
                jeu.PlayRound(joueur);
            }
            
        }
        

    }

    private void Init()
    {
        joueurs.Add(new Player("damso", "le deuxieme", "dems"));
        joueurs.Add(new Player("Citroen", "xm", "xm"));
        joueurs.Add(new Player("Louis", "Hertschuh", "LHER"));
        
        armurerie.ViewArmory();
        
        ennemis.Add(new BWings());
        ennemis.Add(new Dart());
        ennemis.Add(new F18());
        ennemis.Add(new Rocinante());
        ennemis.Add(new Tardis());
        ennemis.Add(new ViperMKII());
        
        
    }

    private void PlayRound(Player joueur)
    {
        foreach (var e in ennemis.Where(e => !e.IsDestroyed))
        {
            e.RepairShield(2);
            
        }
        
        joueur.ship.RepairShield(2);
        
        
        foreach (var e in ennemis.Where(e => !e.IsDestroyed))
        {
            e.ShootTarget(joueur.ship);
            e.ViewShip();
            
        }
        
    }
}           