namespace Hertschuh_Louis_Tp1;

public class Armory
{
    private List<Weapon> weapons { get; set; }

    public Armory()
    {
        Init();
    }

    private void Init()
    {
        weapons = new List<Weapon>();
        weapons.Add(new Weapon("Direct", 5,15,EWeaponType.Direct));
        weapons.Add(new Weapon("Explosive", 25,55,EWeaponType.Explosive));
        weapons.Add(new Weapon("Guided", 2,7,EWeaponType.Guided));
    }

    public void ViewArmory()
    {
        Console.WriteLine("===== Armurerie =====");
        foreach (Weapon weapon in weapons)
        {
            Console.WriteLine($"Nom: {weapon.name} | Dégâts: {weapon.minDamage} - {weapon.maxDamage} | Type: {weapon.weaponType}");
        }
        
    }
}

