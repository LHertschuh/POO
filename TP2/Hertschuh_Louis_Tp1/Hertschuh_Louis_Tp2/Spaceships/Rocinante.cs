using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class Rocinante : Spaceship
{
    public Rocinante() : base(3, 5)
    {
        this.Name = "Rocinante";
        Weapons.Add(new Weapon("Torpille", 3,3,EWeaponType.Guided, 2));
        
    }
    
    public new void TakeDamages(double damages)
    {
        Random random = new Random();
        if (random.Next(0, 2) == 0)
        {
            return;
        }
        CurrentShield = CurrentShield - damages;
        if (CurrentShield == 0)
        {
            CurrentStructure += CurrentShield;
            CurrentShield = 0;
        }
    }

}           