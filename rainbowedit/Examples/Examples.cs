using rainbowedit.Extensions;

namespace rainbowedit;

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
        var damage = weaponConfig.Barrel == Weapon.Barrel.ExtendedBarrel.GetDescription() ? weaponConfig.Source.ExtendedBarrelDamage : weaponConfig.Source.Damage;

        return (int)Math.Ceiling((@operator.HP + (armorPlate ? 20 : 0)) / (double)damage);
    }

    /// <summary>
    /// Groups all <see cref="Operator"/>s in the order of <see cref="Siege.DefAtk"/> by which <see cref="Weapon.WeaponType"/>s they have access to.
    /// </summary>
    /// <returns>A <see cref="Dictionary{TKey, TValue}"/> where the keys are <see cref="Weapon.WeaponType"/> enum values and the values are a collection of <see cref="Operator"/> objects.</returns>
    public static Dictionary<Weapon.WeaponType, IEnumerable<Operator>> OperatorsByWeaponType()
    {
        Dictionary<Weapon.WeaponType, IEnumerable<Operator>> ret = [];
        foreach (var @enum in Enum.GetValues<Weapon.WeaponType>())
        {
            ret.Add(@enum, Siege.DefAtk.Where(op => op.Primaries.Concat(op.Secondaries).Any(wep => wep.Type == @enum)));
        }
        return ret;
    }

    /// <summary>
    /// Writes all specialties and the <see cref="Operator"/>s that have them assigned to the <see cref="Console"/>.
    /// </summary>
    public static void WriteSpecialtiesAndOperators()
    {
        var totalWidth = Defenders.Specialties.All.Max(s => s.Name.Length) + 1;
        foreach (var specialty in Defenders.Specialties.All)
        {
            Console.WriteLine($"{(specialty.Name + ":").PadRight(totalWidth)} {string.Join(", ", specialty.GetOperators())}");
        }
        foreach (var specialty in Attackers.Specialties.All)
        {
            Console.WriteLine($"{(specialty.Name + ":").PadRight(totalWidth)} {string.Join(", ", specialty.GetOperators())}");
        }
    }

    /// <summary>
    /// Creates a sequence of <see cref="Operator"/> instances that have access to a given <see cref="Weapon.WeaponType"/>.
    /// </summary>
    /// <param name="type">The <see cref="Weapon.WeaponType"/> to filter by.</param>
    /// <returns>The sequence of <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> OperatorsWithWeaponOfType(Weapon.WeaponType type)
    {
        return Siege.DefAtk.Where(op => op.Primaries.Concat(op.Secondaries).Any(wep => wep.Type == type));
    }

    /// <summary>
    /// Creates a sequence of <see cref="Weapon"/> instances that are of a given <see cref="Weapon.WeaponType"/>.
    /// </summary>
    /// <param name="type">The <see cref="Weapon.WeaponType"/> to filter by.</param>
    /// <returns>The sequence of <see cref="Weapon"/>s.</returns>
    public static IEnumerable<Weapon> WeaponsOfType(Weapon.WeaponType type)
    {
        return Siege.DefAtk.SelectMany(op => op.Primaries.Concat(op.Secondaries).Where(wep => wep.Type == type))
                           .DistinctBy(wep => wep.Name);
    }
}
