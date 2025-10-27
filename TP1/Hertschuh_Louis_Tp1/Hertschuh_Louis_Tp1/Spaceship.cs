using System.Runtime.CompilerServices;

namespace Hertschuh_Louis_Tp1;

public class Spaceship
{
    private int maxStructure { get; set; }
    private int maxShield { get; set; }
    private int currentShield { get; set; }
    private int currentStructure { get; set; }

    private Weapon[] weapons { get; set; } 
    
    public Spaceship(int maxStructure, int maxShield)
    {
        this.maxStructure = maxStructure;
        currentStructure = maxStructure;
        this.maxShield = maxShield;
        currentShield = maxShield;
        this.weapons = new Weapon[3];
    }

    public void AddWeapon(Weapon weapon)
    {
        if (weapons.Length < 3)
        {
            weapons.Append(weapon);
            
        }
    }
    
    public void RemoveWeapon(Weapon oWeapon)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] == oWeapon)
            {
                weapons[i] = null;
                return;
            }
        } 
    }

    public void ClearWeapons()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i] = null;
        } 
    }

    public void ViewWeapons()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] != null)
            {
            Console.WriteLine(weapons[i].name);
                
            }
        } 
    }

    public double AverageDamages()
    {
        double total = 0;
        int count = 0;

        foreach (var weapon in weapons)
        {
            if (weapon != null)
            {
                total += (weapon.minDamage + weapon.maxDamage) / 2.0;
                count++;
            }
        }

        if (count == 0)
            return 0;

        return total;
    }
    
    public bool IsDestroyed
    {
        get { return currentStructure <= 0; }
    }

    public void ViewShip()
    {
        Console.WriteLine("===== Vaisseau =====");
        Console.WriteLine($"Structure: {currentStructure}/{maxStructure}");
        Console.WriteLine($"Bouclier: {currentShield}/{maxShield}");
        ViewWeapons();
    }

}           