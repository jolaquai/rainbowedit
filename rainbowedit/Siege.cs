using rainbowedit.Extensions;

namespace rainbowedit;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

/// <summary>
/// General information.
/// </summary>
public static class Siege
{
    /// <summary>
    /// Contains all <see cref="rainbowedit.Attackers"/> from the game.
    /// </summary>
    public static ImmutableArray<Attacker> Attackers => rainbowedit.Attackers.All;
    /// <summary>
    /// Contains all <see cref="rainbowedit.Defenders"/> from the game.
    /// </summary>
    public static ImmutableArray<Defender> Defenders => rainbowedit.Defenders.All;

    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Attackers"/> and <see cref="Defenders"/>, concatenated in that order.
    /// </summary>
    public static IEnumerable<Operator> AtkDef => ((IEnumerable<Operator>)Attackers).Concat(Defenders);
    /// <summary>
    /// Contains all <see cref="Operator"/>s defined in <see cref="Defenders"/> and <see cref="Attackers"/>, concatenated in that order.
    /// </summary>
    public static IEnumerable<Operator> DefAtk => ((IEnumerable<Operator>)Defenders).Concat(Attackers);

    /// <summary>
    /// The longest <see cref="Operator.Nickname"/> there is.
    /// </summary>
    public static string LongestOperatorNickname => AtkDef.MaxBy(op => op.Nickname.Length).Nickname;
    /// <summary>
    /// The longest <see cref="Weapon.Name"/> there is.
    /// </summary>
    public static string LongestWeaponName => AtkDef.SelectMany(op => op.Primaries.Concat(op.Secondaries)).MaxBy(wep => wep.Name.Length).Name;
    /// <summary>
    /// The longest <see cref="Weapon.Gadget"/> name there is.
    /// </summary>
    public static string LongestGadgetName => Enum.GetValues<Weapon.Gadget>().Select(val => val.GetDescription()).MaxBy(gadget => gadget.Length)!;

    /// <summary>
    /// A method that is registered to be called by the runtime when the assembly is loaded.
    /// This forces the library to initialize most static classes present by accessing their properties.
    /// </summary>
    [System.Runtime.CompilerServices.ModuleInitializer]
    internal static void LibInit()
    {
        // This forces Defenders and Attackers to be initialized
        _ = Randomizers.GetRandomAttacker().GetRandomLoadout();
        _ = Randomizers.GetRandomDefender().GetRandomLoadout();
    }
}
