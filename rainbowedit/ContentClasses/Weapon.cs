namespace RainbowEdit;

public class Weapon
{
    public string Name
    {
        get; private set;
    }
    public WeaponType Type
    {
        get; private set;
    }
    public FiringMode FireMode
    {
        get; private set;
    }
    public int Damage
    {
        get; private set;
    }
    public int RoundsPerMinute
    {
        get; private set;
    }
    public int Capacity
    {
        get; private set;
    }
    public Sight Sights
    {
        get; private set;
    }
    public Barrel Barrels
    {
        get; private set;
    }
    public Grip Grips
    {
        get; private set;
    }
    public bool Underbarrel
    {
        get; private set;
    }
    public int SuppressedDamage
    {
        get; private set;
    }
    public int ExtendedBarrelDamage
    {
        get; private set;
    }
    public int DamagePerSecond
    {
        get; private set;
    }
    public TimeSpan ReloadTactical
    {
        get; private set;
    }
    public TimeSpan ReloadEmpty
    {
        get; private set;
    }
    public bool IsSecondary
    {
        get; private set;
    } = false;

    /// <summary>
    /// The multiplier that is applied to a weapon's base damage when equipping a <see cref="Barrel.Suppressor"/> on it. This is not defined anywhere and resulted from averaging the ratios from all weapons a <see cref="Barrel.Suppressor"/> can be equipped on (<c>suppressed_dmg / dmg</c>). Typically, using <c>0.84</c> yields a close enough approximate.
    /// 
    /// The calculated value is then rounded towards the nearest integer.
    /// 
    /// As of Y7S3, the <see cref="Barrel.Suppressor"/>'s damage reduction has been removed. As such, the multiplier applied to damage when calculating suppressed damage is <c>1</c>. For compatibility reasons, a <see cref="Weapon"/> instance's <see cref="SuppressedDamage"/> remains and its value is still calculated.
    /// </summary>
    public const decimal SuppressedDamageMultiplier = 1M; // 0.837697879481015
    /// <summary>
    /// The multiplier that is applied to a weapon's base damage when equipping an <see cref="Barrel.ExtendedBarrel"/> on it. Defined as 15% on top of the <see cref="Weapon"/>'s base damage as part of the Y7S2 Designer's notes (https://store.steampowered.com/news/app/359550/view/5254045511872530857).
    /// </summary>
    public const decimal ExtendedBarrelDamageMultiplier = 1.15M; // 0.837697879481015

    public enum WeaponType
    {
        AssaultRifle,
        Handgun,
        LightMachineGun,
        MachinePistol,
        MarksmanRifle,
        Shield,
        ShotgunSlug,
        ShotgunShot,
        Shotgun = ShotgunShot + ShotgunSlug,
        SubmachineGun,
        HandCannon
    }

    public enum FiringMode
    {
        None,
        FullAuto,
        SingleShot
    }

    /// <summary>
    /// Indicates which sights can be or are forcefully equipped on the weapon.
    /// 
    /// As of Y7S1, all weapons (excepting most secondaries and, for example, Glaz's "OTs-03" DMR, which does not have access to Reflex C) have access to all non-magnifying scopes (Red Dot, Holo, Reflex), or more precisely, all of their variants (no matter if standard, Russian, alternate etc.). Because of this, I've decided to combine them. Checking for magnifying scopes still works as before.
    /// However, as mentioned above, exceptions such as Glaz's "OTs-03" DMR, which cannot be equipped with Reflex C, are not (yet?) handled differently.
    /// Additionally, since there are two 2.5x scope variants, the two options for  that magnification level have also been combined.
    /// 
    /// As of Y7S3, all weapons that have access to scopes of a specific magnification level now automatically have access to all magnifications levels up to that level (excepting Kali's "CSRX 300"). Because of this, the <see cref="Sights"/> flags have been redefined to act as maximums. Use <see cref="Enum.HasFlag(Enum)"/> for any look-ups.
    /// </summary>
    public enum Sight
    {
        Invalid = 0,
        None = 1,
        NonMagnifying = 3,
        OnePointFive = 7,
        Two = 15,
        TwoPointFive = 31,
        Three = 63,
        SixTwelve = 127,
        Other = 128
    }

    [Flags]
    public enum Barrel
    {
        None = 0,
        Suppressor = 1,
        FlashHider = 2,
        Compensator = 4,
        MuzzleBrake = 8,
        ExtendedBarrel = 16
    }

    [Flags]
    public enum Grip
    {
        None = 0,
        VerticalGrip = 1,
        AngledGrip = 2
    }

    [Flags]
    public enum Gadget
    {
        FragGrenade = 1,
        BreachCharge = 2,
        Claymore = 4,
        HardBreachCharge = 8,
        SmokeGrenade = 16,
        StunGrenade = 32,
        EmpGrenade = 64,

        BarbedWire = 128,
        DeployableShield = 256,
        NitroCell = 512,
        BulletproofCamera = 1024,
        ProximityAlarm = 2048,
        ImpactGrenade = 4096
    }

    internal Weapon(string name, WeaponType type, FiringMode fireMode, int damage, int roundsPerMinute, int capacity, Sight sights, Barrel barrels, Grip grips, bool underbarrel, int reloadTactical, int reloadEmpty)
    {
        Name = name;
        Type = type;
        FireMode = fireMode;
        Damage = damage;
        RoundsPerMinute = roundsPerMinute;
        Capacity = capacity;
        Sights = sights;
        Barrels = barrels;
        Grips = grips;
        Underbarrel = underbarrel;
        ReloadTactical = TimeSpan.FromMilliseconds(reloadTactical);
        ReloadEmpty = TimeSpan.FromMilliseconds(reloadEmpty);

        if (Type is WeaponType.Handgun or WeaponType.MachinePistol or WeaponType.HandCannon
            || Name is "ITA12S" or "Super Shorty" or "Bailiff 410")
        {
            IsSecondary = true;
        }

        SuppressedDamage = (int)Math.Round(Barrels.HasFlag(Barrel.Suppressor) ? Damage * SuppressedDamageMultiplier : 0);
        ExtendedBarrelDamage = (int)Math.Round(Barrels.HasFlag(Barrel.ExtendedBarrel) ? Damage * ExtendedBarrelDamageMultiplier : 0);
        if (!Type.HasFlag(WeaponType.Shield))
        {
            try
            {
                DamagePerSecond = (int)(Damage * Capacity / (((decimal)ReloadTactical.TotalSeconds) + (Capacity / (RoundsPerMinute / 60M))));
            }
            catch
            {
                DamagePerSecond = 0;
            }
        }
    }

    public override string ToString() => Name;
    public static implicit operator string(Weapon wep) => wep.ToString();

    public static Weapon? Resolve(string name) => Game.DefAtk.SelectMany(op => op.Primaries.Concat(op.Secondaries)).First(wep => wep.Name.Contains(name, StringComparison.OrdinalIgnoreCase) || wep.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    public WeaponConfiguration GetRandomConfiguration() => new(this);
}
