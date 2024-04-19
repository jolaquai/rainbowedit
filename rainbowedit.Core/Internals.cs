namespace rainbowedit.Core;

/// <summary>
/// Contains implementation details used by the base library.
/// </summary>
internal static class Internals
{
    /// <summary>
    /// Gets a cached <see cref="System.Random"/> instance.
    /// </summary>
    internal static Random Random { get; } = new Random();
}