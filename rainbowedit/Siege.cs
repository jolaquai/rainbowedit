using rainbowedit.Extensions;

namespace rainbowedit;

#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

/// <summary>
/// Base class for all information accessible from the library.
/// </summary>
public static class Siege
{
    /// <summary>
    /// Contains all <see cref="rainbowedit.Attackers"/> from the game.
    /// </summary>
    public static readonly List<Operator> Attackers = rainbowedit.Attackers.Operators;
    /// <summary>
    /// Contains all <see cref="rainbowedit.Defenders"/> from the game.
    /// </summary>
    public static readonly List<Operator> Defenders = rainbowedit.Defenders.Operators;

    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Attackers"/> and <see cref="Defenders"/>, concatenated in that order.
    /// </summary>
    public static readonly IEnumerable<Operator> AtkDef = Attackers.Concat(Defenders);
    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Defenders"/> and <see cref="Attackers"/>, concatenated in that order.
    /// </summary>
    public static readonly IEnumerable<Operator> DefAtk = Defenders.Concat(Attackers);

    /// <summary>
    /// The longest <see cref="Operator.Nickname"/> there is.
    /// </summary>
    public static readonly string LongestOperatorNickname = AtkDef.MaxBy(op => op.Nickname.Length).Nickname;
    /// <summary>
    /// The longest <see cref="Weapon.Name"/> there is.
    /// </summary>
    public static readonly string LongestWeaponName = AtkDef.SelectMany(op => op.Primaries.Concat(op.Secondaries)).MaxBy(wep => wep.Name.Length).Name;
    /// <summary>
    /// The longest <see cref="Weapon.Gadget"/> name there is.
    /// </summary>
    public static readonly string LongestGadgetName = Enum.GetValues<Weapon.Gadget>().Select(val => val.GetDescription()).MaxBy(gadget => gadget.Length);
}
