namespace RainbowEdit;

/// <summary>
/// An <see cref="Operator"/>-specific <see cref="Weapon"/> in Siege.
/// </summary>
public class Weapon
{
    ///<summary>
    /// The <see cref="Operator"/> this <see cref="Weapon"/> belongs to.
    ///</summary>
    public Operator Source { get; internal set; }
    /// <summary>
    /// The in-game name of the <see cref="Weapon"/>.
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// The in-game <see cref="WeaponType"/> of the <see cref="Weapon"/>.
    /// </summary>
    public WeaponType Type { get; private set; }
    /// <summary>
    /// The in-game <see cref="FiringMode"/> the <see cref="Weapon"/> uses.
    /// </summary>
    public FiringMode FireMode { get; private set; }
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when <i>not</i> equipped with a <see cref="Barrel.ExtendedBarrel"/>.
    /// </summary>
    public int Damage { get; private set; }
    /// <summary>
    /// The rounds per minute this <see cref="Weapon"/> is capable of firing in-game.
    /// </summary>
    public int RoundsPerMinute { get; private set; }
    /// <summary>
    /// The in-game magazine capacity of this <see cref="Weapon"/>.
    /// </summary>
    /// <remarks>
    /// This does not include the single round chambered after cocking the <see cref="Weapon"/>.
    /// </remarks>
    public int Capacity { get; private set; }
    /// <summary>
    /// A combination of <see cref="Sight"/> values that specifies which sights may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Sight Sights { get; private set; }
    /// <summary>
    /// A combination of <see cref="Barrel"/> values that specifies which barrel extensions may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Barrel Barrels { get; private set; }
    /// <summary>
    /// A combination of <see cref="Grip"/> values that specifies which grips may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Grip Grips { get; private set; }
    /// <summary>
    /// Whether an underbarrel laser may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public bool Underbarrel { get; private set; }
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when equipped with a <see cref="Barrel.Suppressor"/>.
    /// </summary>
    [Obsolete($"{nameof(SuppressedDamage)} has been obsoleted by the ${nameof(Barrel.Suppressor)} rework in Y7S3, use {nameof(Damage)} instead.")]
    public int SuppressedDamage { get; private set; }
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when equipped with a <see cref="Barrel.ExtendedBarrel"/>.
    /// </summary>
    public int ExtendedBarrelDamage { get; private set; }
    /// <summary>
    /// The theoretical damage per second output of this <see cref="Weapon"/> during sustained fire.
    /// </summary>
    public int DamagePerSecond { get; private set; }
    /// <summary>
    /// A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform a tactical reload with this <see cref="Weapon"/> (a reload when there is a round chambered).
    /// </summary>
    public TimeSpan ReloadTactical { get; private set; }
    /// <summary>
    /// A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform an empty reload with this <see cref="Weapon"/> (a reload when there is no round chambered).
    /// </summary>
    public TimeSpan ReloadEmpty { get; private set; }
    /// <summary>
    /// Whether this <see cref="Weapon"/> is a secondary weapon.
    /// </summary>
    public bool IsSecondary { get; private set; } = false;

    /// <summary>
    /// The multiplier that is applied to a weapon's base damage when equipping a <see cref="Barrel.Suppressor"/> on it. This is not defined anywhere and resulted from averaging the ratios from all weapons a <see cref="Barrel.Suppressor"/> can be equipped on (<c>suppressed_dmg / dmg</c>). Typically, using <c>0.84</c> yields a close enough approximate. The calculated value is then rounded towards the nearest integer.
    /// </summary>
    [Obsolete($"{nameof(SuppressedDamage)} has been obsoleted by the ${nameof(Barrel.Suppressor)} rework in Y7S3. This is kept for compatibility reasons and is now defined as `1M`.")]
    public const decimal SuppressedDamageMultiplier = 1M; // 0.837697879481015
    /// <summary>
    /// The multiplier that is applied to a weapon's base damage when equipping an <see cref="Barrel.ExtendedBarrel"/> on it. Defined as 15% on top of the <see cref="Weapon"/>'s base damage as part of the Y7S2 Designer's notes (https://store.steampowered.com/news/app/359550/view/5254045511872530857).
    /// </summary>
    public const decimal ExtendedBarrelDamageMultiplier = 1.15M;

    /// <summary>
    /// Identifies the type of a <see cref="Weapon"/>.
    /// </summary>
    [Flags]
    public enum WeaponType
    {
        /// <summary>
        /// Identifies the Assaul Rifle weapon type.
        /// </summary>
        AssaultRifle = 1,
        /// <summary>
        /// Identifies the Handgun weapon type.
        /// </summary>
        Handgun = 2,
        /// <summary>
        /// Identifies the Light Machine Gun weapon type.
        /// </summary>
        LightMachineGun = 4,
        /// <summary>
        /// Identifies the Machine Pistol weapon type.
        /// </summary>
        MachinePistol = 8,
        /// <summary>
        /// Identifies the Marksman Rifle weapon type.
        /// </summary>
        MarksmanRifle = 16,
        /// <summary>
        /// Identifies the Shield weapon type.
        /// </summary>
        Shield = 32,
        /// <summary>
        /// Identifies the Shotgun weapon type (for shotguns that fire slugs).
        /// </summary>
        ShotgunSlug = 64,
        /// <summary>
        /// Identifies the Shotgun weapon type (for shotguns that fire shot).
        /// </summary>
        ShotgunShot = 128,
        /// <summary>
        /// Identifies the Shotgun weapon type (shorthand for an "any shotgun" filter).
        /// </summary>
        Shotgun = ShotgunShot | ShotgunSlug,
        /// <summary>
        /// Identifies the Submachine Gun weapon type.
        /// </summary>
        SubmachineGun = 256,
        /// <summary>
        /// Identifies the Hand Cannon weapon type.
        /// </summary>
        HandCannon = 512
    }

    /// <summary>
    /// Indicates which firing mode a <see cref="Weapon"/> uses.
    /// </summary>
    [Flags]
    public enum FiringMode
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,
        /// <summary>
        /// 
        /// </summary>
        FullAuto = 1,
        /// <summary>
        /// 
        /// </summary>
        SingleShot = 2
    }

    /// <summary>
    /// <para>
    /// Indicates which sights can be or are forcefully equipped on a <see cref="Weapon"/>.
    /// </para>
    /// <para>
    /// As of Y7S1, all weapons (excepting most secondaries and, for example, Glaz's "OTs-03" DMR, which does not have access to Reflex C) have access to all non-magnifying scopes (Red Dot, Holo, Reflex), or more precisely, all of their variants (no matter if standard, Russian, alternate etc.). Because of this, I've decided to combine them. Checking for magnifying scopes still works as before.
    /// </para>
    /// <para>
    /// However, as mentioned above, exceptions such as Glaz's "OTs-03" DMR, which cannot be equipped with Reflex C, are not (yet?) handled differently.
    /// </para>
    /// <para>
    /// Additionally, since there are two 2.5x scope variants, the two options for  that magnification level have also been combined.
    /// </para>
    /// <para>
    /// As of Y7S3, all weapons that have access to scopes of a specific magnification level now automatically have access to all magnifications levels up to that level (excepting Kali's "CSRX 300"). Because of this, the <see cref="Sights"/> flags have been redefined to act as maximums. Use <see cref="Enum.HasFlag(Enum)"/> for any look-ups.
    /// </para>
    /// </summary>
    public enum Sight
    {
        /// <summary>
        /// Generally unused. Indicates an invalid value in terms of a <see cref="WeaponConfiguration"/>.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Indicates that no sights can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        None = 1,
        /// <summary>
        /// Indicates that no or at most any non-magnifying sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        NonMagnifying = 3,
        /// <summary>
        /// Indicates that no or at most a 1.5x sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        OnePointFive = 7,
        /// <summary>
        /// Indicates that no or at most a 2x sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        Two = 15,
        /// <summary>
        /// Indicates that no or at most a 2.5x sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        TwoPointFive = 31,
        /// <summary>
        /// Indicates that no or at most a 3x sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        Three = 63,
        /// <summary>
        /// Indicates that no or at most any non-magnifying sight can be equipped on a <see cref="Weapon"/>, which may then be magnified to 4x by <see cref="Attackers.Glaz"/>'s <i>HDS Flip Sight</i>. Unique to <see cref="Attackers.Glaz"/>.
        /// </summary>
        Four = 131,
        /// <summary>
        /// Indicates that no sights can be equipped on a <see cref="Weapon"/>. This identifies <see cref="Attackers.Kali"/>'s <i>CSRX 300</i>. It is fitted with a 5x scope, which can be toggled to 12x. Unique to <see cref="Attackers.Kali"/>.
        /// </summary>
        FiveTwelve = 256,
        /// <summary>
        /// Indicates that some other weird stuff is going on with the sights for a <see cref="Weapon"/>. This identifies, for example, <see cref="Defenders.Ela"/>'s and <see cref="Attackers.Zofia"/>'s <i>RG15</i> <see cref="WeaponType.Handgun"/>, which has a red-dot sight forcibly equipped.
        /// </summary>
        Other = 512
    }

    /// <summary>
    /// Indicates which barrel attachments can be or are forcefully equipped on a <see cref="Weapon"/>.
    /// </summary>
    [Flags]
    public enum Barrel
    {
        /// <summary>
        /// Indicates that no barrel attachments can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates that a suppressor can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        Suppressor = 1,
        /// <summary>
        /// Indicates that a flash hider can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        FlashHider = 2,
        /// <summary>
        /// Indicates that a compensator can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        Compensator = 4,
        /// <summary>
        /// Indicates that a muzzle brake can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        MuzzleBrake = 8,
        /// <summary>
        /// Indicates that an extended barrel can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        ExtendedBarrel = 16
    }

    /// <summary>
    /// Indicates which grips can be or are forcefully equipped on a <see cref="Weapon"/>.
    /// </summary>
    [Flags]
    public enum Grip
    {
        /// <summary>
        /// Indicates that no grips can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates that a vertical grip can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        VerticalGrip = 1,
        /// <summary>
        /// Indicates that an angled grip can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        AngledGrip = 2
    }

    /// <summary>
    /// Indicates which gadgets an <see cref="Operator"/> may choose from.
    /// </summary>
    [Flags]
    public enum Gadget
    {
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose fragmentation grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        FragGrenade = 1,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose breach charges grenade during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        BreachCharge = 2,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose claymores during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        Claymore = 4,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose hard-breach charges grenade during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        HardBreachCharge = 8,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose smoke grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        SmokeGrenade = 16,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose stun grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        StunGrenade = 32,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose EMP grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        EmpGrenade = 64,

        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose barbed wire during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        BarbedWire = 128,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a deployable shield during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        DeployableShield = 256,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a nitro cell during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        NitroCell = 512,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a bulletproof camera during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        BulletproofCamera = 1024,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose proximity alarms during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        ProximityAlarm = 2048,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose impact grenades during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        ImpactGrenade = 4096
    }

    /// <summary>
    /// Instantiates a new <see cref="Weapon"/> object with the given data.
    /// </summary>
    /// <param name="source">The <see cref="Operator"/> this <see cref="Weapon"/> belongs to.</param>
    /// <param name="name">The in-game name of the <see cref="Weapon"/>.</param>
    /// <param name="type">The in-game <see cref="WeaponType"/> of the <see cref="Weapon"/>.</param>
    /// <param name="fireMode">The in-game <see cref="FiringMode"/> the <see cref="Weapon"/> uses.</param>
    /// <param name="damage">The damage this <see cref="Weapon"/> deals when <i>not</i> equipped with a <see cref="Barrel.ExtendedBarrel"/>.</param>
    /// <param name="roundsPerMinute">The rounds per minute this <see cref="Weapon"/> is capable of firing in-game.</param>
    /// <param name="capacity">The in-game magazine capacity of this <see cref="Weapon"/>.</param>
    /// <param name="sights">A combination of <see cref="Sight"/> values that specifies which sights may be equipped on this <see cref="Weapon"/>.</param>
    /// <param name="barrels">A combination of <see cref="Barrel"/> values that specifies which barrel extensions may be equipped on this <see cref="Weapon"/>.</param>
    /// <param name="grips">A combination of <see cref="Grip"/> values that specifies which grips may be equipped on this <see cref="Weapon"/>.</param>
    /// <param name="underbarrel">Whether an underbarrel laser may be equipped on this <see cref="Weapon"/>.</param>
    /// <param name="reloadTactical">A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform a tactical reload with this <see cref="Weapon"/> (a reload when there is a round chambered).</param>
    /// <param name="reloadEmpty">A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform an empty reload with this <see cref="Weapon"/> (a reload when there is no round chambered).</param>
    internal Weapon(Operator source, string name, WeaponType type, FiringMode fireMode, int damage, int roundsPerMinute, int capacity, Sight sights, Barrel barrels, Grip grips, bool underbarrel, int reloadTactical, int reloadEmpty)
    {
        Source = source;
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

    /// <inheritdoc/>
    public override string ToString() => Name;
    /// <inheritdoc/>
    public static implicit operator string(Weapon wep) => wep.ToString();

    /// <summary>
    /// Attempts to resolve a weapon name to the first <see cref="Weapon"/> object that is found while enumerating <see cref="Siege.DefAtk"/>.
    /// </summary>
    /// <param name="name">The weapon name to resolve to a <see cref="Weapon"/> object.</param>
    /// <returns>A <see cref="Weapon"/> instance if one could be found with a matching name, otherwise <c>null</c>.</returns>
    public static Weapon? Resolve(string name) => Siege.DefAtk.SelectMany(op => op.Primaries.Concat(op.Secondaries)).First(wep => wep.Name.Contains(name, StringComparison.OrdinalIgnoreCase) || wep.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Creates a <see cref="WeaponConfiguration"/> from all possible <see cref="Barrels"/>, <see cref="Grips"/>, <see cref="Sights"/> and <see cref="Underbarrel"/> options attachment combinations.
    /// </summary>
    /// <returns>A <see cref="WeaponConfiguration"/> as described.</returns>
    public WeaponConfiguration GetRandomConfiguration() => new(this);
}
