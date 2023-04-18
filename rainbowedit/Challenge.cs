using RainbowEdit.Extensions;

namespace RainbowEdit;

/// <summary>
/// Represents a <i>Battle Pass</i> or Weekly <i>Ubisoft Connect</i> Challenge.
/// </summary>
public class Challenge
{
    /// <summary>
    /// The type of this <see cref="Challenge"/>.
    /// </summary>
    public ChallengeType Type { get; internal set; }
    /// <summary>
    /// A collection of <see cref="Operator"/> instances, representing the <see cref="Operator"/>s that may be used to complete this <see cref="Challenge"/>.
    /// </summary>
    public IEnumerable<Operator> Operators { get; internal set; }
    /// <summary>
    /// Extra data. See the <see cref="Challenge(ChallengeType, object?)"/> constructor for more information on how to set this, how it is used and what values it may take.
    /// </summary>
    public object? Extra { get; internal set; }

    /// <summary>
    /// Instantiates a new <see cref="Challenge"/> from a series of <see cref="Operator"/>s. This implies the <see cref="Type"/> to be <see cref="ChallengeType.Operators"/>.
    /// </summary>
    /// <param name="operators">Any number of <see cref="Operator"/> instances to associate with this <see cref="Challenge"/>.</param>
    public Challenge(params Operator[] operators)
    {
        Type = ChallengeType.Operators;
        Operators = operators;
    }

    /// <summary>
    /// Instantiates a new <see cref="Challenge"/> from a <see cref="ChallengeType"/> and <paramref name="extra"/> data, the nature of which depends on which <paramref name="challengeType"/> was passed:
    /// <list type="bullet">
    /// <item><see cref="ChallengeType.Operators"/>: <paramref name="extra"/> must be a Type convertible to an <see cref="IEnumerable{T}"/> of <see cref="Operator"/>.</item>
    /// <item><see cref="ChallengeType.WeaponTypeKills"/>: <paramref name="extra"/> must be a <see cref="Weapon.WeaponType"/> enum value. The <see cref="Extra"/> property is set to the passed value.</item>
    /// <item>For any other <see cref="ChallengeType"/>, <paramref name="extra"/> is ignored.</item>
    /// </list>
    /// </summary>
    /// <param name="challengeType">A <see cref="ChallengeType"/> enum value that identifies the type of this <see cref="Challenge"/>.</param>
    /// <param name="extra">Extra data as described.</param>
    /// <exception cref="ArgumentException">Thrown if the Type of <paramref name="extra"/> is unexpected for the passed <paramref name="challengeType"/>.</exception>
    public Challenge(ChallengeType challengeType, object? extra = null)
    {
        Type = challengeType;
        Operators = challengeType switch
        {
            ChallengeType.Operators => extra as IEnumerable<Operator> ?? throw new ArgumentException($"With {nameof(challengeType)} == {ChallengeType.Operators}, {nameof(extra)} must be an object convertible to {typeof(IEnumerable<Operator>)}.", nameof(extra)),
            ChallengeType.WeaponTypeKills => extra is Weapon.WeaponType wType ? Siege.DefAtk.Where(op => op.Primaries.Concat(op.Secondaries).Any(wep => wep.Type == wType)) : throw new ArgumentException($"With {nameof(challengeType)} == {ChallengeType.WeaponTypeKills}, {nameof(extra)} must be an {typeof(Weapon.WeaponType)} enum value.", nameof(extra)),
            ChallengeType.Blind => Siege.DefAtk.Where(op => op.Gadgets.HasValue(Weapon.Gadget.StunGrenade)).Append(Attackers.Ying).Append(Attackers.Blitz).Distinct(),
            ChallengeType.Disorient => new List<Operator>() { Defenders.Echo, Defenders.Ela, Defenders.Oryx, Attackers.Zofia },
            _ => Siege.DefAtk
        };

        Extra = challengeType is ChallengeType.WeaponTypeKills ? extra : null;
    }

    /// <summary>
    /// Identifies the type of a <see cref="Challenge"/>.
    /// </summary>
    public enum ChallengeType
    {
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is winning rounds with specific <see cref="Operator"/>s.
        /// </summary>
        Operators,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is killing opponents with a specific type of <see cref="Weapon"/>.
        /// </summary>
        WeaponTypeKills,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is blinding opponents using <i>Stun Grenade</i>s, <see cref="Attackers.Ying"/>'s <i>Candela</i> or <see cref="Attackers.Blitz"/>'s <i>Shield</i>.
        /// </summary>
        Blind,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is disorienting opponents using <see cref="Defenders.Echo"/>'s <i>Yokai</i>'s <i>Sonic Burst</i>s, <see cref="Defenders.Ela"/>'s <i>Grzmot Mine</i>s, <see cref="Defenders.Oryx"/>'s <i>Remah Dash</i> or <see cref="Attackers.Zofia"/>'s <i>Shock Grenade</i>s.
        /// </summary>
        Disorient,

        /// <summary>
        /// Indicates that the specific requirement of a <see cref="Challenge"/> is not specific to any <see cref="Operator"/>s.
        /// </summary>
        Universal,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is eliminating opponents using gadgets or melee attacks. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        GadgetMelee,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is eliminating opponents with <see cref="Weapon"/>s that have a <see cref="Weapon.Barrel.Suppressor"/> equipped. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        SuppressedKills,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is eliminating opponents using headshots. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        Headshots,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is eliminating opponents while in rappel (<i>"Death from above"</i>). This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        Rappel,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is dealing damage to opponents. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        Damage,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is hitting opponents with bullets. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        BulletHits,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is destroying opponent gadgets or special abilities. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        GadgetDestroy,
        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is destroying opponents' observation tools. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        ObservationDestroy,

        /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is winning rounds in the <i>Quick Match</i> game mode. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        QuickMatch,
        /// /// <summary>
        /// Indicates that a <see cref="Challenge"/>'s requirement is playing matches in the <i>Ranked</i> game mode. This is a type of <see cref="Universal"/> <see cref="Challenge"/>.
        /// </summary>
        Ranked,
    }

    /// <summary>
    /// Constructs a mapping from <see cref="Operator"/>s to the given <paramref name="challenges"/>.
    /// </summary>
    /// <param name="challenges">The <see cref="Challenge"/>s to map.</param>
    /// <returns>A <see cref="Dictionary{TKey, TValue}"/> that maps viable Operators to the given <paramref name="challenges"/>.</returns>
    public static Dictionary<Operator, IEnumerable<Challenge>> ConstructOperatorMappings(params Challenge[] challenges)
    {
        var retDict = new Dictionary<Operator, IEnumerable<Challenge>>();

        // Group the challenges by the Operators that can complete them
        var groupedChallenges = challenges.GroupBy(challenge => challenge.Operators);
        // For each group of challenges, add the Operators that can complete them to the dictionary, skipping challenges that are not specific to any Operators
        foreach (var challengeGroup in groupedChallenges)
        {
            // If the group is not specific to any Operators, skip it
            if (challengeGroup.Key == Siege.DefAtk)
            {
                //continue;
            }
            
            // If the Operators currently in the dictionary can complete all the Challenges we were passed, return the dictionary
            if (retDict.SelectMany(kv => kv.Value).SequenceEqual(challenges))
            {
                return retDict;
            }

            // Add the Operators that can complete the challenges in the group to the dictionary
            foreach (var op in challengeGroup.Key)
            {
                if (retDict.ContainsKey(op))
                {
                    retDict[op] = retDict[op].Concat(challengeGroup);
                }
                else
                {
                    retDict.Add(op, challengeGroup);
                }
            }
        }

        // Return the dictionary
        return retDict;
    }

    /// <inheritdoc/>
    public override string? ToString()
    {
        return $"{Type.Stringify()}{(Extra is not null ? $" ({Extra})" : "")}";
    }
}
