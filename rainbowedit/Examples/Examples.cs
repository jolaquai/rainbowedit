using RainbowEdit;
using RainbowEdit.Extensions;

namespace RainbowEdit;

/// <summary>
/// A number of examples you can use to get the hang of how the library works or what you could do with it.
/// </summary>
public static class Examples
{
    /// <summary>
    /// Calculates the shots it takes to kill an <paramref name="operator"/> using a given <paramref name="weaponConfig"/>, optionally considering the <c>20</c> extra HP one of <see cref="Defenders.Rook"/>'s <i>Armor Plates</i> gives.
    /// </summary>
    /// <param name="operator">The <see cref="Operator"/> to calculate the shots to kill for.</param>
    /// <param name="weaponConfig">The <see cref="WeaponConfiguration"/> that is used to shoot the <paramref name="operator"/>.</param>
    /// <param name="armorPlate">Whether to consider the <c>20</c> extra HP one of <see cref="Defenders.Rook"/>'s <i>Armor Plates</i> gives.</param>
    /// <returns></returns>
    public static int ShotsToKill(Operator @operator, WeaponConfiguration weaponConfig, bool armorPlate = false)
    {
        var damage = weaponConfig.Barrel == Weapon.Barrel.ExtendedBarrel.Stringify() ? weaponConfig.Source.ExtendedBarrelDamage : weaponConfig.Source.Damage;

        return (int)Math.Ceiling((@operator.HP + (armorPlate ? 20 : 0)) / (double)damage);
    }

    /// <summary>
    /// Groups all <see cref="Operator"/>s in the order of <see cref="Siege.DefAtk"/> by which <see cref="Weapon.WeaponType"/>s they have access to.
    /// </summary>
    /// <returns>A <see cref="Dictionary{TKey, TValue}"/> where the keys are <see cref="Weapon.WeaponType"/> enum values and the values are a collection of <see cref="Operator"/> objects.</returns>
    public static Dictionary<Weapon.WeaponType, IEnumerable<Operator>> OperatorsByWeaponType()
    {
        Dictionary<Weapon.WeaponType, IEnumerable<Operator>> ret = new();
        foreach (var @enum in Enum.GetValues<Weapon.WeaponType>())
        {
            ret.Add(@enum, Siege.DefAtk.Where(op => op.Primaries.Concat(op.Secondaries).Any(wep => wep.Type == @enum)));
        }
        return ret;
    }

    /// <summary>
    /// Writes all specialties and the <see cref="Operator"/> that have them assigned to the <see cref="Console"/>.
    /// </summary>
    public static void WriteSpecialtiesAndOperators()
    {
        var totalWidth = Defenders.Specialties.Max(s => s.Name.Length) + 1;
        foreach (var specialty in Defenders.Specialties)
        {
            Console.WriteLine($"{(specialty.Name + ":").PadRight(totalWidth)} {string.Join(", ", specialty.GetOperators())}");
        }
        foreach (var specialty in Attackers.Specialties)
        {
            Console.WriteLine($"{(specialty.Name + ":").PadRight(totalWidth)} {string.Join(", ", specialty.GetOperators())}");
        }
    }
}
