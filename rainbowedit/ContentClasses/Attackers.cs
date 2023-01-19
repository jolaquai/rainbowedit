namespace RainbowEdit;

public partial class Attackers : IEnumerable<Operator>, IEnumerator<Operator>
{
    internal Attackers()
    {
        _operators = new()
        {
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
            Grim
        };
    }

    public readonly Operator Sledge = new(
        "Sledge",
        new List<Weapon>()
        {
            new(
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4030,
                4510
            ),
            new(
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            )
        },
        new List<Weapon>()
        {
            new(
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Tactical Breaching Hammer \"The Caber\"",
        "SAS",
        "John O'Groats, Scotland",
        192,
        95,
        "Seamus Cowden",
        new(2, 4, 35),
        1
    );

    public readonly Operator Thatcher = new(
        "Thatcher",
        new List<Weapon>()
        {
            new(
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new(
                "L85A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                670,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1500,
                2360
            ),
            new(
                "M590A1",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                48,
                85,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4030,
                4510
            )
        },
        new List<Weapon>()
        {
            new(
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "EG Mk 0-EMP Grenade",
        "SAS",
        "Bideford, England",
        180,
        72,
        "Mike Baker",
        new(22, 6, 56),
        1
    );

    public readonly Operator Ash = new(
        "Ash",
        new List<Weapon>()
        {
            new(
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            ),
            new(
                "R4-C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                39,
                860,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2200
            )
        },
        new List<Weapon>()
        {
            new(
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1100,
                1300
            ),
            new(
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "M120 CREM Breaching Rounds",
        "FBI SWAT",
        "Jerusalem, Israel",
        170,
        63,
        "Eliza Cohen",
        new(24, 12, 33),
        3
    );

    public readonly Operator Thermite = new(
        "Thermite",
        new List<Weapon>()
        {
            new(
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4450,
                5330
            ),
            new(
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            )
        },
        new List<Weapon>()
        {
            new(
                "M45 Meusoc",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                58,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1100,
                1300
            ),
            new(
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
        "Brimstone BC-3 Exothermic Charges",
        "FBI SWAT",
        "Plano, Texas",
        178,
        80,
        "Jordan Trace",
        new(14, 3, 35),
        2
    );

    public readonly Operator Twitch = new(
        "Twitch",
        new List<Weapon>()
        {
            new(
                "F2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                37,
                980,
                25,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1420,
                2320
            ),
            new(
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new(
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
        },
        new List<Weapon>()
        {
            new(
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            ),
            new(
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "RSD Model 1 - Shock Drone",
        "GIGN",
        "Nancy, France",
        168,
        58,
        "Emmanuelle Pichon",
        new(12, 10, 28),
        2
    );

    public readonly Operator Montagne = new(
        "Montagne",
        new List<Weapon>()
        {
            new(
                "Le Roc",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        new List<Weapon>()
        {
            new(
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            ),
            new(
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade | Weapon.Gadget.EmpGrenade,
        "Extendable Shield \"Le Roc\"",
        "GIGN",
        "Bordeaux, France",
        190,
        90,
        "Gilles Touré",
        new(11, 10, 48),
        1
    );

    public readonly Operator Glaz = new(
        "Glaz",
        new List<Weapon>()
        {
            new(
                "OTs-03",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                71,
                360,
                10,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1430,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.FragGrenade | Weapon.Gadget.Claymore,
        "HDS Flip Sight OTs-03 MARKSMAN Rifle",
        "SPETSNAZ",
        "Vladivostok, Russia",
        178,
        79,
        "Timur Glazkov",
        new(2, 7, 30),
        3
    );

    public readonly Operator Fuze = new(
        "Fuze",
        new List<Weapon>()
        {
            new(
                "Ballistic Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new(
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            )
        },
        new List<Weapon>()
        {
            new(
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "APM-6 Cluster Charge \"Matryoshka\"",
        "SPETSNAZ",
        "Samarkand, Uzbekistan",
        180,
        80,
        "Shuhrat Kessikbayev",
        new(12, 10, 34),
        1
    );

    public readonly Operator Blitz = new(
        "Blitz",
        new List<Weapon>()
        {
            new(
                "G52-Tactical Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                0,
                0,
                0,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        new List<Weapon>()
        {
            new(
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1230,
                1560
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge,
        "G52-Tactical Light Shield",
        "GSG 9",
        "Bremen, Germany",
        175,
        75,
        "Elias Kötz",
        new(2, 4, 37),
        2
    );

    public readonly Operator IQ = new(
        "IQ",
        new List<Weapon>()
        {
            new(
                "AUG A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                720,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1470,
                2340
            ),
            new(
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                48,
                690,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new(
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            )
        },
        new List<Weapon>()
        {
            new(
                "P12",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1230,
                1560
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "Electronics Detector RED Mk III \"Spectre\"",
        "GSG 9",
        "Leipzig, Germany",
        175,
        70,
        "Monika Weiss",
        new(1, 8, 38),
        3
    );

    public readonly Operator Buck = new(
        "Buck",
        new List<Weapon>()
        {
            new(
                "C8-SFW",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                837,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1370,
                1540
            ),
            new(
                "CAMRS",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1460,
                2290
            )
        },
        new List<Weapon>()
        {
            new(
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1110,
                1320
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.HardBreachCharge,
        "Skeleton Key SK 4-12",
        "JTF2",
        "Montréal, Quebec",
        178,
        78,
        "Sebastien Côté",
        new(20, 8, 36),
        2
    );

    public readonly Operator Blackbeard = new(
        "Blackbeard",
        new List<Weapon>()
        {
            new(
                "MK17 CQB",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                49,
                585,
                20,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2230
            ),
            new(
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1450
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "TARS Mk 0-Transparent Armored Rifle Shield",
        "NAVY SEAL",
        "Bellevue, Washington",
        180,
        84,
        "Craig Jenson",
        new(12, 2, 32),
        2
    );

    public readonly Operator Capitao = new(
        "Capitão",
        new List<Weapon>()
        {
            new(
                "PARA-308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                650,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2000,
                2300
            ),
            new(
                "M249",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                100,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6320,
                6320
            )
        },
        new List<Weapon>()
        {
            new(
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1590
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.HardBreachCharge,
        "Tactical Crossbow TAC Mk0",
        "BOPE",
        "Nova Iguaçu, Brazil",
        183,
        86,
        "Vicente Souza",
        new(17, 11, 49),
        3
    );

    public readonly Operator Hibana = new(
        "Hibana",
        new List<Weapon>()
        {
            new(
                "TYPE-89",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                20,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1340,
                2320
            ),
            new(
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                4080,
                4560
            )
        },
        new List<Weapon>()
        {
            new(
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1450
            ),
            new(
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "X-KAIROS Grenade Launcher",
        "SAT",
        "Tokyo, Japan (Suginami-ki)",
        173,
        57,
        "Yumiko Imagawa",
        new(12, 7, 34),
        3
    );

    public readonly Operator Jackal = new(
        "Jackal",
        new List<Weapon>()
        {
            new(
                "C7E",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                46,
                800,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1140,
                2010
            ),
            new(
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new(
                "ITA12L",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                50,
                85,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                5440,
                7190
            )
        },
        new List<Weapon>()
        {
            new(
                "USP40",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1250,
                1410
            ),
            new(
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3200,
                4580
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.SmokeGrenade,
        "Eyenox Model III",
        "GEO",
        "Ceuta, Spain",
        190,
        78,
        "Ryad Ramírez Al-Hassar",
        new(1, 3, 49),
        2
    );

    public readonly Operator Ying = new(
        "Ying",
        new List<Weapon>()
        {
            new(
                "T-95 LSW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                650,
                80,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1300,
                2180
            ),
            new(
                "SIX12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1400,
                1400
            )
        },
        new List<Weapon>()
        {
            new(
                "Q-929",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                60,
                550,
                10,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1140,
                1440
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade,
        "Candela Cluster Charges",
        "SDU",
        "Hong Kong, Central",
        160,
        52,
        "Siu Mei Lin",
        new(12, 5, 33),
        2
    );

    public readonly Operator Zofia = new(
        "Zofia",
        new List<Weapon>()
        {
            new(
                "LMG-E",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                41,
                720,
                150,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6180,
                5430
            ),
            new(
                "M762",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                730,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2350
            )
        },
        new List<Weapon>()
        {
            new(
                "RG15",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                38,
                550,
                15,
                Weapon.Sight.Other,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1200,
                1370
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "KS79 Lifeline",
        "GROM",
        "Wrocław, Poland",
        179,
        72,
        "Zofia Bosak",
        new(28, 1, 36),
        1
    );

    public readonly Operator Dokkaebi = new(
        "Dokkaebi",
        new List<Weapon>()
        {
            new(
                "Mk 14 EBR",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                60,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            ),
            new(
                "BOSG.12.2",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                125,
                500,
                2,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1160,
                1430
            )
        },
        new List<Weapon>()
        {
            new(
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
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                1320,
                2220
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade | Weapon.Gadget.EmpGrenade,
        "Logic Bomb",
        "707th SMB",
        "Seoul, South Korea",
        180,
        70,
        "Grace Nam",
        new(2, 2, 29),
        3
    );

    public readonly Operator Lion = new(
        "Lion",
        new List<Weapon>()
        {
            new(
                "V308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                700,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1550,
                2330
            ),
            new(
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1350,
                2190
            ),
            new(
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
        },
        new List<Weapon>()
        {
            new(
                "LFP586",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                550,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                2540,
                2540
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0),
            new(
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade,
        "EE-ONE-D Scanning Drone",
        "CBRN THREAT UNIT",
        "Toulouse, France",
        185,
        87,
        "Olivier Flament",
        new(29, 8, 31),
        2
    );

    public readonly Operator Finka = new(
        "Finka",
        new List<Weapon>()
        {
            new(
                "Spear .308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                700,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1510,
                2460
            ),
            new(
                "6P41",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                46,
                680,
                100,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                6580,
                7160
            ),
            new(
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
        },
        new List<Weapon>()
        {
            new(
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
        "Adrenal Surge",
        "CBRN THREAT UNIT",
        "Gomel, Belarus",
        171,
        68,
        "Lera Melnikova",
        new(7, 6, 27),
        2
    );

    public readonly Operator Maverick = new(
        "Maverick",
        new List<Weapon>()
        {
            new(
                "AR-15.50",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                67,
                450,
                10,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2120
            ),
            new(
                "M4",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                750,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1530,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                "1911 TACOPS",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                55,
                450,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1240,
                1440
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore,
        "Breaching Torch",
        "GSUTR",
        "Boston, Massachusetts",
        180,
        82,
        "Erik Thorn",
        new(20, 4, 36),
        3
    );

    public readonly Operator Nomad = new(
        "Nomad",
        new List<Weapon>()
        {
            new(
                "AK-74M",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                44,
                650,
                40,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1430,
                2440
            ),
            new(
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            )
        },
        new List<Weapon>()
        {
            new(
                ".44 Mag Semi-Auto",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                54,
                450,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                0590,
                1280
            ),
            new(
                "PRB92",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                450,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1590
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.BreachCharge,
        "Airjab Launcher",
        "GIGR",
        "Marrakesh, Morocco",
        171,
        63,
        "Sanaa El Maktoub",
        new(27, 7, 39),
        2
    );

    public readonly Operator Gridlock = new(
        "Gridlock",
        new List<Weapon>()
        {
            new(
                "F90",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2290
            ),
            new(
                "M249 SAW",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                48,
                650,
                60,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2030,
                3560
            )
        },
        new List<Weapon>()
        {
            new(
                "Super Shorty",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                85,
                3,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1300,
                2450
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1050,
                1450
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.BreachCharge | Weapon.Gadget.EmpGrenade,
        "Trax Stingers",
        "SASR",
        "Longreach, Central Queensland, Australia",
        177,
        102,
        "Tori Tallyo Fairous",
        new(5, 8, 36),
        1
    );

    public readonly Operator Nokk = new(
        "Nøkk",
        new List<Weapon>()
        {
            new(
                "FMG-9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1420,
                2210
            ),
            new(
                "SIX12 SD",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1400,
                1400
            )
        },
        new List<Weapon>()
        {
            new(
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                42,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1490
            ),
            new(
                "D-50",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                71,
                550,
                7,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1320,
                1450
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.EmpGrenade,
        "HEL Presence Reduction",
        "JAEGER CORPS",
        "[REDACTED]",
        -1M,
        -1M,
        "[REDACTED]",
        Operator.OperatorAge.Redacted,
        2
    );

    public readonly Operator Amaru = new(
        "Amaru",
        new List<Weapon>()
        {
            new(
                "G8A1",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                37,
                850,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                2120,
                3220
            ),
            new(
                "Supernova",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                55,
                75,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                4080,
                4560
            )
        },
        new List<Weapon>()
        {
            new(
                "SMG-11",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1270,
                16,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1270,
                2130
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            ),
            new(
                "ITA12S",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                70,
                85,
                5,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3200,
                4580
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.StunGrenade,
        "Garra Hook",
        "APCA",
        "Cojata, Peru",
        189,
        84,
        "Azucena Rocío Quispe",
        new(6, 5, 48),
        2
    );

    public readonly Operator Kali = new(
        "Kali",
        new List<Weapon>()
        {
            new(
                "CSRX 300",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                135,
                50,
                5,
                Weapon.Sight.SixTwelve,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                1500,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                "SPSMG9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                980,
                20,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1350,
                1590
            ),
            new(
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.None,
                true,
                1320,
                2220
            ),
            new(
                "P226 MK 25",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                50,
                550,
                15,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1430
            )
        },
        Weapon.Gadget.Claymore | Weapon.Gadget.BreachCharge,
        "Low Velocity (LV) Explosive Lance",
        "NIGHTHAVEN",
        "Amreli, India",
        170,
        67,
        "Jaimini Kalimohan Shah",
        new(21, 8, 34),
        2
    );

    public readonly Operator Iana = new(
        "Iana",
        new List<Weapon>()
        {
            new(
                "ARX200",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                700,
                20,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1420,
                2350
            ),
            new(
                "G36C",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                780,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2340
            )
        },
        new List<Weapon>()
        {
            new(
                "MK1 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                48,
                550,
                13,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1110,
                1320
            )
        },
        Weapon.Gadget.FragGrenade | Weapon.Gadget.SmokeGrenade,
        "Gemini Replicator",
        "REU",
        "Katwijk, Netherlands",
        157,
        56,
        "Nienke Meijer",
        new(27, 8, 35),
        2
    );

    public readonly Operator Ace = new(
        "Ace",
        new List<Weapon>()
        {
            new(
                "AK-12",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                40,
                850,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2260
            ),
            new(
                "M1014",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                34,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4450,
                5330
            )
        },
        new List<Weapon>()
        {
            new(
                "P9",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                45,
                550,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1440
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "S.E.L.M.A. Aqua Breacher",
        "NIGHTHAVEN",
        "Lærdalsøyri, Norway",
        187,
        75,
        "Håvard Haugland",
        new(15, 3, 33),
        2
    );

    public readonly Operator Zero = new(
        "Zero",
        new List<Weapon>()
        {
            new(
                "SC3000K",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                45,
                850,
                25,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1520,
                2470
            ),
            new(
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1320,
                2250
            )
        },
        new List<Weapon>()
        {
            new(
                "5.7 USG",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                35,
                550,
                20,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1260,
                1490
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "ARGUS Launcher",
        "ROS",
        "Baltimore, Maryland",
        178,
        77,
        "Samuel Leo Fisher",
        new(8, 8, 63),
        3
    );

    public readonly Operator Flores = new(
        "Flores",
        new List<Weapon>()
        {
            new(
                "AR33",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                41,
                749,
                25,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2310
            ),
            new(
                "SR-25",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                61,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1380,
                2400
            )
        },
        new List<Weapon>()
        {
            new(
                "GSH-18",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                44,
                550,
                18,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1260,
                1470
            )
        },
        Weapon.Gadget.StunGrenade | Weapon.Gadget.Claymore,
        "RCE-Ratero Charge",
        "UNAFFILIATED",
        "Buenos Aires, Argentina",
        181,
        72,
        "Santiago Miguel Lucero",
        new(2, 10, 28),
        2
    );

    public readonly Operator Osa = new(
        "Osa",
        new List<Weapon>()
        {
            new(
                "556XI",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                47,
                690,
                30,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1460,
                2410
            ),
            new(
                "PDW9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                "PMM",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                61,
                550,
                8,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                0590,
                1280
            )
        },
        Weapon.Gadget.SmokeGrenade | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade,
        "Talon-8 Clear Shield",
        "NIGHTHAVEN",
        "Split, Croatia",
        180,
        71,
        "Anja Katarina Janković",
        new(29, 4, 27),
        1
    );

    public readonly Operator Sens = new(
        "Sens",
        new List<Weapon>()
        {
            new(
                "POF-9",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                35,
                740,
                50,
                Weapon.Sight.TwoPointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1470,
                2240
            ),
            new(
                "417",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                69,
                450,
                20,
                Weapon.Sight.Three,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                1350,
                2190
            )
        },
        new List<Weapon>()
        {
            new(
                "SDP 9mm",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                47,
                450,
                16,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1050,
                1450
            ),
            new(
                "GONNE-6",
                Weapon.WeaponType.HandCannon,
                Weapon.FiringMode.SingleShot,
                10,
                0,
                1,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                0,
                0
            )
        },
        Weapon.Gadget.HardBreachCharge | Weapon.Gadget.Claymore,
        "R.O.U. Projector System",
        "SFG",
        "Brussels, Belgium",
        178,
        73,
        "Néon Ngoma Mutombo",
        new(3, 3, 30),
        3
    );

    public readonly Operator Grim = new(
        "Grim",
        new List<Weapon>()
        {
            new(
                "552 Commando",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                48,
                690,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1390,
                2170
            ),
            new(
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
        },
        new List<Weapon>()
        {
            new(
                "P229",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                51,
                550,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1220,
                1450
            )
        },
        Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore,
        "Kawan Hive Launcher",
        "NIGHTHAVEN",
        "Jurong, Singapore",
        179,
        89.8M,
        "Charlie Tho Keng Boon",
        new(5, 4, 39),
        3
    );
}
