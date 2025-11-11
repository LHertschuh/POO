using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public class Dart : Spaceship
{
    public Dart() : base(10, 3)
    {
        this.Name = "Dart";
        Weapons.Add(new Weapon("Laser", 2,3,EWeaponType.Direct, 2));
    }
}           