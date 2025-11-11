using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class ViperMKII : Spaceship
{
    public ViperMKII() : base(10, 15)
    {
        this.Name = "ViperMKII";
        Weapons.Add(new Weapon("Mitrailleuse", 6,8,EWeaponType.Direct, 1));
        Weapons.Add(new Weapon("EMG", 1,7,EWeaponType.Explosive, 1.5));
        Weapons.Add(new Weapon("Missile", 4,100,EWeaponType.Guided, 4));


    }
}           