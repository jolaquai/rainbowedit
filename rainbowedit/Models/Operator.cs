using rainbowedit.Models;

using static rainbowedit.Weapon;

namespace rainbowedit;

/// <summary>
/// Represents an <see cref="Operator"/> in Siege.
/// </summary>
/// <remarks>
/// <para/>Implements <see cref="IEquatable{T}"/> of <see cref="Operator"/> which enables compares <see cref="Operator"/>s by their <see cref="Operator.Nickname"/>.
/// <para/>Implements <see cref="IComparable{T}"/> of <see cref="Operator"/> which enables sorting <see cref="Operator"/>s according to their in-game sorting order.
/// </remarks>
public abstract class Operator
    : IEquatable<Operator>,
      IComparable<Operator>
{
    /// <summary>
    /// The nickname of the <see cref="Operator"/>.
    /// </summary>
    public string Nickname
    {
        get;
    }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public ImmutableArray<Weapon> Primaries
    {
        get;
    }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public ImmutableArray<Weapon> Secondaries
    {
        get;
    }
    /// <summary>
    /// A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.
    /// </summary>
    public Gadget Gadgets
    {
        get;
    }
    /// <summary>
    /// The name of the <see cref="Operator"/>'s special ability.
    /// </summary>
    public string SpecialAbility
    {
        get;
    }
    /// <summary>
    /// A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.
    /// </summary>
    public ImmutableArray<Specialty> Specialties
    {
        get;
    }
    /// <summary>
    /// The name of the organization the <see cref="Operator"/> belongs to.
    /// </summary>
    public string Organization
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s birthplace.
    /// </summary>
    public string Birthplace
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s height in whole and fractional centimeters.
    /// </summary>
    public decimal Height
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s weight in whole and fractional kilograms.
    /// </summary>
    public decimal Weight
    {
        get;
    }
    /// <summary>
    /// The in-game real name of the <see cref="Operator"/>.
    /// </summary>
    public string RealName
    {
        get;
    }
    /// <summary>
    /// An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.
    /// </summary>
    public OperatorAge Age
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s speed rating.
    /// </summary>
    public int Speed
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s health rating.
    /// </summary>
    public int Health
    {
        get;
    }
    /// <summary>
    /// The <see cref="Defender"/>'s base health / HP value.
    /// </summary>
    public int HP
    {
        get;
    }

    /// <summary>
    /// Indicates whether this <see cref="Operator"/> is one of the <see cref="Defenders"/>.
    /// </summary>
    public abstract bool IsDefender
    {
        get;
    }
    /// <summary>
    /// Indicates whether this <see cref="Operator"/> is one of the <see cref="Attackers"/>.
    /// </summary>
    public abstract bool IsAttacker
    {
        get;
    }

    /// <summary>
    /// Initializes a new <see cref="Operator"/> object.
    /// </summary>
    /// <param name="nickname">The nickname of the <see cref="Operator"/>.</param>
    /// <param name="primaries">A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="secondaries">A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="gadgets">A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.</param>
    /// <param name="specialAbility">The name of the <see cref="Operator"/>'s special ability.</param>
    /// <param name="specialties">A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.</param>
    /// <param name="organization">The name of the organization the <see cref="Operator"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Defender"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Defender"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Defender"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Operator"/>.</param>
    /// <param name="age">An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Defender"/>'s speed rating.</param>
    internal Operator(string nickname, ImmutableArray<Weapon> primaries, ImmutableArray<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, ImmutableArray<Specialty> specialties, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed)
    {
        Nickname = nickname;
        Primaries = primaries;
        Secondaries = secondaries;
        Gadgets = gadgets;
        SpecialAbility = specialAbility;
        Specialties = specialties;
        Organization = organization;
        Birthplace = birthplace;
        Height = height;
        Weight = weight;
        RealName = realName;
        Age = age;
        Speed = speed;

        Health = 4 - Speed;
        HP = Health switch
        {
            1 => 100,
            2 => 110,
            3 => 125,
            _ => throw new ArgumentOutOfRangeException(nameof(speed), $"Invalid 'Speed' rating '{Speed}' resulted in unexpected Health rating '{Health}' for new Operator.")
        };
    }

    /// <summary>
    /// Creates a <see cref="LoadoutConfiguration"/> from all possible <see cref="Primaries"/>, <see cref="Secondaries"/> (and those two's respective <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> options) and <see cref="Gadgets"/> loadout combinations.
    /// </summary>
    /// <returns>A <see cref="LoadoutConfiguration"/> as described.</returns>
    public LoadoutConfiguration GetRandomLoadout() => new LoadoutConfiguration(this);

    /// <inheritdoc/>
    public override string ToString() => Nickname; // Nickname.PadRight(Siege.LongestOperatorNickname.Length + 4);

    /// <summary>
    /// Returns a copy of a collection of <see cref="Operator"/> objects sorted in the order they appear in-game.
    /// The collection may be immutable.
    /// </summary>
    /// <param name="sequence">The collection to sort.</param>
    /// <returns>The sorted collection as described.</returns>
    public static IOrderedEnumerable<Operator> Order(IEnumerable<Operator> sequence)
    {
        ArgumentNullException.ThrowIfNull(sequence);
        return sequence.Order(Comparer);
    }
    /// <summary>
    /// Sorts a collection of <see cref="Operator"/> objects in the order they appear in-game.
    /// The collection must be mutable.
    /// </summary>
    /// <param name="collection">The collection to sort.</param>
    public static void Sort(ICollection<Operator> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);
        if (collection.IsReadOnly)
        {
            throw new InvalidOperationException($"Collections passed to {nameof(Operator)}.{nameof(Sort)} must be mutable. Either use a mutable collection with this method, or call {nameof(Operator)}.{nameof(Order)} instead.");
        }
        // Let's sort aware of the collection type for performance reasons
        switch (collection)
        {
            case Operator[] array:
            {
                Array.Sort(array, Comparer);
                break;
            }
            case List<Operator> list:
            {
                list.Sort(Comparer);
                break;
            }
            case IList<Operator> ilist:
            {
                // Try to fall back to rewriting the IList's contents
                try
                {
                    var array = ilist.ToArray();
                    Array.Sort(array, Comparer);
                    ilist.Clear();
                    foreach (var item in array)
                    {
                        ilist.Add(item);
                    }
                }
                // If that doesn't work, bail
                catch (NotSupportedException)
                {
                    goto default;
                }
                break;
            }
            default:
                throw new InvalidOperationException($"Collections passed to {nameof(Operator)}.{nameof(Sort)} must be mutable. Either use a mutable collection with this method, or call {nameof(Operator)}.{nameof(Order)} instead.");
        }
    }

    /// <summary>
    /// An <see cref="IComparer{T}"/> implementation for <see cref="Operator"/> objects that may be used to sort a collection of <see cref="Operator"/> objects by the order they appear in-game.
    /// </summary>
    /// <remarks>You may use this directly for custom implementations or use <see cref="Sort(IEnumerable{Operator})"/> or <see cref="Order(IEnumerable{Operator})"/>.</remarks>
    public static OperatorComparer Comparer => OperatorComparer.Instance;

    #region Comparisons / operators
    /// <summary>
    /// Implicitly converts an <see cref="Operator"/> to a <see cref="string"/> that represents the <see cref="Operator"/>.
    /// </summary>
    /// <param name="op">The <see cref="Defender"/> to convert.</param>
    public static implicit operator string(Operator op) => op.ToString();

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        // We're ignoring pretty much all this Type's members on purpose, Operator instances cannot be created from outside this assembly, so we can be sure that the only way to compare two Operators is to compare those other properties
        // And if someone reflects themselves access to the constructor, they can just as well reflect themselves access to the properties' internals and they deserve whatever is coming to them
        return obj is Operator @operator
            && Nickname == @operator.Nickname
            // && EqualityComparer<IEnumerable<Weapon>>.Default.Equals(Primaries, @operator.Primaries)
            // && EqualityComparer<IEnumerable<Weapon>>.Default.Equals(Secondaries, @operator.Secondaries)
            // && Gadgets == @operator.Gadgets
            // && SpecialAbility == @operator.SpecialAbility
            // && EqualityComparer<IEnumerable<Specialty>>.Default.Equals(Specialties, @operator.Specialties)
            // && Organization == @operator.Organization
            // && Birthplace == @operator.Birthplace
            // && Height == @operator.Height
            // && Weight == @operator.Weight
            // && RealName == @operator.RealName
            // && EqualityComparer<OperatorAge>.Default.Equals(Age, @operator.Age)
            // && Speed == @operator.Speed
            // && Health == @operator.Health
            // && HP == @operator.HP
            ;
    }

    /// <inheritdoc/>
    public bool Equals(Operator? obj)
    {
        // We're ignoring pretty much all this Type's members on purpose, Operator instances cannot be created from outside this assembly, so we can be sure that the only way to compare two Operators is to compare those other properties
        // And if someone reflects themselves access to the constructor, they can just as well reflect themselves access to the properties' internals and they deserve whatever is coming to them
        return obj is Operator @operator
            && Nickname == @operator.Nickname
            // && EqualityComparer<IEnumerable<Weapon>>.Default.Equals(Primaries, @operator.Primaries)
            // && EqualityComparer<IEnumerable<Weapon>>.Default.Equals(Secondaries, @operator.Secondaries)
            // && Gadgets == @operator.Gadgets
            // && SpecialAbility == @operator.SpecialAbility
            // && EqualityComparer<IEnumerable<Specialty>>.Default.Equals(Specialties, @operator.Specialties)
            // && Organization == @operator.Organization
            // && Birthplace == @operator.Birthplace
            // && Height == @operator.Height
            // && Weight == @operator.Weight
            // && RealName == @operator.RealName
            // && EqualityComparer<OperatorAge>.Default.Equals(Age, @operator.Age)
            // && Speed == @operator.Speed
            // && Health == @operator.Health
            // && HP == @operator.HP
            ;
    }

    /// <summary>
    /// Computes a <see cref="HashCode"/> for the current <see cref="Operator"/> object.
    /// </summary>
    /// <returns>The computed hash code as an <see cref="int"/>.</returns>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(Nickname);
        hash.Add(Primaries);
        hash.Add(Secondaries);
        hash.Add(Gadgets);
        hash.Add(SpecialAbility);
        hash.Add(Specialties);
        hash.Add(Organization);
        hash.Add(Birthplace);
        hash.Add(Height);
        hash.Add(Weight);
        hash.Add(RealName);
        hash.Add(Age);
        hash.Add(Speed);
        hash.Add(Health);
        hash.Add(HP);
        return hash.ToHashCode();
    }

    /// <summary>
    /// Gets a value that indicates whether two <see cref="Operator"/> objects are equal.
    /// </summary>
    /// <param name="left">The left <see cref="Operator"/> to compare.</param>
    /// <param name="right">The right <see cref="Operator"/> to compare.</param>
    /// <returns>A value that indicates whether <paramref name="left"/> and <paramref name="right"/> are equal.</returns>
    public static bool operator ==(Operator? left, Operator? right) => left is not null
        && right is not null
        && ReferenceEquals(left, right)
        && left.Equals(right);
    /// <summary>
    /// Gets a value that indicates whether two <see cref="Operator"/> objects are not equal.
    /// </summary>
    /// <param name="left">The left <see cref="Operator"/> to compare.</param>
    /// <param name="right">The right <see cref="Operator"/> to compare.</param>
    /// <returns>A value that indicates whether <paramref name="left"/> and <paramref name="right"/> are not equal.</returns>
    public static bool operator !=(Operator? left, Operator? right) => !(left == right);
    /// <summary>
    /// Gets a value that indicates whether the left operand appears before the right operand in the in-game order of <see cref="Operator"/> objects.
    /// </summary>
    /// <param name="left">The first <see cref="Operator"/> to consider for the comparison.</param>
    /// <param name="right">The second <see cref="Operator"/> to consider for the comparison.</param>
    /// <returns>A <see cref="bool"/> value as described.</returns>
    /// <remarks><see cref="Defenders"/> are always considered lesser than <see cref="Attackers"/> for this comparison.</remarks>
    public static bool operator <(Operator left, Operator right)
    {
        if (left is null || right is null || ReferenceEquals(left, right) || Equals(left, right))
        {
            return false;
        }

        var list = Siege.DefAtk.ToList();
        return list.IndexOf(left) < list.IndexOf(right);
    }
    /// <summary>
    /// Gets a value that indicates whether the left operand appears after the right operand in the in-game order of <see cref="Operator"/> objects.
    /// </summary>
    /// <param name="left">The first <see cref="Operator"/> to consider for the comparison.</param>
    /// <param name="right">The second <see cref="Operator"/> to consider for the comparison.</param>
    /// <returns>A <see cref="bool"/> value as described.</returns>
    /// <remarks><see cref="Defenders"/> are always considered lesser than <see cref="Attackers"/> for this comparison.</remarks>
    public static bool operator >(Operator left, Operator right)
    {
        if (left is null || right is null || ReferenceEquals(left, right) || Equals(left, right))
        {
            return false;
        }

        var list = Siege.DefAtk.ToList();
        return list.IndexOf(left) > list.IndexOf(right);
    }
    /// <summary>
    /// Gets a value that indicates whether the left operand appears before or in the same position as the right operand in the in-game order of <see cref="Operator"/> objects.
    /// </summary>
    /// <param name="left">The first <see cref="Operator"/> to consider for the comparison.</param>
    /// <param name="right">The second <see cref="Operator"/> to consider for the comparison.</param>
    /// <returns>A <see cref="bool"/> value as described.</returns>
    /// <remarks>
    /// <see cref="Defenders"/> are always considered lesser than <see cref="Attackers"/> for this comparison.
    /// </remarks>
    public static bool operator <=(Operator left, Operator right) => !(left > right);
    /// /// <summary>
    /// Gets a value that indicates whether the left operand appears in the same position as or after the right operand in the in-game order of <see cref="Operator"/> objects.
    /// </summary>
    /// <param name="left">The first <see cref="Operator"/> to consider for the comparison.</param>
    /// <param name="right">The second <see cref="Operator"/> to consider for the comparison.</param>
    /// <returns>A <see cref="bool"/> value as described.</returns>
    /// <remarks>
    /// <see cref="Defenders"/> are always considered lesser than <see cref="Attackers"/> for this comparison.
    /// </remarks>
    public static bool operator >=(Operator left, Operator right) => !(left < right);

    /// <inheritdoc/>
    public int CompareTo(Operator? other) => ((IComparer<Operator>)Comparer).Compare(this, other);
    #endregion
}

/// <summary>
/// Implements <see cref="IComparer{T}"/> and <see cref="IEqualityComparer{T}"/> for <see cref="Operator"/> objects that may be used to sort a collection of <see cref="Operator"/> objects by the order they appear in-game.
/// </summary>
public sealed class OperatorComparer : IComparer<Operator>, IEqualityComparer<Operator>
{
    private static ImmutableArray<Operator> allOps;
    private static OperatorComparer instance;
    /// <summary>
    /// Gets an instance of the <see cref="OperatorComparer"/> class.
    /// </summary>
    public static OperatorComparer Instance => instance ??= new OperatorComparer();

    private OperatorComparer()
    {
        allOps = Siege.DefAtk.ToImmutableArray();
    }

    int IComparer<Operator>.Compare(Operator? left, Operator? right)
    {
        ArgumentNullException.ThrowIfNull(left);
        ArgumentNullException.ThrowIfNull(right);
        if (ReferenceEquals(left, right) || left.Equals(right))
        {
            return 0;
        }
        return allOps.IndexOf(left) - allOps.IndexOf(right);
    }
    bool IEqualityComparer<Operator>.Equals(Operator? left, Operator? right)
    {
        ArgumentNullException.ThrowIfNull(left);
        ArgumentNullException.ThrowIfNull(right);
        return left.Equals(right);
    }
    int IEqualityComparer<Operator>.GetHashCode(Operator obj) => obj.GetHashCode();
}

/// <summary>
/// Represents a single Attacker in Siege.
/// </summary>
public class Attacker : Operator
{
    /// <summary>
    /// Initializes a new <see cref="Attacker"/> object.
    /// </summary>
    /// <param name="nickname">The nickname of the <see cref="Attacker"/>.</param>
    /// <param name="primaries">A collection of <see cref="rainbowedit.Weapon"/> objects, containing information about the primary weapons the <see cref="Attacker"/> may use.</param>
    /// <param name="secondaries">A collection of <see cref="rainbowedit.Weapon"/> objects, containing information about the secondary weapons the <see cref="Attacker"/> may use.</param>
    /// <param name="gadgets">A combination of <see cref="rainbowedit.Weapon.Gadget"/> values that specifies which gadgets the <see cref="Attacker"/> may choose from.</param>
    /// <param name="specialAbility">The name of the <see cref="Attacker"/>'s special ability.</param>
    /// <param name="specialties">A collection of <see cref="rainbowedit.Models.Specialty"/> objects representing the <see cref="Attacker"/>'s assigned specialties.</param>
    /// <param name="organization">The name of the organization the <see cref="Attacker"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Attacker"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Attacker"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Attacker"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Attacker"/>.</param>
    /// <param name="age">An <see cref="rainbowedit.OperatorAge"/> instance specifying the <see cref="Attacker"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Attacker"/>'s speed rating.</param>
    internal Attacker(string nickname, ImmutableArray<Weapon> primaries, ImmutableArray<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, ImmutableArray<Specialty> specialties, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed) : base(nickname, primaries, secondaries, gadgets, specialAbility, specialties, organization, birthplace, height, weight, realName, age, speed)
    {

    }

    public override bool IsDefender => false;
    public override bool IsAttacker => true;
}
/// <summary>
/// Represents a single Defender in Siege.
/// </summary>
public class Defender : Operator
{
    /// <summary>
    /// Initializes a new <see cref="Defender"/> object.
    /// </summary>
    /// <param name="nickname">The nickname of the <see cref="Defender"/>.</param>
    /// <param name="primaries">A collection of <see cref="rainbowedit.Weapon"/> objects, containing information about the primary weapons the <see cref="Defender"/> may use.</param>
    /// <param name="secondaries">A collection of <see cref="rainbowedit.Weapon"/> objects, containing information about the secondary weapons the <see cref="Defender"/> may use.</param>
    /// <param name="gadgets">A combination of <see cref="rainbowedit.Weapon.Gadget"/> values that specifies which gadgets the <see cref="Defender"/> may choose from.</param>
    /// <param name="specialAbility">The name of the <see cref="Defender"/>'s special ability.</param>
    /// <param name="specialties">A collection of <see cref="rainbowedit.Models.Specialty"/> objects representing the <see cref="Defender"/>'s assigned specialties.</param>
    /// <param name="organization">The name of the organization the <see cref="Defender"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Defender"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Defender"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Defender"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Defender"/>.</param>
    /// <param name="age">An <see cref="rainbowedit.OperatorAge"/> instance specifying the <see cref="Defender"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Defender"/>'s speed rating.</param>
    internal Defender(string nickname, ImmutableArray<Weapon> primaries, ImmutableArray<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, ImmutableArray<Specialty> specialties, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed) : base(nickname, primaries, secondaries, gadgets, specialAbility, specialties, organization, birthplace, height, weight, realName, age, speed)
    {

    }

    public override bool IsDefender => true;
    public override bool IsAttacker => false;
}
