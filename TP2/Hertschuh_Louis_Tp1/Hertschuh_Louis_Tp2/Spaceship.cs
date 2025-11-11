using System.Runtime.CompilerServices;
using Models;

namespace Hertschuh_Louis_Tp1;

public abstract class Spaceship : ISpaceship
{
    public string Name { get; set; }
    public double Structure { get; set; }
    public double Shield { get; set; }
    public int MaxWeapons { get; }
    public List<Weapon> Weapons { get; }
    public double AverageDamages { get; }
    public double CurrentStructure { get; set; }
    public double CurrentShield { get; set; }
    public bool BelongsPlayer { get; }
    public int MaxStructure { get; set; }
    public int MaxShield { get; set; }

    public void TakeDamages(double damages)
    {
        
        CurrentShield = CurrentShield - damages;
        if (CurrentShield == 0)
        {
            CurrentStructure += CurrentShield;
            CurrentShield = 0;
        }

    }

    public void RepairShield(double repair)
    {
        CurrentShield = CurrentShield + repair;
        if (CurrentShield > MaxShield)
        {
            CurrentShield = MaxShield;
        }
    }

    public void ShootTarget(Spaceship target)
    {
        if(Weapons.First()!=null )
        target.TakeDamages(Weapons.First().Shoot());
    }

    public void ReloadWeapons()
    {
        foreach (Weapon wep in Weapons)
        {
            wep.ReloadWeapon();
        }
    }


   

    
    public Spaceship(int maxStructure, int maxShield)
    {
        this.MaxStructure = maxStructure;
        CurrentStructure = maxStructure;
        this.MaxShield = maxShield;
        CurrentShield = maxShield;
        this.Weapons = new List<Weapon>();
    }

    public void AddWeapon(Weapon weapon)
    {
        if (Weapons.Count < MaxWeapons)
        {
            Weapons.Append(weapon);
            
        }
    }
    
    public void RemoveWeapon(Weapon oWeapon)
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            if (Weapons[i] == oWeapon)
            {
                Weapons[i] = null;
                return;
            }
        } 
    }

    public void ClearWeapons()
    {
            Weapons.Clear();
         
    }

    public void ViewWeapons()
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            if (Weapons[i] != null)
            {
                Console.WriteLine(Weapons[i].Name);
                
            }
        } 
    }
/*
    public double AverageDamages()
    {
        double total = 0;
        int count = 0;

        foreach (var weapon in Weapons)
        {
            if (weapon != null)
            {
                total += (weapon.MinDamage + weapon.MaxDamage) / 2.0;
                count++;
            }
        }

        if (count == 0)
            return 0;

        return total;
    }*/
    
    public bool IsDestroyed
    {
        get { return CurrentStructure <= 0; }
    }

    public void ViewShip()
    {
        Console.WriteLine("===== Vaisseau =====");
        Console.WriteLine($"Structure: {CurrentStructure}/{MaxStructure}");
        Console.WriteLine($"Bouclier: {CurrentShield}/{MaxShield}");
        ViewWeapons();
    }

}           