namespace RainbowEdit;

/// <summary>
/// An <see cref="Operator"/> in Siege.
/// </summary>
public class Operator
{
    /// <summary>
    /// The walking speed of a <see cref="Speed"/> 3 <see cref="Operator"/>.
    /// </summary>
    public const decimal SPEED_3 = -1M;
    /// <summary>
    /// The walking speed of a <see cref="Speed"/> 2 <see cref="Operator"/>.
    /// </summary>
    public const decimal SPEED_2 = -1M;
    /// <summary>
    /// The walking speed of a <see cref="Speed"/> 1 <see cref="Operator"/>.
    /// </summary>
    public const decimal SPEED_1 = 2.34M;
    /// <summary>
    /// The walking speed of an <see cref="Operator"/> while aiming down sights.
    /// </summary>
    public const decimal SPEED_AIM = SPEED_1;

    /// <summary>
    /// The nickname of the <see cref="Operator"/>.
    /// </summary>
    public string Nickname { get; private set; }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public IEnumerable<Weapon> Primaries { get; private set; }
    /// <summary>
    /// A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.
    /// </summary>
    public IEnumerable<Weapon> Secondaries { get; private set; }
    /// <summary>
    /// A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.
    /// </summary>
    public Weapon.Gadget Gadgets { get; private set; }
    /// <summary>
    /// The name of the <see cref="Operator"/>'s special ability.
    /// </summary>
    public string SpecialAbility { get; private set; }
    /// <summary>
    /// The name of the organization the <see cref="Operator"/> belongs to.
    /// </summary>
    public string Organization { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s birthplace.
    /// </summary>
    public string Birthplace { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s height in whole and fractional centimeters.
    /// </summary>
    public decimal Height { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s weight in whole and fractional kilograms.
    /// </summary>
    public decimal Weight { get; private set; }
    /// <summary>
    /// The in-game real name of the <see cref="Operator"/>.
    /// </summary>
    public string RealName { get; private set; }
    /// <summary>
    /// An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.
    /// </summary>
    public OperatorAge Age { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s speed rating.
    /// </summary>
    public int Speed { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s health rating.
    /// </summary>
    public int Health { get; private set; }
    /// <summary>
    /// The <see cref="Operator"/>'s base health / HP value.
    /// </summary>
    public int HP { get; private set; }

    /// <summary>
    /// Instantiates a new <see cref="Operator"/> object.
    /// </summary>
    /// <param name="nickname">The nickname of the <see cref="Operator"/>.</param>
    /// <param name="primaries">A collection of <see cref="Weapon"/> objects, containing information about the primary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="secondaries">A collection of <see cref="Weapon"/> objects, containing information about the secondary weapons the <see cref="Operator"/> may use.</param>
    /// <param name="gadgets">A combination of <see cref="Weapon.Gadget"/> values that specifies which gadgets the <see cref="Operator"/> may choose from.</param>
    /// <param name="specialAbility">The name of the <see cref="Operator"/>'s special ability.</param>
    /// <param name="organization">The name of the organization the <see cref="Operator"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Operator"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Operator"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Operator"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Operator"/>.</param>
    /// <param name="age">An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Operator"/>'s speed rating.</param>
    internal Operator(string nickname, IEnumerable<Weapon> primaries, IEnumerable<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed)
    {
        Nickname = nickname;
        Primaries = primaries;
        Secondaries = secondaries;
        Gadgets = gadgets;
        SpecialAbility = specialAbility;
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
            _ => throw new ArgumentException($"Invalid 'Speed' rating '{Speed}' resulted in unexpected Health rating '{Health}' for new Operator.", nameof(speed))
        };
    }

    /// <summary>
    /// Creates a <see cref="LoadoutConfiguration"/> from all possible <see cref="Primaries"/>, <see cref="Secondaries"/> (and those two's respective <see cref="Weapon.Barrels"/>, <see cref="Weapon.Grips"/>, <see cref="Weapon.Sights"/> and <see cref="Weapon.Underbarrel"/> options) and <see cref="Gadgets"/> loadout combinations.
    /// </summary>
    /// <returns>A <see cref="LoadoutConfiguration"/> as described.</returns>
    public LoadoutConfiguration GetRandomLoadout() => new(this);

    /// <inheritdoc/>
    public override string ToString() => Nickname.PadRight(Siege.LongestOperatorNickname.Length + 4);
    /// <inheritdoc/>
    public static implicit operator string(Operator op) => op.ToString();
}
