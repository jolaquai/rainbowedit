using rainbowedit.Models;

namespace rainbowedit;

/// <summary>
/// The <see cref="Attackers"/> in Siege.
/// </summary>
public sealed partial class Attackers : IEnumerable<Operator>
{
    static Attackers()
    {
        _operators =
        [
            Sledge,
            Thatcher,
            Ash,
            Thermite,
            Twitch,
            Montagne,
            Glaz,
            Fuze,
            Blitz,
            IQ,
            Buck,
            Blackbeard,
            Capitao,
            Hibana,
            Jackal,
            Ying,
            Zofia,
            Dokkaebi,
            Lion,
            Finka,
            Maverick,
            Nomad,
            Gridlock,
            Nokk,
            Amaru,
            Kali,
            Iana,
            Ace,
            Zero,
            Flores,
            Osa,
            Sens,
            Grim,
            Brava,
            Ram,
            Deimos
        ];

        // Needed because even though every Weapon object is instantiated using a reference to the containing Operator instance, at the time of instantiation, those Operator references are null
        foreach (var op in _operators)
        {
            foreach (var wep in op.Primaries.Concat(op.Secondaries))
            {
                wep.Source = op;
            }
        }

        // Same as above
        Specialties.Breach.Reward = Hibana;
        Specialties.Support.Reward = Montagne;
        Specialties.FrontLine.Reward = Ash;
        Specialties.Intel.Reward = Twitch;
        Specialties.AntiGadget.Reward = Fuze;
        Specialties.MapControl.Reward = Lion;
    }

#pragma warning disable CS8604 // Possible null reference argument.

    #region Specialties
    /// <summary>
    /// Contains <see cref="Specialty"/> definitions for <see cref="Attackers"/>.
    /// </summary>
    public static class Specialties
    {
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="Breach"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Breach { get; } = new Specialty(
            "Breach",
            Hibana,
            [
                new Specialty.Challenge("Destroy 5 barricades or hatches.", "Renown 250"),
                new Specialty.Challenge("Breach 2 reinforced surfaces.", "3-Days Renown Booster 1x"),
                new Specialty.Challenge("Score 125 points by breaching reinforced surfaces.", "Beginner Pack 3x")
            ]
        );
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="Support"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Support { get; } = new Specialty(
            "Support",
            Montagne,
            [
                new Specialty.Challenge("Play 1 times as a Support Attacker.", "Beginner Pack 1x"),
                new Specialty.Challenge("Revive 5 teammates.", "Beginner Pack 2x"),
                new Specialty.Challenge("Win by defusing bombs 1 times.", "Beginner Pack 3x")
            ]
        );
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="FrontLine"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty FrontLine { get; } = new Specialty(
            "Front-Line",
            Ash,
            [
                new Specialty.Challenge("Get 5 eliminations or assists.", "Beginner Pack 1x"),
                new Specialty.Challenge("Blind 2 opponents.", "Renown 500"),
                new Specialty.Challenge("Eliminate 5 opponents with explosives as an Attacker.", "7-Days Renown Booster 1x")
            ]
        );
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="Intel"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Intel { get; } = new Specialty(
            "Intel",
            Twitch,
            [
                new Specialty.Challenge("Scan and identify 7 Defenders as an Attacker.", "1-Day Renown Booster 1x"),
                new Specialty.Challenge("Find the bomb as an Attacker 1 times without your drone being destroyed during the Preparation Phase.", "1-Day Battle Point Booster 2x"),
                new Specialty.Challenge("Get 5 Opponents Scan Assists.", "Renown 750")
            ]
        );
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="AntiGadget"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty AntiGadget { get; } = new Specialty(
            "Anti-Gadget",
            Fuze,
            [
                new Specialty.Challenge("Destroy 5 trap devices as an Attacker.", "1-Day Battle Point Booster 1x"),
                new Specialty.Challenge("Destroy 5 Observation Tools as an Attacker.", "1-Day Battle Point Booster 2x"),
                new Specialty.Challenge("Deactivate 2 electronic devices as an Attacker.", "1-Day Battle Point Booster 3x")
            ]
        );
        /// <summary>
        /// The <see cref="Attackers"/>' <see cref="MapControl"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty MapControl { get; } = new Specialty(
            "Map Control",
            Lion,
            [
                new Specialty.Challenge("Walk or sprint 500 meters as an Attacker.", "Renown 250"),
                new Specialty.Challenge("Get 5 headshots.", "3-Days Renown Booster 1x"),
                new Specialty.Challenge("Eliminate 2 opponents through breakable surfaces.", "1-Day Battle Point Booster 3x")
            ]
        );

        /// <summary>
        /// A collection of all <see cref="Specialty"/> instances that apply to <see cref="Attackers"/>.
        /// </summary>
        public static IEnumerable<Specialty> All { get; } =
        [
            Breach,
            Support,
            FrontLine,
            Intel,
            AntiGadget,
            MapControl
        ];
    }
    #endregion

    #region Attacker instances
    /// <summary>
    /// The <see cref="Operator"/> <see cref="Sledge"/>.
    /// </summary>
    public static Operator Sledge { get; } = new Operator(
        "Sledge",
        [
            new Weapon(
                Sledge,
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4030,
                4510
            ),
            new Weapon(
                Sledge,
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            )
        ],
        [
            new Weapon(
                Sledge,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1430
            )
        ],
        Weapon.Gadget.FragGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Tactical Breaching Hammer \"The Caber\"",
        [
            Specialties.Breach,
            Specialties.AntiGadget
        ],
        "SAS",
        "John O'Groats, Scotland",
        192,
        95,
        "Seamus Cowden",
        new OperatorAge(2, 4, 35),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thatcher"/>.
    /// </summary>
    public static Operator Thatcher { get; } = new Operator(
        "Thatcher",
        [
            new Weapon(
                Thatcher,
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new Weapon(
                Thatcher,
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            ),
            new Weapon(
                Thatcher,
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4030,
                4510
            )
        ],
        [
            new Weapon(
                Thatcher,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1430
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "EG Mk 0-EMP Grenade",
        [
            Specialties.AntiGadget,
            Specialties.Support
        ],
        "SAS",
        "Bideford, England",
        180,
        72,
        "Mike Baker",
        new OperatorAge(22, 6, 56),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ash"/>.
    /// </summary>
    public static Operator Ash { get; } = new Operator(
        "Ash",
        [
            new Weapon(
                Ash,
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            ),
            new Weapon(
                Ash,
                "R4-C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                39,
                860,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2200
            )
        ],
        [
            new Weapon(
                Ash,
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1100,
                1300
            ),
            new Weapon(
                Ash,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1490
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "M120 CREM Breaching Rounds",
        [
            Specialties.Breach,
            Specialties.FrontLine
        ],
        "FBI SWAT",
        "Jerusalem, Israel",
        170,
        63,
        "Eliza Cohen",
        new OperatorAge(24, 12, 33),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thermite"/>.
    /// </summary>
    public static Operator Thermite { get; } = new Operator(
        "Thermite",
        [
            new Weapon(
                Thermite,
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4450,
                5330
            ),
            new Weapon(
                Thermite,
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            )
        ],
        [
            new Weapon(
                Thermite,
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1100,
                1300
            ),
            new Weapon(
                Thermite,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1490
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
        "Brimstone BC-3 Exothermic Charges",
        [
            Specialties.Breach,
            Specialties.Support
        ],
        "FBI SWAT",
        "Plano, Texas",
        178,
        80,
        "Jordan Trace",
        new OperatorAge(14, 3, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Twitch"/>.
    /// </summary>
    public static Operator Twitch { get; } = new Operator(
        "Twitch",
        [
            new Weapon(
                Twitch,
                "F2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                37,
                980,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1420,
                2320
            ),
            new Weapon(
                Twitch,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new Weapon(
                Twitch,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        ],
        [
            new Weapon(
                Twitch,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1440
            ),
            new Weapon(
                Twitch,
                "LFP586",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                2540,
                2540
            )
        ],
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "RSD Model 1 - Shock Drone",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "GIGN",
        "Nancy, France",
        168,
        58,
        "Emmanuelle Pichon",
        new OperatorAge(12, 10, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Montagne"/>.
    /// </summary>
    public static Operator Montagne { get; } = new Operator(
        "Montagne",
        [
            new Weapon(
                Montagne,
                "Le Roc",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        [
            new Weapon(
                Montagne,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1440
            ),
            new Weapon(
                Montagne,
                "LFP586",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                2540,
                2540
            )
        ],
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade | Weapon.Gadget.EmpGrenade,
        "Extendable Shield \"Le Roc\"",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "GIGN",
        "Bordeaux, France",
        190,
        90,
        "Gilles Touré",
        new OperatorAge(11, 10, 48),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Glaz"/>.
    /// </summary>
    public static Operator Glaz { get; } = new Operator(
        "Glaz",
        [
            new Weapon(
                Glaz,
                "OTs-03",
                Weapon.WeaponType.SniperRifle,
                Weapon.FiringMode.SingleShot,
                71,
                360,
                10,
                Weapon.Sight.FlipSight,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1430,
                2440
            )
        ],
        [
            new Weapon(
                Glaz,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                0590,
                1280
            ),
            new Weapon(
                Glaz,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            ),
            new Weapon(
                Glaz,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2210
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.FragGrenade | Weapon.Gadget.Claymore,
        "HDS Flip Sight OTs-03 MARKSMAN Rifle",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "SPETSNAZ",
        "Vladivostok, Russia",
        178,
        79,
        "Timur Glazkov",
        new OperatorAge(2, 7, 30),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Fuze"/>.
    /// </summary>
    public static Operator Fuze { get; } = new Operator(
        "Fuze",
        [
            new Weapon(
                Fuze,
                "Ballistic Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            ),
            new Weapon(
                Fuze,
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new Weapon(
                Fuze,
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            )
        ],
        [
            new Weapon(
                Fuze,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                0590,
                1280
            ),
            new Weapon(
                Fuze,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1470
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "APM-6 Cluster Charge \"Matryoshka\"",
        [
            Specialties.AntiGadget
        ],
        "SPETSNAZ",
        "Samarkand, Uzbekistan",
        180,
        80,
        "Shuhrat Kessikbayev",
        new OperatorAge(12, 10, 34),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Blitz"/>.
    /// </summary>
    public static Operator Blitz { get; } = new Operator(
        "Blitz",
        [
            new Weapon(
                Blitz,
                "G52-Tactical Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        [
            new Weapon(
                Blitz,
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1230,
                1560
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge,
        "G52-Tactical Light Shield",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "GSG 9",
        "Bremen, Germany",
        175,
        75,
        "Elias Kötz",
        new OperatorAge(2, 4, 37),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="IQ"/>.
    /// </summary>
    public static Operator IQ { get; } = new Operator(
        "IQ",
        [
            new Weapon(
                IQ,
                "AUG A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                720,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.HorizontalGrip,
                true,
                1470,
                2340
            ),
            new Weapon(
                IQ,
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                43,
                690,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new Weapon(
                IQ,
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            )
        ],
        [
            new Weapon(
                IQ,
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1230,
                1560
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore | Weapon.Gadget.FragGrenade,
        "Electronics Detector RED Mk III \"Spectre\"",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "GSG 9",
        "Leipzig, Germany",
        175,
        70,
        "Monika Weiss",
        new OperatorAge(1, 8, 38),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Buck"/>.
    /// </summary>
    public static Operator Buck { get; } = new Operator(
        "Buck",
        [
            new Weapon(
                Buck,
                "C8-SFW",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                837,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1370,
                1540
            ),
            new Weapon(
                Buck,
                "CAMRS",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1460,
                2290
            )
        ],
        [
            new Weapon(
                Buck,
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1110,
                1320
            ),
            new Weapon(
                Buck,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.HardBreachCharge,
        "Skeleton Key SK 4-12",
        [
            Specialties.Breach,
            Specialties.Support
        ],
        "JTF2",
        "Montréal, Quebec",
        178,
        78,
        "Sebastien Côté",
        new OperatorAge(20, 8, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Blackbeard"/>.
    /// </summary>
    public static Operator Blackbeard { get; } = new Operator(
        "Blackbeard",
        [
            new Weapon(
                Blackbeard,
                "MK17 CQB",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                49,
                585,
                20,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2230
            ),
            new Weapon(
                Blackbeard,
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        ],
        [
            new Weapon(
                Blackbeard,
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                1450
            )
        ],
        Weapon.Gadget.Claymore | Weapon.Gadget.StunGrenade | Weapon.Gadget.FragGrenade,
        "TARS Mk 0-Transparent Armored Rifle Shield",
        [
            Specialties.Support
        ],
        "NAVY SEAL",
        "Bellevue, Washington",
        180,
        84,
        "Craig Jenson",
        new OperatorAge(12, 2, 32),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Capitao"/>.
    /// </summary>
    public static Operator Capitao { get; } = new Operator(
        "Capitão",
        [
            new Weapon(
                Capitao,
                "PARA-308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                650,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2000,
                2300
            ),
            new Weapon(
                Capitao,
                "M249",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                100,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6320,
                6320
            )
        ],
        [
            new Weapon(
                Capitao,
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                1590
            ),
            new Weapon(
                Capitao,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        Weapon.Gadget.Claymore | Weapon.Gadget.HardBreachCharge,
        "Tactical Crossbow TAC Mk0",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "BOPE",
        "Nova Iguaçu, Brazil",
        183,
        86,
        "Vicente Souza",
        new OperatorAge(17, 11, 49),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Hibana"/>.
    /// </summary>
    public static Operator Hibana { get; } = new Operator(
        "Hibana",
        [
            new Weapon(
                Hibana,
                "TYPE-89",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                20,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1340,
                2320
            ),
            new Weapon(
                Hibana,
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                4080,
                4560
            )
        ],
        [
            new Weapon(
                Hibana,
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1450
            ),
            new Weapon(
                Hibana,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2210
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "X-KAIROS Grenade Launcher",
        [
            Specialties.Breach,
            Specialties.FrontLine
        ],
        "SAT",
        "Tokyo, Japan (Suginami-ki)",
        173,
        57,
        "Yumiko Imagawa",
        new OperatorAge(12, 7, 34),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Jackal"/>.
    /// </summary>
    public static Operator Jackal { get; } = new Operator(
        "Jackal",
        [
            new Weapon(
                Jackal,
                "C7E",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                46,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1140,
                2010
            ),
            new Weapon(
                Jackal,
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new Weapon(
                Jackal,
                "ITA12L",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                50,
                85,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                5440,
                7190
            )
        ],
        [
            new Weapon(
                Jackal,
                "USP40",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                12,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1250,
                1410
            ),
            new Weapon(
                Jackal,
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3200,
                4580
            )
        ],
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "Eyenox Model III",
        [
            Specialties.Intel,
            Specialties.MapControl
        ],
        "GEO",
        "Ceuta, Spain",
        190,
        78,
        "Ryad Ramírez Al-Hassar",
        new OperatorAge(1, 3, 49),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ying"/>.
    /// </summary>
    public static Operator Ying { get; } = new Operator(
        "Ying",
        [
            new Weapon(
                Ying,
                "T-95 LSW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                650,
                80,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1300,
                2180
            ),
            new Weapon(
                Ying,
                "SIX12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1400,
                1400
            )
        ],
        [
            new Weapon(
                Ying,
                "Q-929",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                60,
                550,
                10,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1140,
                1440
            )
        ],
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "Candela Cluster Charges",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "SDU",
        "Hong Kong, Central",
        160,
        52,
        "Siu Mei Lin",
        new OperatorAge(12, 5, 33),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Zofia"/>.
    /// </summary>
    public static Operator Zofia { get; } = new Operator(
        "Zofia",
        [
            new Weapon(
                Zofia,
                "LMG-E",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                41,
                720,
                150,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6180,
                5430
            ),
            new Weapon(
                Zofia,
                "M762",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                730,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2350
            )
        ],
        [
            new Weapon(
                Zofia,
                "RG15",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                38,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1200,
                1370
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "KS79 Lifeline",
        [
            Specialties.Breach,
            Specialties.AntiGadget
        ],
        "GROM",
        "Wrocław, Poland",
        179,
        72,
        "Zofia Bosak",
        new OperatorAge(28, 1, 36),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Dokkaebi"/>.
    /// </summary>
    public static Operator Dokkaebi { get; } = new Operator(
        "Dokkaebi",
        [
            new Weapon(
                Dokkaebi,
                "Mk 14 EBR",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                60,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new Weapon(
                Dokkaebi,
                "BOSG.12.2",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                125,
                500,
                2,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1160,
                1430
            )
        ],
        [
            new Weapon(
                Dokkaebi,
                "SMG-12",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                28,
                1270,
                32,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2300
            ),
            new Weapon(
                Dokkaebi,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            ),
            new Weapon(
                Dokkaebi,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2220
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Logic Bomb",
        [
            Specialties.Intel,
            Specialties.MapControl
        ],
        "707th SMB",
        "Seoul, South Korea",
        180,
        70,
        "Grace Nam",
        new OperatorAge(2, 2, 29),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Lion"/>.
    /// </summary>
    public static Operator Lion { get; } = new Operator(
        "Lion",
        [
            new Weapon(
                Lion,
                "V308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                700,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1550,
                2330
            ),
            new Weapon(
                Lion,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new Weapon(
                Lion,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        ],
        [
            new Weapon(
                Lion,
                "LFP586",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                2540,
                2540
            ),
            new Weapon(
                Lion,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1440
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.FragGrenade,
        "EE-ONE-D Scanning Drone",
        [
            Specialties.Intel,
            Specialties.MapControl
        ],
        "CBRN THREAT UNIT",
        "Toulouse, France",
        185,
        87,
        "Olivier Flament",
        new OperatorAge(29, 8, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Finka"/>.
    /// </summary>
    public static Operator Finka { get; } = new Operator(
        "Finka",
        [
            new Weapon(
                Finka,
                "Spear .308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                700,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1510,
                2460
            ),
            new Weapon(
                Finka,
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new Weapon(
                Finka,
                "SASG-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                50,
                330,
                10,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1520,
                2180
            )
        ],
        [
            new Weapon(
                Finka,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                0590,
                1280
            ),
            new Weapon(
                Finka,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1470
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.FragGrenade,
        "Adrenal Surge",
        [
            Specialties.FrontLine,
            Specialties.Support
        ],
        "CBRN THREAT UNIT",
        "Gomel, Belarus",
        171,
        68,
        "Lera Melnikova",
        new OperatorAge(7, 6, 27),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Maverick"/>.
    /// </summary>
    public static Operator Maverick { get; } = new Operator(
        "Maverick",
        [
            new Weapon(
                Maverick,
                "AR-15.50",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                67,
                450,
                10,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2120
            ),
            new Weapon(
                Maverick,
                "M4",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                750,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1530,
                2400
            )
        ],
        [
            new Weapon(
                Maverick,
                "1911 TACOPS",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                55,
                450,
                8,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1240,
                1440
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "Breaching Torch",
        [
            Specialties.Breach,
            Specialties.FrontLine
        ],
        "GSUTR",
        "Boston, Massachusetts",
        180,
        82,
        "Erik Thorn",
        new OperatorAge(20, 4, 36),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Nomad"/>.
    /// </summary>
    public static Operator Nomad { get; } = new Operator(
        "Nomad",
        [
            new Weapon(
                Nomad,
                "AK-74M",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                650,
                40,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1430,
                2440
            ),
            new Weapon(
                Nomad,
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            )
        ],
        [
            new Weapon(
                Nomad,
                ".44 Mag Semi-Auto",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                54,
                450,
                7,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                0590,
                1280
            ),
            new Weapon(
                Nomad,
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                1590
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "Airjab Launcher",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "GIGR",
        "Marrakesh, Morocco",
        171,
        63,
        "Sanaa El Maktoub",
        new OperatorAge(27, 7, 39),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Gridlock"/>.
    /// </summary>
    public static Operator Gridlock { get; } = new Operator(
        "Gridlock",
        [
            new Weapon(
                Gridlock,
                "F90",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2290
            ),
            new Weapon(
                Gridlock,
                "M249 SAW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                60,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2030,
                3560
            )
        ],
        [
            new Weapon(
                Gridlock,
                "Super Shorty",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                85,
                3,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2450
            ),
            new Weapon(
                Gridlock,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            ),
            new Weapon(
                Gridlock,
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1050,
                1450
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge | Weapon.Gadget.EmpGrenade,
        "Trax Stingers",
        [
            Specialties.Support,
            Specialties.MapControl
        ],
        "SASR",
        "Longreach, Central Queensland, Australia",
        177,
        102,
        "Tori Tallyo Fairous",
        new OperatorAge(5, 8, 36),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Nokk"/>.
    /// </summary>
    public static Operator Nokk { get; } = new Operator(
        "Nøkk",
        [
            new Weapon(
                Nokk,
                "FMG-9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1420,
                2210
            ),
            new Weapon(
                Nokk,
                "SIX12 SD",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1400,
                1400
            )
        ],
        [
            new Weapon(
                Nokk,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1490
            ),
            new Weapon(
                Nokk,
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                1450
            )
        ],
        Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.EmpGrenade,
        "HEL Presence Reduction",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "JAEGER CORPS",
        "[REDACTED]",
        -1M,
        -1M,
        "[REDACTED]",
        OperatorAge.Redacted,
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Amaru"/>.
    /// </summary>
    public static Operator Amaru { get; } = new Operator(
        "Amaru",
        [
            new Weapon(
                Amaru,
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            ),
            new Weapon(
                Amaru,
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                4080,
                4560
            )
        ],
        [
            new Weapon(
                Amaru,
                "SMG-11",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                32,
                1270,
                16,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1270,
                2130
            ),
            new Weapon(
                Amaru,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            ),
            new Weapon(
                Amaru,
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3200,
                4580
            )
        ],
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.StunGrenade,
        "Garra Hook",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "APCA",
        "Cojata, Peru",
        189,
        84,
        "Azucena Rocío Quispe",
        new OperatorAge(6, 5, 48),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kali"/>.
    /// </summary>
    public static Operator Kali { get; } = new Operator(
        "Kali",
        [
            new Weapon(
                Kali,
                "CSRX 300",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                135,
                50,
                5,
                Weapon.Sight.VariableSniper,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                1500,
                2440
            )
        ],
        [
            new Weapon(
                Kali,
                "SPSMG9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                980,
                20,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.HorizontalGrip,
                true,
                1350,
                1590
            ),
            new Weapon(
                Kali,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2220
            ),
            new Weapon(
                Kali,
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1430
            )
        ],
        Weapon.Gadget.Claymore | Weapon.Gadget.BreachCharge,
        "Low Velocity (LV) Explosive Lance",
        [
            Specialties.AntiGadget,
            Specialties.Support
        ],
        "NIGHTHAVEN",
        "Amreli, India",
        170,
        67,
        "Jaimini Kalimohan Shah",
        new OperatorAge(21, 8, 34),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Iana"/>.
    /// </summary>
    public static Operator Iana { get; } = new Operator(
        "Iana",
        [
            new Weapon(
                Iana,
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            ),
            new Weapon(
                Iana,
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            )
        ],
        [
            new Weapon(
                Iana,
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1110,
                1320
            ),
            new Weapon(
                Iana,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.SmokeGrenade,
        "Gemini Replicator",
        [
            Specialties.FrontLine,
            Specialties.Intel
        ],
        "REU",
        "Katwijk, Netherlands",
        157,
        56,
        "Nienke Meijer",
        new OperatorAge(27, 8, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ace"/>.
    /// </summary>
    public static Operator Ace { get; } = new Operator(
        "Ace",
        [
            new Weapon(
                Ace,
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            ),
            new Weapon(
                Ace,
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4450,
                5330
            )
        ],
        [
            new Weapon(
                Ace,
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1440
            )
        ],
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "S.E.L.M.A. Aqua Breacher",
        [
            Specialties.Breach,
            Specialties.AntiGadget
        ],
        "NIGHTHAVEN",
        "Lærdalsøyri, Norway",
        187,
        75,
        "Håvard Haugland",
        new OperatorAge(15, 3, 33),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Zero"/>.
    /// </summary>
    public static Operator Zero { get; } = new Operator(
        "Zero",
        [
            new Weapon(
                Zero,
                "SC3000K",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                850,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1520,
                2470
            ),
            new Weapon(
                Zero,
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2250
            )
        ],
        [
            new Weapon(
                Zero,
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                35,
                550,
                20,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1490
            ),
            new Weapon(
                Zero,
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                0,
                0
            )
        ],
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "ARGUS Launcher",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "ROS",
        "Baltimore, Maryland",
        178,
        77,
        "Samuel Leo Fisher",
        new OperatorAge(8, 8, 63),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Flores"/>.
    /// </summary>
    public static Operator Flores { get; } = new Operator(
        "Flores",
        [
            new Weapon(
                Flores,
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new Weapon(
                Flores,
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        ],
        [
            new Weapon(
                Flores,
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1260,
                1470
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore,
        "RCE-Ratero Charge",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "UNAFFILIATED",
        "Buenos Aires, Argentina",
        181,
        72,
        "Santiago Miguel Lucero",
        new OperatorAge(2, 10, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Osa"/>.
    /// </summary>
    public static Operator Osa { get; } = new Operator(
        "Osa",
        [
            new Weapon(
                Osa,
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            ),
            new Weapon(
                Osa,
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            )
        ],
        [
            new Weapon(
                Osa,
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                0590,
                1280
            )
        ],
        Weapon.Gadget.FragGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade,
        "Talon-8 Clear Shield",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "NIGHTHAVEN",
        "Split, Croatia",
        180,
        71,
        "Anja Katarina Janković",
        new OperatorAge(29, 4, 27),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Sens"/>.
    /// </summary>
    public static Operator Sens { get; } = new Operator(
        "Sens",
        [
            new Weapon(
                Sens,
                "POF-9",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                35,
                740,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1470,
                2240
            ),
            new Weapon(
                Sens,
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1350,
                2190
            )
        ],
        [
            new Weapon(
                Sens,
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1050,
                1450
            ),
        ],
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore | Weapon.Gadget.FragGrenade,
        "R.O.U. Projector System",
        [
            Specialties.Support,
            Specialties.MapControl
        ],
        "SFG",
        "Brussels, Belgium",
        178,
        73,
        "Néon Ngoma Mutombo",
        new OperatorAge(3, 3, 30),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Grim"/>.
    /// </summary>
    public static Operator Grim { get; } = new Operator(
        "Grim",
        [
            new Weapon(
                Grim,
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                43,
                690,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new Weapon(
                Grim,
                "SG-CQB",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                53,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip,
                true,
                4090,
                4580
            )
        ],
        [
            new Weapon(
                Grim,
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1220,
                1450
            ),
            new Weapon(
                Grim,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            )
        ],
        Weapon.Gadget.EmpGrenade | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "Kawan Hive Launcher",
        [
            Specialties.FrontLine,
            Specialties.MapControl
        ],
        "NIGHTHAVEN",
        "Jurong, Singapore",
        179,
        89.8M,
        "Charlie Tho Keng Boon",
        new OperatorAge(5, 4, 39),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Brava"/>.
    /// </summary>
    public static Operator Brava { get; } = new Operator(
        "Brava",
        [
            new Weapon(
                Brava,
                "PARA-308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                650,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2000,
                2300
            ),
            new Weapon(
                Brava,
                "CAMRS",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Telescopic,
                Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2290
            )
        ],
        [
            new Weapon(
                Brava,
                "Super Shorty",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                85,
                3,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2450
            ),
            new Weapon(
                Brava,
                "USP40",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                12,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1250,
                1410
            )
        ],
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.Claymore,
        "Kludge Drone",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "COT",
        "Curitiba, Brazil",
        170,
        71M,
        "Nayara Cardoso",
        new OperatorAge(10, 1, 40),
        3
    );
    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ram"/>.
    /// </summary>
    public static Operator Ram { get; } = new Operator(
        "Ram",
        [
            new Weapon(
                Ram,
                "R4-C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                39,
                860,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2200
            ),
            new Weapon(
                Ram,
                "LMG-E",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                41,
                720,
                150,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6180,
                5430
            )
        ],
        [
            new Weapon(
                Ram,
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1110,
                1320
            ),
            new Weapon(
                Ram,
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3200,
                4580
            )
        ],
        Weapon.Gadget.StunGrenade | Weapon.Gadget.SmokeGrenade,
        "BU-GI Auto-Breacher",
        [
            Specialties.Breach,
            Specialties.AntiGadget
        ],
        "35th Commando Battalion",
        "Busan, South Korea",
        1.78M,
        68M,
        "Bo-Ram Choi",
        new OperatorAge(25, 4, 37),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Deimos"/>.
    /// </summary>
    public static Operator Deimos { get; } = new Operator(
        "Deimos",
        [
            new Weapon(
                Deimos,
                "AK-74M",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                650,
                40,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1430,
                2440
            ),
        ],
        [
            
        ],
        Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge,
        "Deathmark Tracker",
        [
            Specialties.Intel,
            Specialties.MapControl
        ],
        "Keres Legion",
        "Birmingham, Alabama",
        1.86M,
        94M,
        "Gerald Morris",
        new OperatorAge(24, 12, 51),
        1
    );
#endregion

#pragma warning restore CS8604 // Possible null reference argument.

    /// <summary>
    /// Compiles specific challenges from all <see cref="Attackers"/>' specialties into a collection.
    /// </summary>
    /// <param name="breach">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.Breach" /> <see cref="Specialty" />.</param>
    /// <param name="support">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.Support" /> <see cref="Specialty" />.</param>
    /// <param name="frontline">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.FrontLine" /> <see cref="Specialty" />.</param>
    /// <param name="intel">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.Intel" /> <see cref="Specialty" />.</param>
    /// <param name="antigadget">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.AntiGadget" /> <see cref="Specialty" />.</param>
    /// <param name="mapcontrol">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Specialties.MapControl" /> <see cref="Specialty" />.</param>
    /// <returns>A</returns>
    public static Dictionary<Specialty, string> GetPersonalSpecialtyChallengeSet(int breach, int support, int frontline, int intel, int antigadget, int mapcontrol)
    {
        Dictionary<Specialty, string> challenges = [];

        if (breach is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Breach, $"{Specialties.Breach.Name,-13} -> {Specialties.Breach.Challenges[breach - 1].Description}");
        }
        if (support is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Support, $"{Specialties.Support.Name,-13} -> {Specialties.Support.Challenges[support - 1].Description}");
        }
        if (frontline is >= 1 and <= 3)
        {
            challenges.Add(Specialties.FrontLine, $"{Specialties.FrontLine.Name,-13} -> {Specialties.FrontLine.Challenges[frontline - 1].Description}");
        }
        if (intel is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Intel, $"{Specialties.Intel.Name,-13} -> {Specialties.Intel.Challenges[intel - 1].Description}");
        }
        if (antigadget is >= 1 and <= 3)
        {
            challenges.Add(Specialties.AntiGadget, $"{Specialties.AntiGadget.Name,-13} -> {Specialties.AntiGadget.Challenges[antigadget - 1].Description}");
        }
        if (mapcontrol is >= 1 and <= 3)
        {
            challenges.Add(Specialties.MapControl, $"{Specialties.MapControl.Name,-13} -> {Specialties.MapControl.Challenges[mapcontrol - 1].Description}");
        }

        return challenges;
    }
}
