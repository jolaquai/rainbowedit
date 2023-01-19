using System.Text;

using RainbowEdit.Extensions;

namespace RainbowEdit;

public static class Randomizers
{
    public static class Challenges
    {
        public static int ChallengeObjectiveMultiplier = 3;

        public static string WinRoundsWith()
        {
            string s = "Win {0} rounds with {1}, {2}, {3} or {4}.";
            List<Operator> operators = new()
            {
                GetRandomAttacker()
            };
            operators.Add(GetRandomAttacker(op => !operators.Contains(op)));
            operators.Add(GetRandomDefender(op => !operators.Contains(op)));
            operators.Add(GetRandomDefender(op => !operators.Contains(op)));
            return string.Format(s, new Random().Next(1, 3) * ChallengeObjectiveMultiplier, operators[0], operators[1], operators[2], operators[3]);
        }

        public static string WeaponTypeEliminations() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with {Enum.GetValues<Weapon.WeaponType>().Select(type => type.ToString()).Random()}s.";

        public static string OrganizationActiveDuty()
        {
            string org = Game.AtkDef.Select(op => op.Organization).Random();
            List<string> ops = Game.AtkDef.Where(op => op.Organization == org).Select(op => op.Nickname).ToList();

            if (ops.Count == 1)
            {
                return $"{org} Active Duty: Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds with {ops[0]}.";
            }
            else
            {
                string joined = string.Join(", ", ops.Take(new Range(0, ops.Count - 1)));
                return $"{org} Active Duty: Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds with {joined} or {ops[^1]}.";
            }
        }

        public static string AntiProjectile() => $"Destroy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Attacker projectiles using Jäger's ADS-Mk IV, Wamai's Mag-NET Systems or Aruni's Surya Gates.";
        public static string AreaDenial() => $"Damage or perform area denial against {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents using Smoke's Z8 Gas Grenades, Tachanka's Shumikha Grenade Launcher, Goyo's Volcán Canisters, Capitão's Asphyxiating Bolts or Gridlock's Trax Stingers.";
        public static string ChemicalBonds() => $"Eliminate, incapacitate or damage {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents with Smoke's Z8 Gas Grenades or Lesion's Gu Mines. Eliminations and incapacitations count as 2 towards this.";
        public static string DeployCams() => $"Deploy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Bulletproof Cameras, Valkyrie's Black Eyes, Maestro's Evil Eyes or Zero's Argus Cameras.";
        public static string DestroyObservation() => $"Destroy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Defender cameras, Bulletproof Cameras, Valkyrie's Black Eyes, Echo's Yokai, Maestro's Evil Eyes or drones hacked by Mozzie's Pest as an Attacker.";
        public static string Disorient() => $"Disorient {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Zofia's Grzmot Grenades, Nomad's Airjabs, Echo's Yokai Sonic Burst, Ela's Grzmot Mines or Oryx's Remah Dash.";
        public static string ExplosiveKills() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Impact Grenades, Nitro Cells, Frag Grenades, Fuze's Cluster Charges, Flores's RCE-Ratero Charges, Kapkan's Entry Denial Devices or Thorn's Razorbloom Shells.";
        public static string HardBreach() => $"Breach {new Random().Next(1, 4) * ChallengeObjectiveMultiplier} reinforced walls with Thermite's Exothermic Charges, Hibana's X-KAIROs, Ace's S.E.L.M.A. Aqua Breachers or Hard Breach Charges.";
        public static string Headshots() => $"Headshot {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents.";
        public static string Heal() => $"Heal {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} teammates with Finka's Adrenal Surge, Doc's Stim Pistol or Thunderbird's KÓNA Stations. Revives count as 2 towards this.";
        public static string Kills() => $"Kill {new Random().Next(2, 5) * ChallengeObjectiveMultiplier} opponents.";
        public static string Matches() => $"{(new Random().Next(2) == 0 ? "Play" : "Win")} {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} {(new Random().Next(4) == 0 ? "Ranked" : (new Random().Next(3) == 0 ? "Unranked" : "Casual"))} matches.";
        public static string Reveal() => $"Reveal {new Random().Next(2, 5) * ChallengeObjectiveMultiplier} opponents by scanning them in cameras or pinging their special abilities.";
        public static string Role() => $"Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds as a{(new Random().Next(2) == 0 ? "n Attacker" : " Defender")}.";
        public static string Stun() => $"Stun {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Stun Grenades, Blitz's G52-Tactical Shield or Ying's Candelas.";
        public static string Suppressed() => $"Eliminate {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents with suppressed weapons.";
        public static string TechAttackAtk() => $"Destroy, disable or render {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Defender gadgets useless using Thatcher's EG Mk 0-EMP Grenades, Twitch's RSD Model 1 Shock Drones, Kali's LV Explosive Lance or Zero's Argus Cameras.";
        public static string TechAttackDef() => $"Destroy, disable or render {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Attacker gadgets useless using Mute's GC90 Signal Disruptors, Bandit's CED-1 Shock Wires or Kaid's Rtila Electroclaws or by hacking Attacker drones using Mozzie's Pest.";
        public static string Trapper() => $"Eliminate or incapacitate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Kapkan's Entry Denial Devices, Frost's Welcome Mats, Goyo's Volcán Canisters, Thorn's Razorbloom Shells or during and after they are tracked by Alibi's Primas. Eliminations count as 2 towards this.";
        public static string UnauthorizedAccess() => $"Hack into Defender cameras as Dokkaebi or hack an Attacker drone as Mozzie {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} times.";
        public static string Wallbangs() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents through walls.";
    }

    /// <summary>
    /// Gets a random <see cref="Operator"/>.
    /// </summary>
    /// <returns>A random <see cref="Operator"/>.</returns>
    public static Operator GetRandomOperator() => Game.AtkDef.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Operator"/>s defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Operator"/> to choose from.</param>
    /// <returns>A random <see cref="Operator"/>.</returns>
    public static Operator GetRandomOperator(Func<Operator, bool> filter) => Game.AtkDef.Where(filter).Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Defenders"/>.
    /// </summary>
    /// <returns>A random Defender's <see cref="Operator"/>.</returns>
    public static Operator GetRandomDefender() => Game.Defenders.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Defenders"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of Defenders to choose from.</param>
    /// <returns>A random Defender's <see cref="Operator"/>.</returns>
    public static Operator GetRandomDefender(Func<Operator, bool> filter) => Game.Defenders.Where(filter).Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Attackers"/>.
    /// </summary>
    /// <returns>A random Attacker's <see cref="Operator"/>.</returns>
    public static Operator GetRandomAttacker() => Game.Attackers.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Attackers"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of Attackers to choose from.</param>
    /// <returns>A random Attacker's <see cref="Operator"/>.</returns>
    public static Operator GetRandomAttacker(Func<Operator, bool> filter) => Game.Attackers.Where(filter).Random();
}
