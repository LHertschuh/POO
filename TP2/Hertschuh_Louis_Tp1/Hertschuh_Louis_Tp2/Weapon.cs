using SpaceInvadersArmory;

namespace Hertschuh_Louis_Tp1;

public class Weapon : IWeapon
{
    public double MaxDamage { get; set; }
    public double AverageDamage { get; }
    public double TimeBeforReload { get; set; }
    public bool IsReload { get; private set; }
    public double ReloadTime { get; set; }
    
    
    public string Name {  get;  set; }
    public double MinDamage { get; set; }
    public EWeaponType Type { get; set; }
    

    public Weapon(string name, double minDamage, double maxDamage, EWeaponType weaponType, double reloadTime)
    {
        this.Name = name;
        this.MinDamage = minDamage;
        this.MaxDamage = maxDamage;
        this.Type = weaponType;
        this.ReloadTime = ReloadTime;
        this.TimeBeforReload = ReloadTime; // -> faire -1 à chaque tour
        this.IsReload = false;

    }

    public double Shoot()
    {
        if (ReloadTime != 0)
        {
            return 0;
        }

        TimeBeforReload = ReloadTime;
        Random random = new Random();
        if (Type == EWeaponType.Direct &&  random.Next(0, 10) == 0)
        {
            return 0;
        }

        if (Type == EWeaponType.Explosive )
        {
            if( random.Next(0, 4) == 0)
            {
                return 0;  
            }
            else
            {
                return Damage() * 2;
            }
        }
        if(Type == EWeaponType.Explosive)
        {
            return MinDamage;
        }
        return random.NextDouble() * (MaxDamage - MinDamage) + MinDamage;
    }

    private double Damage()
    {
        Random random = new Random();
        return random.NextDouble() * (MaxDamage - MinDamage) + MinDamage;
    }

    public void ReloadWeapon()
    {
        if (IsReload == false)
        {
            TimeBeforReload--;
        }
        if (TimeBeforReload == 0)
        {
            IsReload = true;
        }
    }

    
}