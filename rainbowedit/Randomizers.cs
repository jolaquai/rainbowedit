using rainbowedit.Extensions;

namespace rainbowedit;

/// <summary>
/// A collection of methods that fetch random information or configurations from the model classes in <see cref="Siege"/>.
/// <para/>Where a collection of <see cref="Operator"/>s is returned, the collection is guaranteed to contain no duplicates and the contained <see cref="Operator"/>s are sorted according to their in-game appearance; also see <see cref="Operator.Comparer"/> and <see cref="Operator.Sort(IEnumerable{Operator})"/>.
/// </summary>
public static class Randomizers
{
    /// <summary>
    /// A collection of methods that generate random challenges in the style of <i>Ubisoft Connect</i> challenges.
    /// </summary>
    public static class Challenges
    {
        /// <summary>
        /// The factor that is used to calculate the amount of... things you have to do.
        /// </summary>
        public static int ChallengeObjectiveMultiplier = 3;

        /// <summary>
        /// Constructs a string describing the challenge of winning rounds using two specific <see cref="Attackers"/> and <see cref="Defenders"/> each.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string WinRoundsWith()
        {
            var s = "Win {0} rounds with {1}, {2}, {3} or {4}.";
            List<Operator> operators = new()
            {
                GetRandomAttacker()
            };
            operators.Add(GetRandomAttacker(op => !operators.Contains(op)));
            operators.Add(GetRandomDefender(op => !operators.Contains(op)));
            operators.Add(GetRandomDefender(op => !operators.Contains(op)));
            return string.Format(s, new Random().Next(1, 3) * ChallengeObjectiveMultiplier, operators[0], operators[1], operators[2], operators[3]);
        }

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents using <see cref="Weapon"/>s of a specific <see cref="Weapon.WeaponType"/>.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string WeaponTypeEliminations() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with {Enum.GetValues<Weapon.WeaponType>().Select(type => type.ToString()).Random()}s.";

        /// <summary>
        /// Constructs a string describing the challenge of winning rounds using <see cref="Operator"/>s belonging to a specific <see cref="Operator.Organization"/>.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string OrganizationActiveDuty()
        {
            var org = Siege.AtkDef.Select(op => op.Organization).Random();
            var ops = Siege.AtkDef.Where(op => op.Organization == org).Select(op => op.Nickname).ToList();

            if (ops.Count == 1)
            {
                return $"{org} Active Duty: Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds with {ops[0]}.";
            }
            else
            {
                var joined = string.Join(", ", ops.Take(new Range(0, ops.Count - 1)));
                return $"{org} Active Duty: Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds with {joined} or {ops[^1]}.";
            }
        }

        /// <summary>
        /// Constructs a string describing the challenge of destroying <see cref="Attackers"/>' projectiles or throwables using anti-projectile special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string AntiProjectile() => $"Destroy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Attacker projectiles using Jäger's ADS-Mk IV, Wamai's Mag-NET Systems or Aruni's Surya Gates.";

        /// <summary>
        /// Constructs a string describing the challenge of damaging or performing area denial against opponents using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string AreaDenial() => $"Damage or perform area denial against {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents using Smoke's Z8 Gas Grenades, Tachanka's Shumikha Grenade Launcher, Goyo's Volcán Canisters, Capitão's Asphyxiating Bolts or Gridlock's Trax Stingers.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating, putting in DBNO or damaging opponents using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string ChemicalBonds() => $"Eliminate, incapacitate or damage {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents with Smoke's Z8 Gas Grenades, Lesion's Gu Mines or Gridlock's Trax Stingers. Eliminations and incapacitations count as 2 towards this.";

        /// <summary>
        /// Constructs a string describing the challenge of deploying cameras or suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string DeployCams() => $"Deploy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Bulletproof Cameras, Valkyrie's Black Eyes, Maestro's Evil Eyes or Zero's Argus Cameras.";

        /// <summary>
        /// Constructs a string describing the challenge of destroying or rendering observation tools useless using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string DestroyObservation() => $"Destroy {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Defender cameras, Bulletproof Cameras, Valkyrie's Black Eyes, Echo's Yokai, Maestro's Evil Eyes or drones hacked by Mozzie's Pest as an Attacker.";

        /// <summary>
        /// Constructs a string describing the challenge of disorienting opponents using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Disorient() => $"Disorient {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Zofia's Grzmot Grenades, Nomad's Airjabs, Echo's Yokai Sonic Burst, Ela's Grzmot Mines or Oryx's Remah Dash.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents using explosive gadgets or explosive special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string ExplosiveKills() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Impact Grenades, Nitro Cells, Frag Grenades, Fuze's Cluster Charges, Flores's RCE-Ratero Charges, Kapkan's Entry Denial Devices or Thorn's Razorbloom Shells.";

        /// <summary>
        /// Constructs a string describing the challenge of breaching reinforcements ("hard-breaching") using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string HardBreach() => $"Breach {new Random().Next(1, 4) * ChallengeObjectiveMultiplier} reinforced walls with Thermite's Exothermic Charges, Hibana's X-KAIROs, Ace's S.E.L.M.A. Aqua Breachers or Hard Breach Charges.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents using headshots.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Headshots() => $"Headshot {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents.";

        /// <summary>
        /// Constructs a string describing the challenge of healing or reviving teammates using suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Heal() => $"Heal {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} teammates with Finka's Adrenal Surge, Doc's Stim Pistol or Thunderbird's KÓNA Stations. Revives count as 2 towards this.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Kills() => $"Kill {new Random().Next(2, 5) * ChallengeObjectiveMultiplier} opponents.";

        /// <summary>
        /// Constructs a string describing the challenge of playing/winning Ranked/Unranked/Casual matches.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Matches() => $"{(new Random().Next(2) == 0 ? "Play" : "Win")} {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} {(new Random().Next(4) == 0 ? "Ranked" : (new Random().Next(3) == 0 ? "Unranked" : "Casual"))} matches.";

        /// <summary>
        /// Constructs a string describing the challenge of revealing opponents by scanning them in observation tools or pinging their special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Reveal() => $"Reveal {new Random().Next(4, 7) * ChallengeObjectiveMultiplier} opponents by scanning them in cameras or pinging their special abilities.";

        /// <summary>
        /// Constructs a string describing the challenge of winning rounds as a specific <see cref="Operator"/> class.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Role() => $"Win {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} rounds as a{(new Random().Next(2) == 0 ? "n Attacker" : " Defender")}.";

        /// <summary>
        /// Constructs a string describing the challenge of stunning / blinding opponents using stun grenades or suitable special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Stun() => $"Stun {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Stun Grenades, Blitz's G52-Tactical Shield or Ying's Candelas.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents using suppressed weapons.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Suppressed() => $"Eliminate {new Random().Next(2, 4) * ChallengeObjectiveMultiplier} opponents with suppressed weapons.";

        /// <summary>
        /// Constructs a string describing the challenge of destroying, disabling or rendering <see cref="Defenders"/>' gadgets useless using suitable <see cref="Attackers"/>' special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string TechAttackAtk() => $"Destroy, disable or render {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Defender gadgets useless using Thatcher's EG Mk 0-EMP Grenades, Twitch's RSD Model 1 Shock Drones, Kali's LV Explosive Lance or Zero's Argus Cameras.";

        /// <summary>
        /// Constructs a string describing the challenge of destroying, disabling or rendering <see cref="Attackers"/>' gadgets useless using suitable <see cref="Defenders"/>' special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string TechAttackDef() => $"Destroy, disable or render {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} Attacker gadgets useless using Mute's GC90 Signal Disruptors, Bandit's CED-1 Shock Wires or Kaid's Rtila Electroclaws or by hacking Attacker drones using Mozzie's Pest.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating or putting in DBNO opponents using suitable trap-like special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Trapper() => $"Eliminate or incapacitate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents with Kapkan's Entry Denial Devices, Frost's Welcome Mats, Goyo's Volcán Canisters, Thorn's Razorbloom Shells or during and after they are tracked by Alibi's Primas. Eliminations count as 2 towards this.";

        /// <summary>
        /// Constructs a string describing the challenge of hacking <see cref="Attackers"/>' drones or <see cref="Defenders"/>' observation tools or special abilities.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string UnauthorizedAccess() => $"Hack Attacker drones as Mozzie, hack into Defender observation tools as Dokkaebi or convert Defender special abilities using Brava's Kludge Drones {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} times.";

        /// <summary>
        /// Constructs a string describing the challenge of eliminating opponents through penetrable surfaces.
        /// </summary>
        /// <returns>A string as described.</returns>
        public static string Wallbangs() => $"Eliminate {new Random().Next(1, 3) * ChallengeObjectiveMultiplier} opponents through penetrable surfaces.";
    }

    #region Operator
    /// <summary>
    /// Gets a random <see cref="Operator"/>.
    /// </summary>
    /// <returns>A random <see cref="Operator"/>.</returns>
    public static Operator GetRandomOperator() => Siege.AtkDef.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Operator"/>s defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Operator"/> to choose from.</param>
    /// <returns>A random <see cref="Operator"/>.</returns>
    public static Operator GetRandomOperator(Func<Operator, bool> filter) => Siege.AtkDef.Where(filter).Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> while excluding any number of them.
    /// </summary>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A random <see cref="Operator"/>.</returns>
    public static Operator GetRandomOperator(params Operator[] filter) => Siege.AtkDef.Except(filter).Random();

    /// <summary>
    /// Gets a number of random <see cref="Operator"/>s.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <returns>A collection of random <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomOperators(int count) => Siege.AtkDef.Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Operator"/> from a pool of <see cref="Operator"/>s defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Operator"/> to choose from.</param>
    /// <returns>A collection of random <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomOperators(int count, Func<Operator, bool> filter) => Siege.AtkDef.Where(filter).Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Operator"/> while excluding any number of them.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A collection of random <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomOperators(int count, params Operator[] filter) => Siege.AtkDef.Except(filter).Random(count).Order(Operator.Comparer);
    #endregion

    #region Defender
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Defenders"/>.
    /// </summary>
    /// <returns>A random Defender's <see cref="Operator"/>.</returns>
    public static Operator GetRandomDefender() => Siege.Defenders.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Defenders"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Defenders"/> to choose from.</param>
    /// <returns>A random Defender's <see cref="Operator"/>.</returns>
    public static Operator GetRandomDefender(Func<Operator, bool> filter) => Siege.Defenders.Where(filter).Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Defenders"/> while excluding any number of them.
    /// </summary>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A random Defender's <see cref="Operator"/>.</returns>
    public static Operator GetRandomDefender(params Operator[] filter) => Siege.Defenders.Except(filter).Random();

    /// <summary>
    /// Gets a number of random <see cref="Operator"/>s from the <see cref="Defenders"/>.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <returns>A collection of random Defenders' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomDefenders(int count) => Siege.Defenders.Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Operator"/>s from a pool of <see cref="Defenders"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Defenders"/> to choose from.</param>
    /// <returns>A collection of random Defenders' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomDefenders(int count, Func<Operator, bool> filter) => Siege.Defenders.Where(filter).Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Defenders"/>s while excluding any number of them.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A collection of random Defenders' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomDefenders(int count, params Operator[] filter) => Siege.Defenders.Except(filter).Random(count).Order(Operator.Comparer);
    #endregion

    #region Attacker
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Attackers"/>.
    /// </summary>
    /// <returns>A random Attacker's <see cref="Operator"/>.</returns>
    public static Operator GetRandomAttacker() => Siege.Attackers.Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from a pool of <see cref="Attackers"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of Attackers to choose from.</param>
    /// <returns>A random Attacker's <see cref="Operator"/>.</returns>
    public static Operator GetRandomAttacker(Func<Operator, bool> filter) => Siege.Attackers.Where(filter).Random();
    /// <summary>
    /// Gets a random <see cref="Operator"/> from the <see cref="Attackers"/> while excluding any number of them.
    /// </summary>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A random Attacker's <see cref="Operator"/>.</returns>
    public static Operator GetRandomAttacker(params Operator[] filter) => Siege.Attackers.Except(filter).Random();

    /// <summary>
    /// Gets a number of random <see cref="Operator"/>s from the <see cref="Attackers"/>.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <returns>A collection of random Attackers' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomAttackers(int count) => Siege.Attackers.Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Operator"/>s from a pool of <see cref="Attackers"/> defined by a <paramref name="filter"/> function.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The function that dictates which <see cref="Operator"/>s are in the pool of <see cref="Attackers"/> to choose from.</param>
    /// <returns>A collection of random Attackers' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomAttackers(int count, Func<Operator, bool> filter) => Siege.Attackers.Where(filter).Random(count).Order(Operator.Comparer);
    /// <summary>
    /// Gets a number of random <see cref="Attackers"/>s while excluding any number of them.
    /// </summary>
    /// <param name="count">The number of <see cref="Operator"/>s to return.</param>
    /// <param name="filter">The set of <see cref="Operator"/>s to exclude from the selection.</param>
    /// <returns>A collection of random Attackers' <see cref="Operator"/>s.</returns>
    public static IEnumerable<Operator> GetRandomAttackers(int count, params Operator[] filter) => Siege.Attackers.Except(filter).Random(count).Order(Operator.Comparer);
    #endregion
}
