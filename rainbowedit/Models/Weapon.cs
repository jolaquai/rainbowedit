using System.ComponentModel;

using rainbowedit.Extensions;

namespace rainbowedit;

/// <summary>
/// An <see cref="Operator"/>-specific <see cref="Weapon"/> in Siege.
/// </summary>
public class Weapon
{
    ///<summary>
    /// The <see cref="Defender"/> this <see cref="Weapon"/> belongs to.
    ///</summary>
    public Operator Source
    {
        get; internal set;
    }
    /// <summary>
    /// The in-game name of the <see cref="Weapon"/>.
    /// </summary>
    public string Name
    {
        get;
    }
    /// <summary>
    /// The in-game <see cref="WeaponType"/> of the <see cref="Weapon"/>.
    /// </summary>
    public WeaponType Type
    {
        get;
    }
    /// <summary>
    /// The in-game <see cref="FiringMode"/> the <see cref="Weapon"/> uses.
    /// </summary>
    public FiringMode FireMode
    {
        get;
    }
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when <i>not</i> equipped with a <see cref="Barrel.ExtendedBarrel"/>.
    /// </summary>
    public int Damage
    {
        get;
    }
    /// <summary>
    /// The rounds per minute this <see cref="Weapon"/> is capable of firing in-game.
    /// </summary>
    public int RoundsPerMinute
    {
        get;
    }
    /// <summary>
    /// The in-game magazine capacity of this <see cref="Weapon"/>.
    /// </summary>
    /// <remarks>
    /// This does not include the single round chambered after cocking the <see cref="Weapon"/>.
    /// </remarks>
    public int Capacity
    {
        get;
    }
    private Sight _sights;
    /// <summary>
    /// A combination of <see cref="Sight"/> values that specifies which sights may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Sight Sights
    {
        get
        {
            var op = (int)_sights & ~(int)(Sight.Invalid | Sight.NoneOther);
            return (Sight)op;
        }
        private set => _sights = value;
    }
    /// <summary>
    /// A combination of <see cref="Barrel"/> values that specifies which barrel extensions may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Barrel Barrels
    {
        get;
    }
    /// <summary>
    /// A combination of <see cref="Grip"/> values that specifies which grips may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    public Grip Grips
    {
        get;
    }
    /// <summary>
    /// Whether an underbarrel laser may be equipped on this <see cref="Weapon"/>.
    /// </summary>
    /// <remarks>
    /// Usage of an underbarrel laser grants a 10% ADS speed bonus.
    /// </remarks>
    public bool Underbarrel
    {
        get;
    }
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when equipped with a <see cref="Barrel.Suppressor"/>.
    /// </summary>
    [Obsolete($"The {nameof(Barrel.Suppressor)} rework in Y7S3 caused this to always be equal to {nameof(Damage)} or 0 (if no {nameof(Barrel.Suppressor)} can be equipped on the weapon), use that instead.")]
    public int SuppressedDamage => Barrels.HasFlag(Barrel.Suppressor) ? Damage : 0;
    /// <summary>
    /// The damage this <see cref="Weapon"/> deals when equipped with a <see cref="Barrel.ExtendedBarrel"/>.
    /// </summary>
    public int ExtendedBarrelDamage
    {
        get;
    }
    /// <summary>
    /// The theoretical damage per second output of this <see cref="Weapon"/> during sustained fire, including ideal (tactical) reloads.
    /// This is only technically relevant and not really meaningful in-game. Furthermore, it's entirely non-sensical for the <c>GONNE-6</c> or shields, for example.
    /// </summary>
    public int DamagePerSecond
    {
        get;
    }
    /// <summary>
    /// A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform a tactical reload with this <see cref="Weapon"/> (a reload when there is a round chambered). For weapons that cannot be in this state (such as revolvers), this is generally equal to <see cref="ReloadEmpty"/>.
    /// </summary>
    public TimeSpan ReloadTactical
    {
        get;
    }
    /// <summary>
    /// A <see cref="TimeSpan"/> instance that represents the amount of time it takes to perform an empty reload with this <see cref="Weapon"/> (a reload when there is no round chambered).
    /// </summary>
    public TimeSpan ReloadEmpty
    {
        get;
    }
    /// <summary>
    /// Whether this <see cref="Weapon"/> is a secondary weapon.
    /// </summary>
    public bool IsSecondary
    {
        get;
    }
    /// <summary>
    /// The time it takes to transition from or to aiming down sights (ADS) with this <see cref="Weapon"/>.
    /// Note that this is only the base value and does not apply modifiers such as sight ADS speed multipliers.
    /// </summary>
    public double AdsSpeed
    {
        get;
    }

    /// <summary>
    /// Contains properties that return specific collections of <see cref="Weapon"/>s.
    /// Note that, at runtime, these evaluate correctly and return an <see cref="IEnumerable{T}"/> of <see cref="Weapon"/>. The inherent issue with how the <see cref="Operator"/> and, consequently, their <see cref="Weapon"/>s are instantiated are that the order in which static fields and properties are initialized is undefined. At compile-time, all the <see cref="Operator"/> and <see cref="Weapon"/> fields/properties are <see langword="null"/>, which makes them unusable for creating pre-defined collections of them. As such, these properties are evaluated lazily through <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class Collections
    {
        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' primary <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> DefenderPrimary => Siege.Defenders.SelectMany(op => op.Primaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' secondary <see cref="Weapon"/>s (see <see cref="Operator.Secondaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> DefenderSecondary => Siege.Defenders.SelectMany(op => op.Secondaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/> and <see cref="Operator.Secondaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> DefenderAll => Siege.Defenders.SelectMany(op => op.Primaries.Concat(op.Secondaries)).DistinctBy(wep => wep.Name);

        /// <summary>
        /// Returns all unique <see cref="Attackers"/>' primary <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> AttackerPrimary => Siege.Attackers.SelectMany(op => op.Primaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Attackers"/>' secondary <see cref="Weapon"/>s (see <see cref="Operator.Secondaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> AttackerSecondary => Siege.Attackers.SelectMany(op => op.Secondaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Attackers"/>' <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/> and <see cref="Operator.Secondaries"/>).
        /// </summary>
        public static IEnumerable<Weapon> AttackerAll => Siege.Attackers.SelectMany(op => op.Primaries.Concat(op.Secondaries)).DistinctBy(wep => wep.Name);

        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' and <see cref="Attackers"/>' primary <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/>), concatenated in that order.
        /// </summary>
        public static IEnumerable<Weapon> AllPrimary => Siege.DefAtk.SelectMany(op => op.Primaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' and <see cref="Attackers"/>' secondary <see cref="Weapon"/>s (see <see cref="Operator.Secondaries"/>), concatenated in that order.
        /// </summary>
        public static IEnumerable<Weapon> AllSecondary => Siege.DefAtk.SelectMany(op => op.Secondaries).DistinctBy(wep => wep.Name);
        /// <summary>
        /// Returns all unique <see cref="Defenders"/>' and <see cref="Attackers"/>' <see cref="Weapon"/>s (see <see cref="Operator.Primaries"/> and <see cref="Operator.Secondaries"/>), concatenated in that order.
        /// </summary>
        public static IEnumerable<Weapon> All => Siege.DefAtk.SelectMany(op => op.Primaries.Concat(op.Secondaries)).DistinctBy(wep => wep.Name);
    }

    /// <summary>
    /// The multiplier that is applied to a weapon's base damage when equipping a <see cref="Barrel.Suppressor"/> on it. This is not defined anywhere and resulted from averaging the ratios from all weapons a <see cref="Barrel.Suppressor"/> can be equipped on (<c>suppressed_dmg / dmg</c>). Typically, using <c>0.84</c> yields a close enough approximate. The calculated value is then rounded towards the nearest integer.
    /// </summary>
    [Obsolete($"The {nameof(Barrel.Suppressor)} rework in Y7S3 caused this to be redefined to exactly 1. Do not reference this to perform calculations as they are no-ops.", true)]
    public const decimal SuppressedDamageMultiplier = 1M; // 0.837697879481015
    /// <summary>
    /// <para>The multiplier that is applied to a weapon's base damage when equipping an <see cref="Barrel.ExtendedBarrel"/> on it. Defined as 15% on top of the <see cref="Weapon"/>'s base damage as part of the Y7S2 Designer's notes (https://store.steampowered.com/news/app/359550/view/5254045511872530857).</para>
    /// <para>As of Y8S1.2, this has been changed to 12% on top of a <see cref="Weapon"/>'s base damage.</para>
    /// </summary>
    public const decimal ExtendedBarrelDamageMultiplier = 1.12M;

    #region public enum WeaponType
    /// <summary>
    /// Identifies the type of a <see cref="Weapon"/>.
    /// </summary>
    [Flags]
    public enum WeaponType
    {
        /// <summary>
        /// Generally unused. Indicates an invalid value in terms of a <see cref="WeaponConfiguration"/>.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Identifies the Assault Rifle weapon type.
        /// </summary>
        [Description("Assault Rifle")]
        AssaultRifle = 1,
        /// <summary>
        /// Identifies the Handgun weapon type.
        /// </summary>
        Handgun = 2,
        /// <summary>
        /// Identifies the Light Machine Gun weapon type.
        /// </summary>
        [Description("Light Machine Gun")]
        LightMachineGun = 4,
        /// <summary>
        /// Identifies the Machine Pistol weapon type.
        /// </summary>
        [Description("Machine Pistol")]
        MachinePistol = 8,
        /// <summary>
        /// Identifies the Marksman Rifle weapon type.
        /// </summary>
        [Description("Marksman Rifle")]
        MarksmanRifle = 16,
        /// <summary>
        /// Identifies the Shield weapon type.
        /// </summary>
        Shield = 32,
        /// <summary>
        /// Identifies the Shotgun weapon type (for shotguns that fire slugs).
        /// </summary>
        [Description("Shotgun (Slug)")]
        ShotgunSlug = 64,
        /// <summary>
        /// Identifies the Shotgun weapon type (for shotguns that fire shot).
        /// </summary>
        [Description("Shotgun (Shot)")]
        ShotgunShot = 128,
        /// <summary>
        /// Identifies the Shotgun weapon type (shorthand for an "any shotgun" filter).
        /// </summary>
        [Description("Shotgun (Any ammo)")]
        Shotgun = ShotgunShot | ShotgunSlug,
        /// <summary>
        /// Identifies the Submachine Gun weapon type.
        /// </summary>
        [Description("Submachine Gun")]
        SubmachineGun = 256,
        /// <summary>
        /// Identifies the Hand Cannon weapon type.
        /// </summary>
        [Description("Hand Cannon")]
        HandCannon = 512,
        /// <summary>
        /// Identifies the Revolver weapon type.
        /// </summary>
        [Description("Revolver")]
        Revolver = 1024,
        /// <summary>
        /// Identifies the Sniper Rifle weapon type.
        /// </summary>
        [Description("Sniper Rifle")]
        SniperRifle = 2048
    }
    #endregion

    #region public enum FiringMode
    /// <summary>
    /// Indicates which firing mode a <see cref="Weapon"/> uses.
    /// </summary>
    [Flags]
    public enum FiringMode
    {
        /// <summary>
        /// Generally unused. Indicates that a <see cref="Weapon"/> has no defined firing mode.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Indicates that a <see cref="Weapon"/> is fully automatic.
        /// </summary>
        [Description("Full Auto")]
        FullAuto = 1,
        /// <summary>
        /// Indicates that a <see cref="Weapon"/> is semi-automatic (requiring another trigger pull / click for each shot).
        /// </summary>
        [Description("Single Shot")]
        SingleShot = 2
    }
    #endregion

    #region public enum Sight
    /// <summary>
    /// Indicates which sights can be or are forcefully equipped on a <see cref="Weapon"/>.
    /// <para/>As of Y7S1, all weapons (excepting most secondaries and, for example, Glaz's "OTs-03" DMR, which does not have access to Reflex C) have access to all non-magnifying (1x) scopes (Red Dot, Holo, Reflex), or more precisely, all of their variants (no matter if standard, Russian, alternate etc.). Because of this, I've decided to combine them. Checking for magnifying scopes still works as before.
    /// <para/>However, as mentioned above, exceptions such as Glaz's "OTs-03" DMR, which cannot be equipped with Reflex C, are not (yet?) handled differently.
    /// <para/>Additionally, since there are two 2.5x scope variants, the two options for  that magnification level have also been combined.
    /// <para/>As of Y7S3, all weapons that have access to scopes of a specific magnification level now automatically have access to all magnifications levels up to that level (excepting Kali's "CSRX 300"). Because of this, the <see cref="Sights"/> flags have been redefined to act as maximums. Use <see cref="Enum.HasFlag(Enum)"/> for any look-ups.
    /// <para/>Y9S1 introduces massive changes to the entire <see cref="Weapon"/> ecosystem, including the overall functionalities of sights, barrels, grips and underbarrel attachments. As such, the <see cref="Sights"/> enum has been redefined to reflect these changes. <see langword="Invalid"/> has been renamed to <see cref="IronSight"/> and all options (excepting <see cref="VariableSniper"/> now also contain <see cref="IronSight"/>.
    /// </summary>
    /// <remarks>
    /// <para/><see cref="Sight"/> is semi-<see cref="FlagsAttribute"/>. and <see cref="Other"/> may be removed using bitwise NOT and AND, the other values stack (see the annotation about the flags representing maximums, not distinct values).
    /// </remarks>
    public enum Sight
    {
        /// <summary>
        /// Generally unused. Indicates an invalid value in terms of a <see cref="WeaponConfiguration"/>.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Indicates that no sights can be equipped on a <see cref="Weapon"/> or that there's something else weird going on with it.
        /// This is true for most <see cref="WeaponType.Handgun"/>s.
        /// </summary>
        [Description("Invalid/Other")]
        NoneOther = 0b000_0001,
        /// <summary>
        /// Indicates that a <see cref="Weapon"/>'s Iron Sight can be chosen.
        /// </summary>
        /// <remarks>
        /// Usage of the Iron Sight grants a 10% ADS speed bonus.
        /// </remarks>
        [Description("Iron Sight")]
        IronSight = 0b000_0010,
        /// <summary>
        /// Indicates that non-magnifying (1x) sights can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        /// <remarks>
        /// Usage of a non-magnifying sight grants a 5% ADS speed bonus.
        /// </remarks>
        [Description("Non-Magnifying")]
        NonMagnifying = 0b000_0110,
        /// <summary>
        /// Indicates that the magnifying sights can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        /// <remarks>
        /// Usage of a magnifying sight grants no ADS speed bonus, but also does not incur a penalty.
        /// </remarks>
        [Description("Magnifying")]
        Magnifying = 0b000_1110,
        /// <summary>
        /// Indicates that the telescopic sight can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        /// <remarks>
        /// Usage of a magnifying sight grants no ADS speed bonus, but also does not incur a penalty.
        /// </remarks>
        [Description("Telescopic")]
        Telescopic = 0b001_1110,
        /// <summary>
        /// Indicates that Iron Sights or at most any non-magnifying (1x) sight can be equipped on a <see cref="Weapon"/>, which may then be magnified to 4x by <see cref="Attackers.Glaz"/>'s <i>HDS Flip Sight</i>. Unique to <see cref="Attackers.Glaz"/>.
        /// </summary>
        [Description("4x")]
        FlipSight = 0b010_0110,
        /// <summary>
        /// Indicates that a variable-zoom 5x/12x sight can be equipped on a <see cref="Weapon"/>. This identifies <see cref="Attackers.Kali"/>'s <i>CSRX 300</i>. Unique to <see cref="Attackers.Kali"/>.
        /// </summary>
        [Description("5x/12x")]
        VariableSniper = 0b100_0000
    }
    #endregion

    #region public enum Barrel
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
        [Description("Flash Hider")]
        FlashHider = 2,
        /// <summary>
        /// Indicates that a compensator can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        Compensator = 4,
        /// <summary>
        /// Indicates that a muzzle brake can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        [Description("Muzzle Brake")]
        MuzzleBrake = 8,
        /// <summary>
        /// Indicates that an extended barrel can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        [Description("Extended Barrel")]
        ExtendedBarrel = 16
    }
    #endregion

    #region public enum Grip
    /// <summary>
    /// Indicates which grips can be or are forcefully equipped on a <see cref="Weapon"/>.
    /// </summary>
    [Flags]
    public enum Grip
    {
        /// <summary>
        /// Indicates that no grips can be equipped on a <see cref="Weapon"/>.
        /// This is also the <see langword="default"/> for <see cref="WeaponType.Handgun"/>s, <see cref="WeaponType.Revolver"/>s and the like, for which no grip options are available.
        /// </summary>
        [Description("Horizontal Grip")]
        HorizontalGrip = 0,
        /// <summary>
        /// Indicates that a vertical grip can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        [Description("Vertical Grip")]
        VerticalGrip = 1,
        /// <summary>
        /// Indicates that an angled grip can be equipped on a <see cref="Weapon"/>.
        /// </summary>
        [Description("Angled Grip")]
        AngledGrip = 2
    }
    #endregion

    #region public enum Gadget
    /// <summary>
    /// Indicates which gadgets an <see cref="Operator"/> may choose from.
    /// </summary>
    [Flags]
    public enum Gadget
    {
        /// <summary>
        /// Generally unused. Indicates an invalid value in terms of a <see cref="WeaponConfiguration"/>.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose fragmentation grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Frag Grenade")]
        FragGrenade = 1,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose breach charges grenade during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Breach Charge")]
        BreachCharge = 2,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose claymores during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Claymore")]
        Claymore = 4,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose hard-breach charges grenade during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Hard Breach Charge")]
        HardBreachCharge = 8,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose smoke grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Smoke Grenade")]
        SmokeGrenade = 16,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose stun grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("Stun Grenade")]
        StunGrenade = 32,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose EMP grenades during loadout selection. This is unique to <see cref="Attackers" />.
        /// </summary>
        [Description("EMP Grenade")]
        EmpGrenade = 64,

        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose barbed wire during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Barbed Wire")]
        BarbedWire = 128,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a deployable shield during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Deployable Shield")]
        DeployableShield = 256,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a nitro cell during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Nitro Cell")]
        NitroCell = 512,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose a bulletproof camera during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Bulletproof Camera")]
        BulletproofCamera = 1024,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose proximity alarms during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Proximity Alarm")]
        ProximityAlarm = 2048,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose impact grenades during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Impact Grenade")]
        ImpactGrenade = 4096,
        /// <summary>
        /// Indicates than an <see cref="Operator"/> may choose observation blockers during loadout selection. This is unique to <see cref="Defenders" />.
        /// </summary>
        [Description("Observation Blocker")]
        ObservationBlocker = 8192
    }
    #endregion

    /// <summary>
    /// Initializes a new <see cref="Weapon"/> object with the given data.
    /// </summary>
    /// <param name="source">The <see cref="Defender"/> this <see cref="Weapon"/> belongs to.</param>
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

        if (Type is WeaponType.Handgun or WeaponType.MachinePistol or WeaponType.HandCannon or WeaponType.Revolver
            || Name is "ITA12S" or "Super Shorty" or "Bailiff 410")
        {
            IsSecondary = true;
        }

        //SuppressedDamage = (int)Math.Round(Barrels.HasFlag(Barrel.Suppressor) ? Damage * SuppressedDamageMultiplier : 0);
        //SuppressedDamage = Barrels.HasFlag(Barrel.Suppressor) ? Damage : 0;
        ExtendedBarrelDamage = (int)Math.Round(Barrels.HasFlag(Barrel.ExtendedBarrel) ? Damage * ExtendedBarrelDamageMultiplier : 0);
        if (!Type.HasFlag(WeaponType.Shield))
        {
            try
            {
                DamagePerSecond = (int)(Damage * Capacity / ((ReloadTactical.TotalSeconds) + (Capacity / (RoundsPerMinute / 60d))));
            }
            catch
            {
                DamagePerSecond = 0;
            }
        }

        AdsSpeed = Type switch
        {
            WeaponType.Handgun or WeaponType.Revolver or WeaponType.HandCannon => 0.24,
            WeaponType.MachinePistol => 0.38,
            WeaponType.SubmachineGun => 0.46,
            WeaponType.AssaultRifle or WeaponType.MarksmanRifle or WeaponType.SniperRifle => 0.52,
            WeaponType.LightMachineGun => 0.56,
            WeaponType.ShotgunShot or WeaponType.ShotgunSlug => 0.34,
            WeaponType.Shield or WeaponType.Shotgun => 0,
            _ => throw new InvalidEnumArgumentException(nameof(Type), (int)Type, typeof(WeaponType))
        };
    }

    /// <inheritdoc/>
    public override string ToString() => Name;
    /// <summary>
    /// Implicitly converts a <see cref="Weapon"/> to a <see cref="string"/> that represents the <see cref="Weapon"/>.
    /// </summary>
    /// <param name="wep">The <see cref="Weapon"/> to convert.</param>
    public static implicit operator string(Weapon wep) => wep.ToString();

    /// <summary>
    /// Creates a <see cref="WeaponConfiguration"/> from all possible <see cref="Barrels"/>, <see cref="Grips"/>, <see cref="Sights"/> and <see cref="Underbarrel"/> options attachment combinations.
    /// </summary>
    /// <returns>A <see cref="WeaponConfiguration"/> as described.</returns>
    public WeaponConfiguration GetRandomConfiguration() => new WeaponConfiguration(this);

    /// <summary>
    /// Gets the raw value for the <see cref="Sights"/> property; that is, special flags such as <see cref="Sight.Invalid"/>, <see cref="Sight.None"/> or <see cref="Sight.Other"/> may be set. Comparisons using this value as opposed to <see cref="Sights"/> are considered undefined behavior.
    /// </summary>
    /// <returns>The internal unmodified value of the <see cref="Sights"/> property, which may contain special flags as described.</returns>
    public int GetRawSightValue() => (int)_sights;

    /// <summary>
    /// Attempts to resolve a weapon name to the first <see cref="Weapon"/> object that is found while enumerating <see cref="Siege.DefAtk"/>.
    /// </summary>
    /// <param name="name">The case-insensitive weapon name to resolve to a <see cref="Weapon"/> object.</param>
    /// <param name="similarityThreshold">How similar (in percent) an actual <see cref="Name"/> must be for the <see cref="Weapon"/> to be considered a match for the specified <paramref name="name"/>. If not specified, a value is dynamically calculated based on the length of <paramref name="name"/>.</param>
    /// <returns>A <see cref="Weapon"/> instance if one could be found with a matching <paramref name="name"/>. If no exact match could be found, a <see cref="Weapon"/> instance whose name is sufficiently similar to an existing <see cref="Weapon"/>'s name. If this also returns no match, <c>null</c>.</returns>
    /// <remarks>Do not rely on this to return a <see cref="Weapon"/> instance usable for <see cref="Sight"/> data as loadouts are specific to an <see cref="Operator"/>.</remarks>
    public static Weapon? Resolve(string name, double similarityThreshold = -1)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        if (similarityThreshold is not -1 and (< 0 or > 1))
        {
            throw new ArgumentOutOfRangeException(nameof(similarityThreshold), similarityThreshold, "Explicitly overridden similarity threshold cannot be greater than 1.");
        }

        // Dynamically check how accurate the name must be to be considered a match if a direct match cannot be found, if the threshold is not manually overridden
        similarityThreshold = similarityThreshold == -1 ? 1d / (0.05 * name.Length + 1) : similarityThreshold;

        var allWeps = Collections.All;
        if (allWeps.FirstOrDefault(wep => wep.Name.Contains(name, StringComparison.OrdinalIgnoreCase) || wep.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) is Weapon maybeWep)
        {
            return maybeWep;
        }
        else if (allWeps.Select(wep => new KeyValuePair<Weapon, double>(wep, wep.Name.GetSimilarity(name)))
                .Where(kv => kv.Value >= similarityThreshold)
                .OrderByDescending(kv => kv.Value)
                .ToList() is var possibleSimilarWeps
            && possibleSimilarWeps.Count > 0)
        {
            return possibleSimilarWeps[0].Key;
        }
        return null;
    }
}
