using System.Collections.ObjectModel;

using rainbowedit.Exceptions;
using rainbowedit.Extensions;

namespace rainbowedit;

/// <summary>
/// A single weapon configuration from all possible <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> combinations.
/// </summary>
public class WeaponConfiguration
{
    private static readonly ReadOnlyCollection<string> _nonMagSightNames = new ReadOnlyCollection<string>(
    [
        "Red Dot A",
        "Red Dot B",
        "Red Dot C",
        "Holo A",
        "Holo B",
        "Holo C",
        "Reflex B",
        "Reflex A",
        "Reflex C",
    ]);
    private static readonly ReadOnlyCollection<string> _magSightNames = new ReadOnlyCollection<string>(
    [
        "Magnifying A",
        "Magnifying B",
        "Magnifying C",
    ]);

    ///<summary>
    /// The <see cref="Weapon"/> this configuration applies to.
    ///</summary>
    public Weapon Source
    {
        get;
    }
    /// <summary>
    /// A string detailing the sight to use.
    /// </summary>
    public string Sight
    {
        get;
    }
    /// <summary>
    /// A string detailing the barrel attachment to use.
    /// </summary>
    public string Barrel
    {
        get;
    }
    /// <summary>
    /// A string detailing the grip to use.
    /// </summary>
    public string Grip
    {
        get;
    }
    /// <summary>
    /// Whether to use an underbarrel laser.
    /// </summary>
    public bool Underbarrel
    {
        get;
    }

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
        Barrel = barrel.GetDescription();
        Grip = grip.GetDescription();
        Underbarrel = underbarrel;

        Sight = sight switch
        {
            Weapon.Sight.NonMagnifying => new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" }.Random(Core.Internals.Random),
            Weapon.Sight.Magnifying => new List<string>() { "2.5x A", "2.5x B" }.Random(Core.Internals.Random),
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

        if (!Enum.GetValues<Weapon.Barrel>().Select(@enum => @enum.GetDescription()).Contains(barrel)
            || !Enum.GetNames<Weapon.Barrel>().Contains(barrel))
        {
            throw new EnumStringificationException<Weapon.Barrel>(barrel);
        }
        Barrel = barrel;

        if (!Enum.GetValues<Weapon.Grip>().Select(@enum => @enum.GetDescription()).Contains(grip)
            || !Enum.GetNames<Weapon.Grip>().Contains(grip))
        {
            throw new EnumStringificationException<Weapon.Grip>(grip);
        }
        Grip = grip;

        if (!Enum.GetValues<Weapon.Sight>()
                 .Select(@enum => @enum.GetDescription())
                 .Concat(Enum.GetNames<Weapon.Sight>())
                 .Concat(new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" })
                 .Concat(new List<string>() { "2.5x A", "2.5x B" }
            ).Contains(sight)
        )
        {
            throw new EnumStringificationException<Weapon.Sight>(sight);
        }
        Sight = sight;
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
}
