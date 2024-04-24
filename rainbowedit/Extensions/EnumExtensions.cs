using System.Collections.Frozen;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace rainbowedit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="Enum"/> type and derived types.
/// </summary>
public static partial class EnumExtensions
{
    /// <summary>
    /// Gets all possible values a value of the specified <typeparamref name="TEnum"/> can have.
    /// </summary>
    /// <typeparam name="TEnum">The <see cref="Enum"/> type to retrieve the values for.</typeparam>
    /// <returns>An array of all possible values a value of the specified <typeparamref name="TEnum"/> can have, excluding the zero value.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified <typeparamref name="TEnum"/> is not marked with the <see cref="FlagsAttribute"/>.</exception>
    public static TEnum[] GetValues<TEnum>()
        where TEnum : struct, Enum
    {
        if (typeof(TEnum).GetCustomAttribute<FlagsAttribute>() is null)
        {
            throw new ArgumentException($"The given Enum type '{typeof(TEnum).FullName}' is not marked with [FlagsAttribute].");
        }
        return Array.FindAll(Enum.GetValues<TEnum>(), field => Unsafe.BitCast<TEnum, int>(field) is not 0);
    }

    private static readonly Dictionary<Type, FrozenDictionary<Enum, int>> _flagsCache = [];
    /// <summary>
    /// Retrieves all flags that are currently set in the specified <typeparamref name="TEnum"/> value.
    /// Because this implicitly makes <paramref name="any"/> a bitwise-AND combination of the resulting flags, it is only included in the result set if its underlying value is a named <see langword="enum"/> value.
    /// </summary>
    /// <typeparam name="TEnum">The <see cref="Enum"/> type to retrieve the flags for.</typeparam>
    /// <param name="any">The <typeparamref name="TEnum"/> value to retrieve the flags for.</param>
    /// <returns>The flags that are currently set in the specified <typeparamref name="TEnum"/> value or an empty array if no flags are set.</returns>
    public static TEnum[] GetFlags<TEnum>(this TEnum any)
        where TEnum : struct, Enum
    {
        var enumType = typeof(TEnum);
        if (enumType.GetCustomAttribute<FlagsAttribute>() is null)
        {
            throw new ArgumentException($"The given Enum type '{enumType.FullName}' is not marked with [FlagsAttribute].", nameof(any));
        }
        if (!_flagsCache.TryGetValue(enumType, out var currentFlags))
        {
            var flags = Enum.GetValues<TEnum>();
            var values = Array.ConvertAll(flags, Unsafe.BitCast<TEnum, int>);
            currentFlags = Enumerable.Range(0, flags.Length).Select(i => new KeyValuePair<Enum, int>(flags[i], values[i])).ToFrozenDictionary();
            _flagsCache[enumType] = currentFlags;
        }
        return currentFlags.Where(kv => any.HasFlag(kv.Key) && kv.Value != 0).Select(kv => (TEnum)kv.Key).ToArray();
    }

    /// <summary>
    /// Determines if an enum value <paramref name="source"/> of <typeparamref name="T"/> has a non-zero value.
    /// </summary>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <param name="source">The enum value to test.</param>
    /// <returns>A value indicating whether <paramref name="source"/> has a non-zero value.</returns>
    public static bool HasValue<T>(this T source) where T : struct, Enum => source.GetFlags().Length != 0;

    /// <summary>
    /// Determines if an enum value <paramref name="source"/> of <typeparamref name="T"/> has at least one value that another <paramref name="value"/> also has. May not work correctly with non-<see cref="FlagsAttribute"/> enums.
    /// </summary>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <param name="source">The enum value to test.</param>
    /// <param name="value">An enum value that is checked against.</param>
    /// <returns>A value indicating whether <paramref name="source"/> has at least one value that <paramref name="value"/> also has.</returns>
    public static bool HasValue<T>(this T source, T value) where T : struct, Enum => source.GetFlags().Intersect(value.GetFlags()).Any();

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
