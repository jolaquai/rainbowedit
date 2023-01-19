using RainbowEdit.Extensions;

namespace RainbowEdit;

public class WeaponConfiguration
{
    public Weapon Source
    {
        get; private set;
    }
    public Weapon.Sight Sight
    {
        get; private set;
    } = Weapon.Sight.Invalid;
    public Weapon.Barrel Barrel
    {
        get; private set;
    } = Weapon.Barrel.None;
    public Weapon.Grip Grip
    {
        get; private set;
    } = Weapon.Grip.None;
    public bool Underbarrel
    {
        get; private set;
    }

    internal WeaponConfiguration(Weapon source)
    {
        Source = source;

        Random ran = new();

        List<Weapon.Sight> possibleSights = Source.Sights.GetSetFlags();
        List<Weapon.Barrel> possibleBarrels = Source.Barrels.GetSetFlags();
        List<Weapon.Grip> possibleGrips = Source.Grips.GetSetFlags();

        if (possibleSights.Any())
        {
            Sight = possibleSights[ran.Next(possibleSights.Count)];
        }
        if (possibleBarrels.Any())
        {
            Barrel = possibleBarrels[ran.Next(possibleBarrels.Count)];
        }
        if (possibleGrips.Any())
        {
            Grip = possibleGrips[ran.Next(possibleGrips.Count)];
        }
        if (Source.Underbarrel)
        {
            Underbarrel = ran.Next(2) == 0;
        }
    }

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
                Sight: {(Source.Sights.HasFlag(Weapon.Sight.Other) ? "\u2014" : Sight.ToString())}
                Barrel: {Barrel}
                Laser: {(Source.Underbarrel ? (Underbarrel ? "Yes" : "No") : "\u2014")}
                """;
        }
    }
}
