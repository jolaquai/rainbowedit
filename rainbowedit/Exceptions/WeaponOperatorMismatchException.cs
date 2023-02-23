using RainbowEdit;

namespace RainbowEdit.Exceptions;

/// <summary>
/// The exception that is thrown when a <see cref="RainbowEdit.Weapon"/> object is attmpted to be brought in connection with an <see cref="RainbowEdit.Operator"/> that it does not belong to.
/// </summary>
internal class WeaponOperatorMismatchException : Exception
{
    public Operator Operator { get; }
    public Weapon Weapon { get; }

    /// <summary>
    /// Instantiates a new <see cref="WeaponOperatorMismatchException"/> with a given <paramref name="operator"/> and <paramref name="weapon"/>.
    /// </summary>
    /// <param name="weapon">The <see cref="RainbowEdit.Weapon"/> that was attempted to be brought in connection with <paramref name="operator"/>.</param>
    /// <param name="operator">The <see cref="RainbowEdit.Operator"/> that was targeted despite the <paramref name="weapon"/> not belonging to them.</param>
    public WeaponOperatorMismatchException(Weapon weapon, Operator @operator)
    {
        Operator = @operator;
        Weapon = weapon;
    }
}
