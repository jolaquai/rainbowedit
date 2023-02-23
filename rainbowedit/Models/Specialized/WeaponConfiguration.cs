using RainbowEdit.Extensions;

namespace RainbowEdit;

/// <summary>
/// A single weapon configuration from all possible <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> combinations.
/// </summary>
public class WeaponConfiguration
{
    ///<summary>
    /// The <see cref="Weapon"/> this configuration applies to.
    ///</summary>
    public Weapon Source { get; private set; }
    /// <summary>
    /// A string detailing the sight to use.
    /// </summary>
    public string Sight { get; private set; }
    /// <summary>
    /// A string detailing the barrel attachment to use.
    /// </summary>
    public string Barrel { get; private set; }
    /// <summary>
    /// A string detailing the grip to use.
    /// </summary>
    public string Grip { get; private set; }
    /// <summary>
    /// Whether to use an underbarrel laser.
    /// </summary>
    public bool Underbarrel { get; private set; }

    /// <summary>
    /// Instantiates a new <see cref="WeaponConfiguration"/> object from just a <see cref="Weapon"/> to gather values from.
    /// </summary>
    /// <param name="source">The <see cref="Weapon"/> to gather random values for this <see cref="WeaponConfiguration"/> instance's properties from.</param>
    internal WeaponConfiguration(Weapon source)
    {
        Source = source;

        Random ran = new();

        List<Weapon.Sight> possibleSights = Source.Sights.GetSetFlags();
        List<Weapon.Barrel> possibleBarrels = Source.Barrels.GetSetFlags();
        List<Weapon.Grip> possibleGrips = Source.Grips.GetSetFlags();

        if (possibleSights.Any())
        {
            Weapon.Sight sight = possibleSights.Random();
            Sight = sight switch
            {
                Weapon.Sight.NonMagnifying => new List<string>() { "Red Dot A", "Red Dot B", "Red Dot C", "Holo A", "Holo B", "Holo C", "Holo D", "Reflex B", "Reflex A", "Reflex C" }.Random(),
                Weapon.Sight.TwoPointFive => new List<string>() { "2.5x A", "2.5x B" }.Random(),
                _ => sight.Stringify()
            };
        }
        if (possibleBarrels.Any())
        {
            Barrel = possibleBarrels.Random().Stringify();
        }
        if (possibleGrips.Any())
        {
            Grip = possibleGrips.Random().Stringify();
        }
        if (Source.Underbarrel)
        {
            Underbarrel = ran.Next(2) == 0;
        }
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (!Source.IsSecondary)
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type}
                Sight: {Sight}
                Barrel: {Barrel}
                Grip: {Grip}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
        else
        {
            return $"""
                Name: {Source.Name}
                Type: {Source.Type}
                Sight: {(Source.Sights.HasFlag(Weapon.Sight.Other) ? "\u2014" : Sight)}
                Barrel: {Barrel}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
    }
}
