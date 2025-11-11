using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class BWings : Spaceship
{
    public BWings() : base(30, 0)
    {
        this.Name = "B-Wings";
        Weapons.Add(new Weapon("Hammer", 1,8,EWeaponType.Explosive, 1.5));
        
    }
}           