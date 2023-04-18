using System.Reflection;

using RainbowEdit.Models;

namespace RainbowEdit;

/// <summary>
/// Represents an <see cref="Operator"/> in Siege.
/// </summary>
public class Operator
{
    /// <summary>
    /// A series of constants containing the different movement speeds of an <see cref="Operator"/> in in-game meters per second.
    /// </summary>
    /// <remarks>
    /// The naming pattern of the fields is: <c>SPEED_{rating}_{weapon}_{slow?}{stance}{aim?}</c> where
    /// <list type="bullet">
    /// <item><c>rating</c>: the <see cref="Operator"/> <see cref="Speed"/> rating, <c>3</c>, <c>2</c> or <c>1</c>,</item>
    /// <item><c>weapon</c>: the weight class of the <see cref="Weapon"/> being held, <c>HEAVY</c> or <c>LIGHT</c>,</item>
    /// <item><c>slow?</c>: a value indicating whether the slow-move key was being held for this measurement, <c>SLOW</c> or absent (always absent for <c>{stance} == PRONE</c> or <c>{stance} == RUN</c>,</item>
    /// <item><c>stance</c>: a value indicating which stance or movement "subtype" this measurement is for, <c>PRONE</c>, <c>CROUCH</c>, <c>WALK</c> or <c>RUN</c> and</item>
    /// <item><c>aim?</c>: a value indicating whether the measurement was made while ADS or not, <c>_AIM</c> or absent (always absent for <c>{stance} == RUN</c>).</item>
    /// </list>
    /// As such, there are several invalid combinations that cannot exist, such as <c>SPEED_3_HEAVY_RUN_AIM</c>, <c>SPEED_3_HEAVY_SLOWPRONE</c> <c>SPEED_3_LIGHT_SLOWRUN_AIM</c> as the movement "subtypes" contradict each other.
    /// </remarks>
    public static class OperatorSpeed
    {
        #region Speed 3 (gathered using Ash)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_PRONE = 0.763052209M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_PRONE = 0.79731431M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWCROUCH = 1.18973075M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWCROUCH = 1.24671916M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWWALK = 1.43396226M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWWALK = 1.50346192M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_CROUCH = 1.82604517M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_CROUCH = 1.9216182M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_WALK = 3.02788845M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_WALK = 3.18791946M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_RUN = 4.51843044M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_RUN = 4.72636816M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_PRONE_AIM = 0.655172414M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_PRONE_AIM = 0.689655172M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWCROUCH_AIM = 1.01876676M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWCROUCH_AIM = 1.07770845M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_SLOWWALK_AIM = 1.2247529M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_SLOWWALK_AIM = 1.29626471M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_CROUCH_AIM = 1.57219694M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_CROUCH_AIM = 1.65289256M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_3_HEAVY_WALK_AIM = 2.25653207M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 3 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_3_LIGHT_WALK_AIM = 2.38993711M;
        #endregion

        #region Speed 2 (gathered using Thermite)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_PRONE = 0.745697897M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_PRONE = 0.781798207M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWCROUCH = 1.163484486M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWCROUCH = 1.222187402M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWWALK = 1.397348620M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWWALK = 1.466165413M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_CROUCH = 1.781635449M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_CROUCH = 1.874098990M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_WALK = 2.954545454M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_WALK = 3.116260487M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_RUN = 4.394366197M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_RUN = 4.609929078M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_PRONE_AIM = 0.670103092M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_PRONE_AIM = 0.707226403M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWCROUCH_AIM = 1.045576407M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWCROUCH_AIM = 1.101539330M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_SLOWWALK_AIM = 1.256443298M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_SLOWWALK_AIM = 1.325403568M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_CROUCH_AIM = 1.603948180M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_CROUCH_AIM = 1.689042875M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_2_HEAVY_WALK_AIM = 2.306327616M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 2 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_2_LIGHT_WALK_AIM = 2.419354838M;
        #endregion

        #region Speed 1 (gathered using Gridlock, who else would be better suited as a Speed 1 example)
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_PRONE = 0.670045528M;
        /// <summary>
        /// The prone speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_PRONE = 0.706521739M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWCROUCH = 1.043617875M;
        /// <summary>
        /// The slow-crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWCROUCH = 1.101072840M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWWALK = 1.255230125M;
        /// <summary>
        /// The slow-walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWWALK = 1.325628823M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_CROUCH = 1.599671862M;
        /// <summary>
        /// The crouch speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_CROUCH = 1.687216093M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_WALK = 2.669404517M;
        /// <summary>
        /// The walk speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_WALK = 2.795698924M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_RUN = 3.965429588M;
        /// <summary>
        /// The run speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_RUN = 4.157782515M;

        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, in prone and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_PRONE_AIM = 0.670045528M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, in prone and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_PRONE_AIM = 0.706521739M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWCROUCH_AIM = 1.046979865M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWCROUCH_AIM = 1.102785239M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_SLOWWALK_AIM = 1.257456069M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, slow-walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_SLOWWALK_AIM = 1.325628823M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, crouching and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_CROUCH_AIM = 1.604278074M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, crouching and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_CROUCH_AIM = 1.690140845M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, walking and having a heavy weapon (such as an Assault Rifle) equipped.
        /// </summary>
        public const decimal SPEED_1_HEAVY_WALK_AIM = 2.305645876M;
        /// <summary>
        /// The speed of a <see cref="Speed"/> 1 <see cref="Operator"/> while aiming down sights, walking and having a light weapon (such as a Pistol) equipped.
        /// </summary>
        public const decimal SPEED_1_LIGHT_WALK_AIM = 2.428393524M;
        #endregion

        private static Dictionary<string, decimal> _constants = null;
        /// <summary>
        /// The constants defined in <see cref="OperatorSpeed"/> compiled into a <see cref="Dictionary{TKey, TValue}"/> of <see cref="string"/> and <see cref="decimal"/>. The keys are the names of the constants, and the values are the values of the constants. This allows programmatically piecing together the name of the required value as described in the documentation of <see cref="OperatorSpeed"/> and getting it from this dictionary.
        /// </summary>
        /// <remarks>
        /// This collection is generated at runtime when it is first accessed.
        /// </remarks>
        public static Dictionary<string, decimal> Constants
        {
            get
            {
                if (_constants is null)
                {
                    var constInfos = typeof(OperatorSpeed).GetFields(BindingFlags.Static | BindingFlags.Public);
                    var speeds = new Dictionary<string, decimal>();
                    foreach (var constInfo in constInfos)
                    {
                        if (constInfo.GetValue(null) is decimal speed)
                        {
                            speeds.Add(constInfo.Name, speed);
                        }
                    }
                    _constants = speeds;
                }
                return _constants;
            }
        }
    }

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
    /// A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.
    /// </summary>
    public IEnumerable<Specialty> Specialties { get; private set; }
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
    /// <param name="specialties">A collection of <see cref="Specialty"/> objects representing the <see cref="Operator"/>'s assigned specialties.</param>
    /// <param name="organization">The name of the organization the <see cref="Operator"/> belongs to.</param>
    /// <param name="birthplace">The <see cref="Operator"/>'s birthplace.</param>
    /// <param name="height">The <see cref="Operator"/>'s height in whole and fractional centimeters.</param>
    /// <param name="weight">The <see cref="Operator"/>'s weight in whole and fractional kilograms.</param>
    /// <param name="realName">The in-game real name of the <see cref="Operator"/>.</param>
    /// <param name="age">An <see cref="OperatorAge"/> instance specifying the <see cref="Operator"/>'s day and month of birth and their age.</param>
    /// <param name="speed">The <see cref="Operator"/>'s speed rating.</param>
    internal Operator(string nickname, IEnumerable<Weapon> primaries, IEnumerable<Weapon> secondaries, Weapon.Gadget gadgets, string specialAbility, IEnumerable<Specialty> specialties, string organization, string birthplace, decimal height, decimal weight, string realName, OperatorAge age, int speed)
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
