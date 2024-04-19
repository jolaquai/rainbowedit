using rainbowedit.Exceptions;
using rainbowedit.Extensions;

namespace rainbowedit;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

/// <summary>
/// A single loadout configuration from all possible <see cref="Operator.Primaries"/>, <see cref="Operator.Secondaries"/> (and those two's respective <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> options) and <see cref="Weapon.Gadget"/> combinations.
/// </summary>
public class LoadoutConfiguration
{
    /// <summary>
    /// The <see cref="Defender"/> this configuration applies to.
    /// </summary>
    public Operator Source
    {
        get;
    }
    /// <summary>
    /// A <see cref="WeaponConfiguration"/> detailing the primary <see cref="Weapon"/> and the attachments to use.
    /// </summary>
    public WeaponConfiguration Primary
    {
        get;
    }
    /// <summary>
    /// A <see cref="WeaponConfiguration"/> detailing the secondary <see cref="Weapon"/> and the attachments to use.
    /// </summary>
    public WeaponConfiguration Secondary
    {
        get;
    }
    /// <summary>
    /// A <see cref="Weapon.Gadget"/> enum value identifying the <see cref="Weapon.Gadget"/> to use.
    /// </summary>
    public Weapon.Gadget Gadget
    {
        get; set;
    }

    /// <summary>
    /// Initializes a new <see cref="LoadoutConfiguration"/> object from just an <see cref="Operator"/> to gather values from.
    /// </summary>
    /// <param name="source">The <see cref="Defender"/> to gather random values for this <see cref="LoadoutConfiguration"/> instance's properties from.</param>
    public LoadoutConfiguration(Operator source)
    {
        Source = source;

        var possibleGadgets = Source.Gadgets.GetFlags();
        if (possibleGadgets.Length != 0)
        {
            Gadget = possibleGadgets.Random(Core.Internals.Random);
        }

        Primary = new WeaponConfiguration(Source.Primaries.Random(Core.Internals.Random));
        Secondary = new WeaponConfiguration(Source.Secondaries.Random(Core.Internals.Random));
    }

    /// <summary>
    /// <para>
    /// Initializes a new <see cref="LoadoutConfiguration"/> object from an <see cref="Operator"/> and one each of their <see cref="Operator.Gadgets"/>, <see cref="Operator.Primaries"/> and <see cref="Operator.Secondaries"/>, the latter two of which are used to instantiate randomized <see cref="WeaponConfiguration"/>s.
    /// </para>
    /// <para>
    /// A <see cref="LoadoutOperatorMismatchException"/> is thrown if the passed <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Defender"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="gadget">The <see cref="Weapon.Gadget"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="primary">One of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Primaries"/>.</param>
    /// <param name="secondary">One of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Secondaries"/>.</param>
    /// <exception cref="LoadoutOperatorMismatchException">Thrown if the passed <paramref name="gadget"/> or any of the <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.</exception>
    public LoadoutConfiguration(Operator source, Weapon.Gadget gadget, Weapon primary, Weapon secondary)
    {
        if (source != primary.Source)
        {
            throw new LoadoutOperatorMismatchException(source, primary);
        }
        if (source != secondary.Source)
        {
            throw new LoadoutOperatorMismatchException(source, secondary);
        }
        if (!source.Gadgets.HasFlag(gadget))
        {
            throw new LoadoutOperatorMismatchException(source, gadget);
        }

        Source = source;
        Gadget = gadget;
        Primary = new WeaponConfiguration(primary);
        Secondary = new WeaponConfiguration(secondary);
    }

    /// <summary>
    /// <para>
    /// Initializes a new fully customized <see cref="LoadoutConfiguration"/> object from an <see cref="Operator"/>, one of their <see cref="Operator.Gadgets"/> and one <see cref="WeaponConfiguration"/> identifying the <see cref="Primary"/> and <see cref="Secondary"/> respectively.
    /// </para>
    /// <para>
    /// A <see cref="LoadoutOperatorMismatchException"/> is thrown if the passed <see cref="WeaponConfiguration"/>'s source <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Defender"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="gadget">The <see cref="Weapon.Gadget"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="primaryConfig">A <see cref="WeaponConfiguration"/> instance constructed from one of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Primaries"/>.</param>
    /// <param name="secondaryConfig">A <see cref="WeaponConfiguration"/> instance constructed from one of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Secondaries"/>.</param>
    /// <exception cref="LoadoutOperatorMismatchException">Thrown if the passed <paramref name="gadget"/> or any of the <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.</exception>
    public LoadoutConfiguration(Operator source, Weapon.Gadget gadget, WeaponConfiguration primaryConfig, WeaponConfiguration secondaryConfig)
    {
        if (source != primaryConfig.Source.Source)
        {
            throw new LoadoutOperatorMismatchException(source, primaryConfig.Source);
        }
        if (source != secondaryConfig.Source.Source)
        {
            throw new LoadoutOperatorMismatchException(source, secondaryConfig.Source);
        }
        if (!source.Gadgets.HasFlag(gadget))
        {
            throw new LoadoutOperatorMismatchException(source, gadget);
        }

        Source = source;
        Gadget = gadget;
        Primary = primaryConfig;
        Secondary = secondaryConfig;
    }

    /// <summary>
    /// Constructs a short string identifying the components of this <see cref="LoadoutConfiguration"/>.
    /// </summary>
    /// <returns>A string as described.</returns>
    public string ToShortString()
    {
        var totalWidth = 10 + Siege.LongestWeaponName.Length + Weapon.Resolve(Siege.LongestWeaponName).Type.GetDescription().Length;

        return $"{Source.Nickname.PadRight(Siege.LongestOperatorNickname.Length + 4)}{$"({Primary.Source.Type.GetDescription()}){Primary.Source.Name},".PadRight(totalWidth)} {$"({Secondary.Source.Type.GetDescription()}){Secondary.Source.Name},".PadRight(totalWidth)} {Gadget.GetDescription().PadRight(Siege.LongestGadgetName.Length)}";
    }
    /// <summary>
    /// Constructs a <see cref="string"/> that identifies the components of this <see cref="LoadoutConfiguration"/>. This includes the nickname of a <see cref="Source"/> <see cref="Operator"/>, a <see cref="Primary"/> and <see cref="Secondary"/> weapon's type and name and a <see cref="Gadget"/> name.
    /// </summary>
    /// <returns>The string as described.</returns>
    public override string ToString() => ToShortString();
    /// <summary>
    /// Implicitly converts a <see cref="LoadoutConfiguration"/> to a <see cref="string"/> identifying the components of this <see cref="LoadoutConfiguration"/>.
    /// </summary>
    /// <param name="config">The <see cref="LoadoutConfiguration"/> to convert.</param>
    public static implicit operator string(LoadoutConfiguration config) => config.ToShortString();
    /// <summary>
    /// Constructs a long string identifying the components of this <see cref="LoadoutConfiguration"/> in detail. This includes basically the same information as the string returned by <see cref="ToString()"/>, spanning over multiple lines.
    /// </summary>
    /// <returns>A string as described.</returns>
    public string LongString() => $"""
        Operator: {Source.Nickname}
        Primary:
        {string.Join(Environment.NewLine, Primary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Secondary:
        {string.Join(Environment.NewLine, Secondary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Gadget: {Gadget.GetDescription()}
        """;
}
