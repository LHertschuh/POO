namespace Hertschuh_Louis_Tp1;

public class Weapon
{
    public string name {  get; private set; }
    public int minDamage { get; private set; }
    public int maxDamage { get; private set; }
    public EWeaponType weaponType { get; private set; }

    public Weapon(string name, int minDamage, int maxDamage, EWeaponType weaponType)
    {
        this.name = name;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.weaponType = weaponType;
    }
}