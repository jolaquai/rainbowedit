using rainbowedit.Exceptions;
using rainbowedit.Extensions;

namespace rainbowedit;

/// <summary>
/// A single weapon configuration from all possible <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> combinations.
/// </summary>
public class WeaponConfiguration
{
    internal static readonly ImmutableArray<string> _nonMagSightNames =
    [
        "Red Dot A",
        "Red Dot B",
        "Red Dot C",
        "Holo A",
        "Holo B",
        "Holo C",
        "Holo D",
        "Reflex B",
        "Reflex A",
        "Reflex C",
    ];
    internal static readonly ImmutableArray<string> _magSightNames =
    [
        "Magnifying A",
        "Magnifying B",
        "Magnifying C",
    ];
    internal static readonly ImmutableArray<string> _teleSightNames =
    [
        "Telescopic A",
        "Telescopic B",
    ];

    // Need these for calculations
    private Weapon.Sight sourceSight;
    private Weapon.Barrel sourceBarrel;
    private Weapon.Grip sourceGrip;

    ///<summary>
    /// The <see cref="Weapon"/> this configuration applies to.
    ///</summary>
    public Weapon Source { get; }
    /// <summary>
    /// A string detailing the sight to use.
    /// </summary>
    public string Sight { get; }
    /// <summary>
    /// A string detailing the barrel attachment to use.
    /// </summary>
    public string Barrel { get; }
    /// <summary>
    /// A string detailing the grip to use.
    /// </summary>
    public string Grip { get; }
    /// <summary>
    /// Whether to use an underbarrel laser.
    /// </summary>
    public bool Underbarrel { get; }

    /// <summary>
    /// Initializes a new <see cref="WeaponConfiguration"/> object from just a <see cref="Weapon"/> to gather values from.
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to gather random values for this <see cref="WeaponConfiguration"/> instance's properties from.</param>
    public WeaponConfiguration(Weapon source)
    {
        Source = source;

        var possibleSights = Source.Sights.GetFlags();
        var possibleBarrels = Source.Barrels.GetFlags();
        var possibleGrips = Source.Grips.GetFlags();

        if (possibleSights.Length != 0)
        {
            List<string> actualSights = [];
            foreach (var possibleSight in possibleSights)
            {
                switch (possibleSight)
                {
                    case Weapon.Sight.NonMagnifying:
                        actualSights.AddRange(_nonMagSightNames);
                        break;
                    case Weapon.Sight.Magnifying:
                        actualSights.AddRange(_magSightNames);
                        break;
                    case Weapon.Sight.Telescopic:
                        actualSights.AddRange(_teleSightNames);
                        break;
                    default:
                        actualSights.Add(possibleSight.GetDescription());
                        break;
                }
            }
            Sight = actualSights.Random(Core.Internals.Random);
        }
        else
        {
            Sight = Weapon.Sight.Invalid.GetDescription();
        }

        if (possibleBarrels.Length != 0)
        {
            Barrel = possibleBarrels.Random(Core.Internals.Random).GetDescription();
        }
        else
        {
            Barrel = Weapon.Barrel.None.GetDescription();
        }

        if (possibleGrips.Length != 0)
        {
            Grip = possibleGrips.Random(Core.Internals.Random).GetDescription();
        }
        else
        {
            Grip = Weapon.Grip.HorizontalGrip.GetDescription();
        }

        if (Source.Underbarrel)
        {
            Underbarrel = Core.Internals.Random.Next(2) == 0;
        }
    }

    /// <summary>
    /// Initializes a new <see cref="WeaponConfiguration"/> object from and one each of their <see cref="Weapon.Sight"/>s, <see cref="Weapon.Barrel"/>s and <see cref="Weapon.Grip"/>s and a value indicating whether to use a <see cref="Weapon.Underbarrel"/> laser.
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to gather random values for this <see cref="WeaponConfiguration"/> instance's properties from.</param>
    /// <param name="sight">A <see cref="Weapon.Sight"/> enum value detailing the sight to use. If this is <see cref="Weapon.Sight.NonMagnifying"/> or <see cref="Weapon.Sight.Magnifying"/>, a random one of its variants is chosen.</param>
    /// <param name="barrel">A <see cref="Weapon.Barrel"/> enum value detailing the barrel attachment to use.</param>
    /// <param name="grip">A <see cref="Weapon.Grip"/> enum value detailing the grip to use.</param>
    /// <param name="underbarrel">Whether to use an underbarrel laser.</param>
    public WeaponConfiguration(Weapon source, Weapon.Sight sight, Weapon.Barrel barrel, Weapon.Grip grip, bool underbarrel)
    {
        Source = source;
        sourceBarrel = barrel;
        sourceGrip = grip;
        sourceSight = sight;

        Barrel = barrel.GetDescription();
        Grip = grip.GetDescription();
        Underbarrel = underbarrel;

        Sight = sight switch
        {
            Weapon.Sight.NonMagnifying => _nonMagSightNames.Random(Core.Internals.Random),
            Weapon.Sight.Magnifying => _magSightNames.Random(Core.Internals.Random),
            Weapon.Sight.Telescopic => _teleSightNames.Random(Core.Internals.Random),
            Weapon.Sight.FlipSight => source.Source == Attackers.Glaz ? sight.GetDescription() : throw new LoadoutOperatorMismatchException(source.Source, Weapon.Sight.FlipSight),
            Weapon.Sight.VariableSniper => source.Source == Attackers.Kali ? sight.GetDescription() : throw new LoadoutOperatorMismatchException(source.Source, Weapon.Sight.VariableSniper),
            _ => sight.GetDescription()
        };
    }

    /// <summary>
    /// <para>
    /// Initializes a new fully customized <see cref="WeaponConfiguration"/> object from a <see cref="Weapon"/> and string representations of one each of their <see cref="Weapon.Sight"/>s, <see cref="Weapon.Barrel"/>s and <see cref="Weapon.Grip"/>s and a value indicating whether to use a <see cref="Weapon.Underbarrel"/> laser.
    /// </para>
    /// <para>
    /// An <see cref="EnumStringificationException{TEnum}"/> is thrown if one of the strings passed does not match any possible string representations for that enum.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to assign to this <see cref="WeaponConfiguration"/> instance.</param>
    /// <param name="sight">A string detailing the sight to use. This must match one of the string representations returned by <see cref="EnumExtensions.GetDescription(Enum)" /> OR one of the sub-sight names for <see cref="Weapon.Sight.NonMagnifying"/> or <see cref="Weapon.Sight.Magnifying"/>.</param>
    /// <param name="barrel">A string detailing the barrel attachment to use. This must match one of the string representations returned by <see cref="EnumExtensions.GetDescription(Enum)" />.</param>
    /// <param name="grip">A string detailing the grip to use. This must match one of the string representations returned by <see cref="EnumExtensions.GetDescription(Enum)" />.</param>
    /// <param name="underbarrel">Whether to use an underbarrel laser.</param>
    /// <exception cref="EnumStringificationException{TEnum}">Thrown if one of the strings passed does not match any possible string representations for that enum.</exception>
    public WeaponConfiguration(Weapon source, string sight, string barrel, string grip, bool underbarrel)
    {
        Source = source;
        Underbarrel = underbarrel;

        // Had to rewrite this into actual parsing logic to get at the actual enum values
        if (!EnumExtensions.TryGetValue<Weapon.Barrel>(barrel, out var barrelEnum))
        {
            throw new EnumStringificationException<Weapon.Barrel>(barrel);
        }
        sourceBarrel = barrelEnum;
        Barrel = barrel;

        if (!EnumExtensions.TryGetValue<Weapon.Grip>(grip, out var gripEnum))
        {
            throw new EnumStringificationException<Weapon.Grip>(grip);
        }
        sourceGrip = gripEnum;
        Grip = grip;

        // We'll really try hard to recognize the sight value cause there's a TON
        // Double helper method for this, so we can just pass the sight string and get the enum value back
        // It's gonna take days for this constructor to return...
        if (!TryFindSight(sight, out var sightEnum))
        {
            throw new EnumStringificationException<Weapon.Sight>(sight);
        }
        sourceSight = sightEnum;
        Sight = sight;
    }

    private static bool TryFindSight(string s, out Weapon.Sight parsed)
    {
        if (EnumExtensions.TryGetValue(s, out parsed))
        {
            return true;
        }
        if (_nonMagSightNames.Contains(s.Trim(), StringComparer.OrdinalIgnoreCase))
        {
            parsed = Weapon.Sight.NonMagnifying;
        }
        else if (_magSightNames.Contains(s.Trim(), StringComparer.OrdinalIgnoreCase))
        {
            parsed = Weapon.Sight.Magnifying;
        }
        else if (_teleSightNames.Contains(s.Trim(), StringComparer.OrdinalIgnoreCase))
        {
            parsed = Weapon.Sight.Telescopic;
        }
        else
        {
            return false;
        }
        return true;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (!Source.IsSecondary)
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type.GetDescription()}
                Sight: {(Source.Sights.HasFlag(Weapon.Sight.NoneOther) || Source.Sights == Weapon.Sight.Invalid ? "\u2014" : Sight)}
                Barrel: {Barrel}
                Grip: {Grip}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
        else
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type.GetDescription()}
                Sight: {(Source.Sights.HasFlag(Weapon.Sight.NoneOther) || Source.Sights == Weapon.Sight.Invalid ? "\u2014" : Sight)}
                Barrel: {Barrel}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
    }

    /// <summary>
    /// Gets the actual damage the <see cref="Source"/> <see cref="Weapon"/> would deal with this configuration.
    /// </summary>
    public int Damage => sourceBarrel is Weapon.Barrel.ExtendedBarrel ? Source.ExtendedBarrelDamage : Source.Damage;
    /// <summary>
    /// Gets a <see cref="TimeSpan"/> instance that represents the actual amount of time it takes to perform a tactical reload with the <see cref="Source"/> <see cref="Weapon"/> (a reload when there is a round chambered).
    /// </summary>
    public TimeSpan ReloadTactical => sourceGrip is Weapon.Grip.AngledGrip ? Source.ReloadTactical * 0.8 : Source.ReloadTactical;
    /// <summary>
    /// Gets a <see cref="TimeSpan"/> instance that represents the actual amount of time it takes to perform an empty reload with the <see cref="Source"/> <see cref="Weapon"/> (a reload when there is no round chambered).
    /// </summary>
    public TimeSpan ReloadEmpty => sourceGrip is Weapon.Grip.AngledGrip ? Source.ReloadEmpty * 0.8 : Source.ReloadEmpty;
    /// <summary>
    /// Gets a actual time it takes to transition from or to aiming down sights (ADS) with this <see cref="Weapon"/>.
    /// Note that this is only the base value (with no positive or negative modifiers from attachments applied). To calculate that, use a <see cref="WeaponConfiguration"/>.
    /// </summary>
    public TimeSpan AdsSpeed
    {
        get
        {
            var baseSpeed = Source.AdsSpeed;
            var factor = 1d;
            switch (sourceSight)
            {
                case Weapon.Sight.NonMagnifying:
                    factor *= 1.05;
                    break;
                case Weapon.Sight.Magnifying:
                case Weapon.Sight.Telescopic:
                    factor *= 1.10;
                    break;
            }
            if (Underbarrel)
            {
                factor *= 0.9d;
            }
            return baseSpeed * factor;
        }
    }
}
