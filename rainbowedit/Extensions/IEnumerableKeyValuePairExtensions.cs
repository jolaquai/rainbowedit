namespace RainbowEdit.Extensions;

/// <summary>
/// Provides extensions for the <see cref="IEnumerable{T}"/> of <see cref="KeyValuePair{TKey, TValue}"/> type and derived types.
/// </summary>
public static class IEnumerableKeyValuePairExtensions
{
    /// <summary>
    /// Reconstructs a <see cref="Dictionary{TKey, TValue}"/> from the given collection of key-value <paramref name="pairs"/>.
    /// </summary>
    /// <typeparam name="TKey">The <see cref="Type"/> of the keys.</typeparam>
    /// <typeparam name="TValue">The <see cref="Type"/> of the value.</typeparam>
    /// <param name="pairs">The sequence of key-value pairs to reconstruct into a <see cref="Dictionary{TKey, TValue}"/>.</param>
    /// <returns>The <see cref="Dictionary{TKey, TValue}"/> as described.</returns>
    public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> pairs)
        where TKey : notnull => pairs.ToDictionary(pair => pair.Key, pair => pair.Value);
}
