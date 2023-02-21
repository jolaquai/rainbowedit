namespace RainbowEdit;

public class Operator
{
    public const decimal SPEED_3 = 2.34M;
    public const decimal SPEED_2 = 2.34M;
    public const decimal SPEED_1 = 2.34M;
    public const decimal SPEED_AIM = SPEED_1;

    public string Nickname { get; private set; }
    public IEnumerable<Weapon> Primaries { get; private set; }
    public IEnumerable<Weapon> Secondaries { get; private set; }
    public Weapon.Gadget Gadgets { get; private set; }
    public string SpecialAbility { get; private set; }
    public string Organization { get; private set; }
    public string Birthplace { get; private set; }
    public decimal Height { get; private set; }
    public decimal Weight { get; private set; }
    public string RealName { get; private set; }
    public OperatorAge Age { get; private set; }
    public int Speed { get; private set; }
    public int Health { get; private set; }
    public int HP { get; private set; }

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
        HP = 100 + (10 * (Health - 1));
    }

    public LoadoutConfiguration GetRandomLoadout() => new(this);

    public override string ToString() => Nickname.PadRight(Game.LongestOperatorNickname.Length + 4);
    public static implicit operator string(Operator op) => op.ToString();
}
