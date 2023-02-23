using System.Data.Common;

using RainbowEdit;
using RainbowEdit.Extensions;

using static RainbowEdit.Weapon;

namespace TestConsole;

public static class TestConsole
{
    static void Main()
    {
        List<IEnumerable<Operator>> opClasses = new() { Siege.Defenders, Siege.Attackers };
        for (int i = 0; i < opClasses.Count; i++)
        {
            IEnumerable<Operator> opClass = opClasses[i];
            Console.WriteLine(i == 0 ? "DEFENDERS" : "\r\nATTACKERS");
            Console.WriteLine("=========");

            IEnumerable<Weapon> data = opClass.SelectMany(op => op.Primaries.Concat(op.Secondaries).Where(wep => wep.Barrels.HasFlag(Weapon.Barrel.ExtendedBarrel)));

            foreach (KeyValuePair<WeaponType, IEnumerable<Weapon>> wepGroup in data.DistinctBy(wep => wep.Name).OrderByDescending(wep => wep.Damage).Aggregate(new Dictionary<Weapon.WeaponType, IEnumerable<Weapon>>(), (seed, weapon) =>
            {
                if (seed.ContainsKey(weapon.Type))
                {
                    seed[weapon.Type] = seed[weapon.Type].Concat(new List<Weapon>() { weapon });
                }
                else
                {
                    seed[weapon.Type] = new List<Weapon>() { weapon };
                }
                return seed;
            }))
            {
                Console.WriteLine();
                string type = wepGroup.Key.Stringify().ToUpper();
                Console.WriteLine(type);
                Console.WriteLine(string.Join("", Enumerable.Repeat("*", type.Length)));
                Console.WriteLine(string.Join("\r\n", wepGroup.Value.Select(wep => $"{wep.Name.PadRight(Siege.LongestWeaponName.Length)} {{ Damage = {wep.Damage}, ExtendedBarrelDamage = {wep.ExtendedBarrelDamage} }}")));
            }
        }
    }
}
