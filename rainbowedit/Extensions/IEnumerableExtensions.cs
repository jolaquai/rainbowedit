namespace rainbowedit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="IEnumerable{T}"/> type and derived types.
/// </summary>
public static class IEnumerableExtensions
{
    /// <summary>
    /// Removes an item from an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The Type of the items in the collection.</typeparam>
    /// <param name="source">The collection to remove <paramref name="item"/> from.</param>
    /// <param name="item">The item to remove.</param>
    /// <returns>A copy of the original collection with <paramref name="item"/> removed if it was present.</returns>
    public static IEnumerable<T> Remove<T>(this IEnumerable<T> source, T item) => source.Except([item]);

    /// <summary>
    /// Returns a random item from an <see cref="IEnumerable{T}"/>.
    /// An attempt is made to do this without enumerating the entire sequence. If this fails, the sequence will be enumerated.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to choose an item from.</param>
    /// <param name="random">A <see cref="System.Random"/> instance to use for generating random numbers. If <see langword="null"/>, a new instance will be created for each call.</param>
    /// <returns>A random item from <paramref name="source"/>.</returns>
    public static T Random<T>(this IEnumerable<T> source, Random? random = null)
    {
        if (source.TryGetNonEnumeratedCount(out var count))
        {
            return source.ElementAt((random ?? Core.Internals.Random).Next(count));
        }
        else
        {
            T[] enumerated = [.. source];
            return enumerated[(random ?? Core.Internals.Random).Next(enumerated.Length)];
        }
    }

    /// <summary>
    /// Returns <paramref name="count"/> random items from an <see cref="IEnumerable{T}"/>, optionally ensuring <paramref name="noDuplicates"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to choose an item from.</param>
    /// <param name="count">The number of items to return.</param>
    /// <param name="noDuplicates">Whether to ensure no duplicate items are returned.</param>
    /// <returns>A random item from <paramref name="source"/>.</returns>
    public static IEnumerable<T> Random<T>(this IEnumerable<T> source, int count, bool noDuplicates = true, Random? random = null)
    {
        if (!noDuplicates)
        {
            for (var i = 0; i < count; i++)
            {
                yield return source.Random(random ?? Core.Internals.Random);
            }
        }
        else
        {
            var exclude = new List<T>();
            for (var i = 0; i < count; i++)
            {
                var item = source.Except(exclude).Random(random ?? Core.Internals.Random);
                exclude.Add(item);
                yield return item;
            }
        }
    }

    /// <summary>
    /// Determines whether a sequence contains a specified element by using a specified comparer function.
    /// </summary>
    /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to search.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <param name="comparer">The function that compares elements and ultimately determines whether <paramref name="source"/> contains <paramref name="value"/>.</param>
    /// <returns>A value indicating whether <paramref name="source"/> contains <paramref name="value"/>.</returns>
    public static bool Contains<T>(this IEnumerable<T> source, T value, Func<T, T, bool> comparer)
    {
        foreach (var item in source)
        {
            if (comparer(item, value))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Divides a sequence into <paramref name="count"/> smaller sequences of equal length (or near-equal, if <paramref name="source"/>'s length is not divisible by <paramref name="count"/>).
    /// </summary>
    /// <typeparam name="T">The type of the elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to divide.</param>
    /// <param name="count">The number of smaller sequences to divide <paramref name="source"/> into.</param>
    /// <returns>A sequence of <paramref name="count"/> sequences of <typeparamref name="T"/> containing all elements of <paramref name="source"/>.</returns>
    public static IEnumerable<IEnumerable<T>> Divide<T>(this IEnumerable<T> source, int count)
    {
        var sourceList = source.ToList();
        var chunkSize = (int)Math.Ceiling((double)sourceList.Count / count);
        return source.Chunk(chunkSize);
    }

    /// <inheritdoc cref="Enumerable.Concat{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/>
    public static IEnumerable<T> Concat<T>(this IEnumerable<T> first, params IEnumerable<T> second) => [.. first, .. second];
}
