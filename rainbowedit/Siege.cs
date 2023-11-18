using rainbowedit.Extensions;

namespace rainbowedit;

#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

/// <summary>
/// Base class for all information accessible from the library.
/// </summary>
public static class Siege
{
    internal static class Internals
    {
        internal static readonly Random _random = new Random();
    }

    /// <summary>
    /// Contains all <see cref="rainbowedit.Attackers"/> from the game.
    /// </summary>
    public static List<Operator> Attackers { get; } = rainbowedit.Attackers.Operators;
    /// <summary>
    /// Contains all <see cref="rainbowedit.Defenders"/> from the game.
    /// </summary>
    public static List<Operator> Defenders { get; } = rainbowedit.Defenders.Operators;

    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Attackers"/> and <see cref="Defenders"/>, concatenated in that order.
    /// </summary>
    public static IEnumerable<Operator> AtkDef { get; } = Attackers.Concat(Defenders);
    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Defenders"/> and <see cref="Attackers"/>, concatenated in that order.
    /// </summary>
    public static IEnumerable<Operator> DefAtk { get; } = Defenders.Concat(Attackers);

    /// <summary>
    /// The longest <see cref="Operator.Nickname"/> there is.
    /// </summary>
    public static string LongestOperatorNickname { get; } = AtkDef.MaxBy(op => op.Nickname.Length).Nickname;
    /// <summary>
    /// The longest <see cref="Weapon.Name"/> there is.
    /// </summary>
    public static string LongestWeaponName { get; } = AtkDef.SelectMany(op => op.Primaries.Concat(op.Secondaries)).MaxBy(wep => wep.Name.Length).Name;
    /// <summary>
    /// The longest <see cref="Weapon.Gadget"/> name there is.
    /// </summary>
    public static string LongestGadgetName { get; } = Enum.GetValues<Weapon.Gadget>().Select(val => val.GetDescription()).MaxBy(gadget => gadget.Length);
}
