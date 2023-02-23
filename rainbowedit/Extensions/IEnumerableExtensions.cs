namespace RainbowEdit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="IEnumerable{T}"/> type and derived types.
/// </summary>
public static class IEnumerableExtensions
{
    /// <summary>
    /// Returns a random item from an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to choose an item from.</param>
    /// <returns>A random item from <paramref name="source"/>.</returns>
    public static T Random<T>(this IEnumerable<T> source)
    {
        List<T> enumerated = new(source);
        return enumerated[new Random().Next(enumerated.Count)];
    }
}
