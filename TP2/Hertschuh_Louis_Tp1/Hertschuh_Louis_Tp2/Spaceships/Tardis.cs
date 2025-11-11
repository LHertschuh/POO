using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class Tardis : Spaceship, IAbility
{
    public Tardis() : base(1, 0)
    {
        this.Name = "Tardis";
    }

    public void UseAbility(List<Spaceship> spaceships)
    {
        Random random = new Random();

        if (spaceships.Count < 2)
            return;

        Spaceship target;
        do
        {
            target = spaceships[random.Next(spaceships.Count)];
        } while (target == this);

        int newIndex = random.Next(spaceships.Count);

        int oldIndex = spaceships.IndexOf(target);

        spaceships.RemoveAt(oldIndex);

        if (newIndex > oldIndex) newIndex--;

        spaceships.Insert(newIndex, target);
 
    }
}           