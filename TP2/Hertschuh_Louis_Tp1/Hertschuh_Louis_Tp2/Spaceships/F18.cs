using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class F18 : Spaceship, IAbility
{
    public F18() : base(1, 0)
    {
        this.Name = "F18";
    }

    public void UseAbility(List<Spaceship> spaceships)
    {
        // Trouver la position du F-18 et du vaisseau joueur
        int myIndex = spaceships.IndexOf(this);
        int playerIndex = spaceships.FindIndex(s => s.BelongsPlayer); // suppose qu’on a une propriété IsPlayer dans Spaceship

        if (playerIndex == -1)
            return; // aucun joueur trouvé

        // Vérifier si le F-18 est "au contact" du joueur
        if (myIndex == playerIndex - 1 || myIndex == playerIndex + 1)
        {
            Console.WriteLine($"{Name} est au contact du joueur ! 💥 Il explose !");
            
            // Infliger 10 dégâts au joueur
            Spaceship player = spaceships[playerIndex];
            player.TakeDamages(10);

            // Supprimer le F-18 (explosé)
            spaceships.RemoveAt(myIndex);

            Console.WriteLine($"Le joueur subit 10 points de dégâts !");
        }
        else
        {
            Console.WriteLine($"{Name} est trop loin du joueur. Aucun effet.");
        }
    }
}           