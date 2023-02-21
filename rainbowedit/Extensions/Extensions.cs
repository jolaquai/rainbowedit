using System.Text.RegularExpressions;

namespace RainbowEdit.Extensions;

public static partial class EnumExtensions
{
    public static List<T> GetSetFlags<T>(this T source)
        where T : Enum
    {
        List<T> set = new();
        foreach (T value in Enum.GetValues(typeof(T)))
        {
            if (source.HasFlag(value))
            {
                set.Add(value);
            }
        }
        return set;
    }

    public static string Stringify(this Weapon.Gadget source)
    {
        string gadget = source.ToString();
        MatchCollection matches = UppercaseLetterRegex().Matches(gadget, 1);
        foreach (Match match in matches.Cast<Match>())
        {
            gadget = gadget.Replace(match.Value, ' ' + match.Value);
        }
        return gadget.Trim();
    }
    public static string Stringify(this Weapon.Barrel source)
    {
        string barrel = source.ToString();
        MatchCollection matches = UppercaseLetterRegex().Matches(barrel, 1);
        foreach (Match match in matches.Cast<Match>())
        {
            barrel = barrel.Replace(match.Value, ' ' + match.Value);
        }
        return barrel.Trim();
    }
    public static string Stringify(this Weapon.Grip source)
    {
        string grip = source.ToString();
        MatchCollection matches = UppercaseLetterRegex().Matches(grip, 1);
        foreach (Match match in matches.Cast<Match>())
        {
            grip = grip.Replace(match.Value, ' ' + match.Value);
        }
        return grip.Trim();
    }
    public static string Stringify(this Weapon.WeaponType source)
    {
        string type = source.ToString();
        MatchCollection matches = UppercaseLetterRegex().Matches(type, 1);
        foreach (Match match in matches.Cast<Match>())
        {
            type = type.Replace(match.Value, ' ' + match.Value);
        }
        return type.Trim();
    }
    [GeneratedRegex("[A-Z]")]
    private static partial Regex UppercaseLetterRegex();

    public static string Stringify(this Weapon.Sight source) => source switch
    {
        Weapon.Sight.Invalid => "Invalid",
        Weapon.Sight.NonMagnifying => "Non-magnifying",
        Weapon.Sight.None => "None",
        Weapon.Sight.OnePointFive => "1.5x",
        Weapon.Sight.Two => "2x",
        Weapon.Sight.TwoPointFive => "2.5x",
        Weapon.Sight.Three => "3x",
        Weapon.Sight.Four => "4x",
        Weapon.Sight.FiveTwelve => "5x/12x",
        Weapon.Sight.Other => "Other"
    };
}

public static class IEnumerableExtensions
{
    public static T Random<T>(this IEnumerable<T> source)
    {
        List<T> enumerated = new(source);
        return enumerated[new Random().Next(enumerated.Count)];
    }
}
