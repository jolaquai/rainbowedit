using RainbowEdit.Exceptions;
using RainbowEdit.Extensions;

namespace RainbowEdit;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

/// <summary>
/// A single loadout configuration from all possible <see cref="Operator.Primaries"/>, <see cref="Operator.Secondaries"/> (and those two's respective <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> options) and <see cref="Weapon.Gadget"/> combinations.
/// </summary>
public class LoadoutConfiguration
{
    /// <summary>
    /// The <see cref="Operator"/> this configuration applies to.
    /// </summary>
    public Operator Source { get; private set; }
    /// <summary>
    /// A <see cref="WeaponConfiguration"/> detailing the primary <see cref="Weapon"/> and the attachments to use.
    /// </summary>
    public WeaponConfiguration Primary { get; private set; }
    /// <summary>
    /// A <see cref="WeaponConfiguration"/> detailing the secondary <see cref="Weapon"/> and the attachments to use.
    /// </summary>
    public WeaponConfiguration Secondary { get; private set; }
    /// <summary>
    /// A <see cref="Weapon.Gadget"/> enum value identifying the <see cref="Weapon.Gadget"/> to use.
    /// </summary>
    public Weapon.Gadget Gadget { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="LoadoutConfiguration"/> object from just an <see cref="Operator"/> to gather values from.
    /// </summary>
    /// <param name="source">The <see cref="Operator"/> to gather random values for this <see cref="LoadoutConfiguration"/> instance's properties from.</param>
    public LoadoutConfiguration(Operator source)
    {
        Source = source;

        List<Weapon.Gadget> possibleGadgets = Source.Gadgets.GetSetFlags();
        if (possibleGadgets.Any())
        {
            Gadget = possibleGadgets.Random();
        }

        Primary = new(Source.Primaries.Random());
        Secondary = new(Source.Secondaries.Random());
    }

    /// <summary>
    /// <para>
    /// Instantiates a new <see cref="LoadoutConfiguration"/> object from an <see cref="Operator"/> and one each of their <see cref="Operator.Gadgets"/>, <see cref="Operator.Primaries"/> and <see cref="Operator.Secondaries"/>, the latter two of which are used to instantiate randomized <see cref="WeaponConfiguration"/>s.
    /// </para>
    /// <para>
    /// A <see cref="WeaponOperatorMismatchException"/> is thrown if the passed <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Operator"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="gadget">The <see cref="Weapon.Gadget"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="primary">One of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Primaries"/>.</param>
    /// <param name="secondary">One of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Secondaries"/>.</param>
    /// <exception cref="WeaponOperatorMismatchException">Thrown if the passed <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.</exception>
    public LoadoutConfiguration(Operator source, Weapon.Gadget gadget, Weapon primary, Weapon secondary)
    {
        if (source != primary.Source)
        {
            throw new WeaponOperatorMismatchException(primary, source);
        }
        if (source != secondary.Source)
        {
            throw new WeaponOperatorMismatchException(secondary, source);
        }

        Source = source;
        Gadget = gadget;
        Primary = new(primary);
        Secondary = new(secondary);
    }

    /// <summary>
    /// <para>
    /// Instantiates a new fully customized <see cref="LoadoutConfiguration"/> object from an <see cref="Operator"/>, one of their <see cref="Operator.Gadgets"/> and one <see cref="WeaponConfiguration"/> identifying the <see cref="Primary"/> and <see cref="Secondary"/> respectively.
    /// </para>
    /// <para>
    /// A <see cref="WeaponOperatorMismatchException"/> is thrown if the passed <see cref="WeaponConfiguration"/>'s source <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.
    /// </para>
    /// </summary>
    /// <param name="source">The <see cref="Operator"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="gadget">The <see cref="Weapon.Gadget"/> to assign to this <see cref="LoadoutConfiguration"/> instance.</param>
    /// <param name="primaryConfig">A <see cref="WeaponConfiguration"/> instance constructed from one of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Primaries"/>.</param>
    /// <param name="secondaryConfig">A <see cref="WeaponConfiguration"/> instance constructed from one of the <paramref name="source"/> <see cref="Operator"/>'s <see cref="Operator.Secondaries"/>.</param>
    /// <exception cref="WeaponOperatorMismatchException">Thrown if the passed <see cref="Weapon"/> objects do not belong to the <paramref name="source"/> <see cref="Operator"/>.</exception>
    public LoadoutConfiguration(Operator source, Weapon.Gadget gadget, WeaponConfiguration primaryConfig, WeaponConfiguration secondaryConfig)
    {
        if (source != primaryConfig.Source.Source)
        {
            throw new WeaponOperatorMismatchException(primaryConfig.Source, source);
        }
        if (source != secondaryConfig.Source.Source)
        {
            throw new WeaponOperatorMismatchException(secondaryConfig.Source, source);
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
    public string ShortString()
    {
        int totalWidth = 4 + Siege.LongestWeaponName.Length + Weapon.Resolve(Siege.LongestWeaponName).Type.Stringify().Length;
        return $"{{ {$"({Primary.Source.Type.Stringify()}){Primary.Source.Name},".PadRight(totalWidth)} {$"({Secondary.Source.Type.Stringify()}){Secondary.Source.Name},".PadRight(totalWidth)} {Gadget.Stringify().PadRight(Siege.LongestGadgetName.Length)} }}";
    }

    /// <inheritdoc/>
    public override string ToString() => ShortString();
    /// <inheritdoc/>
    public static implicit operator string(LoadoutConfiguration config) => config.ShortString();
    /// <summary>
    /// Constructs a long string identifying the components of this <see cref="LoadoutConfiguration"/> in detail.
    /// </summary>
    /// <returns>A string as described.</returns>
    public string LongString() => $"""
        Operator: {Source.Nickname}
        Primary:
        {string.Join(Environment.NewLine, Primary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Secondary:
        {string.Join(Environment.NewLine, Secondary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Gadget: {Gadget}
        """;
}
