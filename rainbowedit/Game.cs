namespace RainbowEdit;

public static class Game
{
    /// <summary>
    /// Contains all Attackers from the game.
    /// </summary>
    public static readonly Attackers Attackers = new();
    /// <summary>
    /// Contains all Defenders from the game.
    /// </summary>
    public static readonly Defenders Defenders = new();

    /// <summary>
    /// Contains all Operators defined in <see cref="Attackers"/> and <see cref="Defenders"/>, concatenated in that order.
    /// </summary>
    public static readonly IEnumerable<Operator> AtkDef = Attackers.Concat(Defenders);
    /// <summary>
    /// Contains all Operators defined in <see cref="Defenders"/> and <see cref="Attackers"/>, concatenated in that order.
    /// </summary>
    public static readonly IEnumerable<Operator> DefAtk = Defenders.Concat(Attackers);

    public static readonly string LongestOperatorNickname = AtkDef.MaxBy(op => op.Nickname.Length).Nickname;
    public static readonly string LongestWeaponName = AtkDef.SelectMany(op => op.Primaries.Concat(op.Secondaries)).MaxBy(wep => wep.Name.Length).Name;
}
