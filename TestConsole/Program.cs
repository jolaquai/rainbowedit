using System.Data.Common;

using RainbowEdit;
using RainbowEdit.Extensions;

namespace TestConsole;

public static class TestConsole
{
    static void Main(string[] args)
    {
        List<IEnumerable<Operator>> opClasses = new List<IEnumerable<Operator>>() { Game.Defenders, Game.Attackers };
        for (int i = 0; i < opClasses.Count; i++)
        {
            IEnumerable<Operator> opClass = opClasses[i];
            Console.WriteLine(i == 0 ? "DEFENDERS" : "\r\nATTACKERS");
            Console.WriteLine("=========");

            var data = opClass.SelectMany(op => op.Primaries.Concat(op.Secondaries).Where(wep => wep.Barrels.HasFlag(Weapon.Barrel.ExtendedBarrel)));

            foreach (var wepGroup in data.DistinctBy(wep => wep.Name).OrderByDescending(wep => wep.Damage).Aggregate(new Dictionary<Weapon.WeaponType, IEnumerable<Weapon>>(), (seed, weapon) =>
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
                Console.WriteLine(string.Join("\r\n", wepGroup.Value.Select(wep => $"{wep.Name.PadRight(Game.LongestWeaponName.Length)} {{ Damage = {wep.Damage}, ExtendedBarrelDamage = {wep.ExtendedBarrelDamage} }}")));
            }
        }
    }
}
