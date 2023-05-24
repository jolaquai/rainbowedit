namespace rainbowedit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="string"/> type.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Computes a value that indicates the similarity between two strings. "Similarity" is defined as the number of characters that are the same in both strings, divided by the length of the longer string. As such, the value returned by this method is always between <c>0</c> (the strings are have no characters in common) and <c>1</c> (the strings are equal), inclusive.
    /// </summary>
    /// <param name="first">The first <see cref="string"/> to use for the comparison.</param>
    /// <param name="second">The second <see cref="string"/> to use for the comparison.</param>
    /// <param name="stringComparer">A <see cref="StringComparer"/> instance to use when comparing the <see cref="string"/>s. Defaults to <see cref="StringComparer.OrdinalIgnoreCase"/>.</param>
    /// <returns>The computed similarity as described.</returns>
    public static double GetSimilarity(this string first, string second, StringComparer? stringComparer = null)
    {
        ArgumentNullException.ThrowIfNull(second);

        if (!first.Intersect(second).Any()
            || string.IsNullOrEmpty(first)
            || string.IsNullOrEmpty(second))
        {
            return 0;
        }

        stringComparer ??= StringComparer.OrdinalIgnoreCase;

        if (stringComparer.Compare(first, second) == 0)
        {
            return 1;
        }

        _ = first.Select(c => c.ToString()).Intersect(second.Select(c => c.ToString()), stringComparer);
        return (double)first.Select(c => c.ToString()).Intersect(second.Select(c => c.ToString()), stringComparer).Count() / new List<string>() { first, second }.Max(str => str.Length);
    }
}
