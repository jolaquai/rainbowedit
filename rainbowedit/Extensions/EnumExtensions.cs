using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;

namespace rainbowedit.Extensions;

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
        List<T> set = [];
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
        where T : Enum => source.GetSetFlags().Count != 0;

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
    /// Returns the <see cref="DescriptionAttribute.Description"/> for the given <see cref="Enum"/> value. If the value is not decorated with a <see cref="DescriptionAttribute"/>, the default <see cref="string"/> representation of the value is returned.
    /// </summary>
    /// <param name="any">The <see cref="Enum"/> value to retrieve the description for.</param>
    /// <returns>The value of the <see cref="DescriptionAttribute.Description"/> for the given <see cref="Enum"/> value or its default <see cref="string"/> representation.</returns>
    public static string GetDescription(this Enum any)
    {
        var type = any.GetType();
        var name = Enum.GetName(type, any);
        var fallback = any.ToString();
        if (type.GetField(name!) is FieldInfo field
            && field.GetCustomAttribute<DescriptionAttribute>() is DescriptionAttribute desc)
        {
            return desc.Description;
        }
        else
        {
            return fallback;
        }
    }
}
