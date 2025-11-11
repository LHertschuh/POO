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
        weapons.Add(new Weapon("Laser", 2,3,EWeaponType.Direct, 2));
        weapons.Add(new Weapon("Hammer", 1,8,EWeaponType.Explosive, 1.5));
        weapons.Add(new Weapon("Torpille", 3,3,EWeaponType.Guided, 2));
        weapons.Add(new Weapon("Mitrailleuse", 6,8,EWeaponType.Direct, 1));
        weapons.Add(new Weapon("EMG", 1,7,EWeaponType.Explosive, 1.5));
        weapons.Add(new Weapon("Missile", 4,100,EWeaponType.Guided, 4));
        
        
    }

    public void ViewArmory()
    {
        Console.WriteLine("===== Armurerie =====");
        foreach (Weapon weapon in weapons)
        {
            Console.WriteLine($"Nom: {weapon.Name} | Dégâts: {weapon.MinDamage} - {weapon.MaxDamage} | Type: {weapon.Type}");
        }
        
    }
}

