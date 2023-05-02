using System.Collections.Generic;

namespace RainbowEdit.Extensions;

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
    public static IEnumerable<T> Remove<T>(this IEnumerable<T> source, T item) => source.Except(new List<T>() { item });

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

    /// <summary>
    /// Returns <paramref name="count"/> random items from an <see cref="IEnumerable{T}"/>, optionally ensuring <paramref name="noDuplicates"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items in <paramref name="source"/>.</typeparam>
    /// <param name="source">The sequence to choose an item from.</param>
    /// <param name="count">The number of items to return.</param>
    /// <param name="noDuplicates">Whether to ensure no duplicate items are returned.</param>
    /// <returns>A random item from <paramref name="source"/>.</returns>
    public static IEnumerable<T> Random<T>(this IEnumerable<T> source, int count, bool noDuplicates = true)
    {
        if (!noDuplicates)
        {
            for (var i = 0; i < count; i++)
            {
                yield return source.Random();
            }
        }
        else
        {
            var exclude = new List<T>();
            for (var i = 0; i < count; i++)
            {
                var item = source.Except(exclude).Random();
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
}
