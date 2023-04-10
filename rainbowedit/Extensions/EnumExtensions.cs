using System.Data.Common;
using System.Text.RegularExpressions;

using rainbowedit.Helpers;

namespace RainbowEdit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="Enum"/> type and derived types.
/// </summary>
public static partial class EnumExtensions
{
    /// <summary>
    /// Compiles a <see cref="List{T}"/> of enum values typed <typeparamref name="T"/> that are set in a given <see cref="FlagsAttribute"/> enum instance.
    /// </summary>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <param name="source">The enum value to extract the set flags on.</param>
    /// <returns>A list of individual <typeparamref name="T"/> values that are set in <paramref name="source"/>.</returns>
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

    /// <summary>
    /// Determines if an enum value <paramref name="source"/> of <typeparamref name="T"/> has a non-zero value.
    /// </summary>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <param name="source">The enum value to test.</param>
    /// <returns>A value indicating whether <paramref name="source"/> has a non-zero value.</returns>
    public static bool HasValue<T>(this T source)
        where T : Enum => source.GetSetFlags().Any();

    /// <summary>
    /// Determines if an enum value <paramref name="source"/> of <typeparamref name="T"/> has at least one value that another <paramref name="value"/> also has. May not work correctly with non-<see cref="FlagsAttribute"/> enums.
    /// </summary>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <param name="source">The enum value to test.</param>
    /// <param name="value">An enum value that is checked against.</param>
    /// <returns>A value indicating whether <paramref name="source"/> has at least one value that <paramref name="value"/> also has.</returns>
    public static bool HasValue<T>(this T source, T value)
        where T : Enum => source.GetSetFlags().Intersect(value.GetSetFlags()).Any();

    /// <summary>
    /// Generates a string representation for this <see cref="Weapon.Gadget"/> enum value.
    /// </summary>
    /// <param name="source">The enum value to stringify.</param>
    /// <returns>A string representing this <see cref="Weapon.Gadget"/> enum value.</returns>
    public static string Stringify(this Weapon.Gadget source)
    {
        var gadget = source.ToString();
        var matches = UppercaseLetterRegex().Matches(gadget, 1);
        foreach (var match in matches.Cast<Match>())
        {
            gadget = gadget.Replace(match.Value, ' ' + match.Value);
        }
        return gadget.Trim();
    }

    /// <summary>
    /// Generates a string representation for this <see cref="Weapon.Barrel"/> enum value.
    /// </summary>
    /// <param name="source">The enum value to stringify.</param>
    /// <returns>A string representing this <see cref="Weapon.Barrel"/> enum value.</returns>
    public static string Stringify(this Weapon.Barrel source)
    {
        var barrel = source.ToString();
        var matches = UppercaseLetterRegex().Matches(barrel, 1);
        foreach (var match in matches.Cast<Match>())
        {
            barrel = barrel.Replace(match.Value, ' ' + match.Value);
        }
        return barrel.Trim();
    }

    /// <summary>
    /// Generates a string representation for this <see cref="Weapon.Grip"/> enum value.
    /// </summary>
    /// <param name="source">The enum value to stringify.</param>
    /// <returns>A string representing this <see cref="Weapon.Grip"/> enum value.</returns>
    public static string Stringify(this Weapon.Grip source)
    {
        var grip = source.ToString();
        var matches = UppercaseLetterRegex().Matches(grip, 1);
        foreach (var match in matches.Cast<Match>())
        {
            grip = grip.Replace(match.Value, ' ' + match.Value);
        }
        return grip.Trim();
    }

    /// <summary>
    /// Generates a string representation for this <see cref="Weapon.WeaponType"/> enum value.
    /// </summary>
    /// <param name="source">The enum value to stringify.</param>
    /// <returns>A string representing this <see cref="Weapon.WeaponType"/> enum value.</returns>
    public static string Stringify(this Weapon.WeaponType source)
    {
        var type = source.ToString();
        var matches = UppercaseLetterRegex().Matches(type, 1);
        foreach (var match in matches.Cast<Match>())
        {
            type = type.Replace(match.Value, ' ' + match.Value);
        }
        return type.Trim();
    }
    [GeneratedRegex("[A-Z]")]
    private static partial Regex UppercaseLetterRegex();

    /// <summary>
    /// Generates a string representation for this <see cref="Weapon.Sight"/> enum value.
    /// </summary>
    /// <param name="source">The enum value to stringify.</param>
    /// <returns>A string representing this <see cref="Weapon.Sight"/> enum value.</returns>
    public static string Stringify(this Weapon.Sight source) => source switch
    {
        Weapon.Sight.Invalid => "Invalid",
        Weapon.Sight.None => "None",
        Weapon.Sight.One => "1x",
        Weapon.Sight.OnePointFive => "1.5x",
        Weapon.Sight.Two => "2x",
        Weapon.Sight.TwoPointFive => "2.5x",
        Weapon.Sight.Three => "3x",
        Weapon.Sight.Four => "4x",
        Weapon.Sight.FiveTwelve => "5x/12x",
        Weapon.Sight.Other => "Other",
        _ => new Func<string>(() =>
        {
            var op = (int)source & ~(int)Weapon.Sight.Other;
            return Enum.GetValues<Weapon.Sight>()
                .Reverse()
                .Remove(Weapon.Sight.Invalid)
                .First(enumVal => (op & (int)enumVal) == (int)enumVal)
                .Stringify();
        })()
        //_ => throw new ArgumentException($"A string representation could not be generated the provided value {source}.", nameof(source))
    };
}
