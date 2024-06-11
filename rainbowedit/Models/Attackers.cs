using rainbowedit.Models;

namespace rainbowedit;

/// <summary>
/// The <see cref="Attackers"/> in Siege.
/// </summary>
public static class Attackers
{
    /// <summary>
    /// Retrieves a <see cref="List{T}"/> of all <see cref="Attacker"/>s.
    /// </summary>
    public static ImmutableArray<Attacker> All { get; private set; }

    static Attackers()
    {
        #region Attacker instances
        #region Recruit/Striker
        Striker = new Attacker(
            "Striker",
            [
                new Weapon(
                    null!,
                    "M4",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    44,
                    750,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1530,
                    2400
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            Weapon.Gadget.BreachCharge | Weapon.Gadget.Claymore | Weapon.Gadget.EmpGrenade | Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge | Weapon.Gadget.SmokeGrenade | Weapon.Gadget.StunGrenade,
            "Gadget Kit",
            [Specialties.Support],
            "ROS",
            "Undefined",
            -1,
            -1,
            "Undefined",
            OperatorAge.Undefined,
            2
        );
        #endregion

        #region Sledge
        Sledge = new Attacker(
            "Sledge",
            [
                new Weapon(
                    null!,
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
                    null!,
                    "L85A2",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    670,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1500,
                    2360
                )
            ],
            [
                new Weapon(
                    null!,
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
            [Specialties.Breach, Specialties.AntiGadget],
            "SAS",
            "John O'Groats, Scotland",
            192,
            95,
            "Seamus Cowden",
            new OperatorAge(2, 4, 35),
            1
        );
        #endregion
        #region Thatcher
        Thatcher = new Attacker(
            "Thatcher",
            [
                new Weapon(
                    null!,
                    "AR33",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    41,
                    749,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1250,
                    2310
                ),
                new Weapon(
                    null!,
                    "L85A2",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    670,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1500,
                    2360
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Support],
            "SAS",
            "Bideford, England",
            180,
            72,
            "Mike Baker",
            new OperatorAge(22, 6, 56),
            1
        );
        #endregion
        #region Ash
        Ash = new Attacker(
            "Ash",
            [
                new Weapon(
                    null!,
                    "G36C",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    38,
                    780,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1320,
                    2340
                ),
                new Weapon(
                    null!,
                    "R4-C",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    39,
                    860,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1330,
                    2200
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.FrontLine],
            "FBI SWAT",
            "Jerusalem, Israel",
            170,
            63,
            "Eliza Cohen",
            new OperatorAge(24, 12, 33),
            3
        );
        #endregion
        #region Thermite
        Thermite = new Attacker(
            "Thermite",
            [
                new Weapon(
                    null!,
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
                    null!,
                    "556XI",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    690,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1460,
                    2410
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.Support],
            "FBI SWAT",
            "Plano, Texas",
            178,
            80,
            "Jordan Trace",
            new OperatorAge(14, 3, 35),
            2
        );
        #endregion
        #region Twitch
        Twitch = new Attacker(
            "Twitch",
            [
                new Weapon(
                    null!,
                    "F2",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    37,
                    980,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1420,
                    2320
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Intel],
            "GIGN",
            "Nancy, France",
            168,
            58,
            "Emmanuelle Pichon",
            new OperatorAge(12, 10, 28),
            2
        );
        #endregion
        #region Montagne
        Montagne = new Attacker(
            "Montagne",
            [
                new Weapon(
                    null!,
                    "Le Roc",
                    Weapon.WeaponType.Shield,
                    Weapon.FiringMode.Invalid,
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
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.Support],
            "GIGN",
            "Bordeaux, France",
            190,
            90,
            "Gilles Touré",
            new OperatorAge(11, 10, 48),
            1
        );
        #endregion
        #region Glaz
        Glaz = new Attacker(
            "Glaz",
            [
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.Support],
            "SPETSNAZ",
            "Vladivostok, Russia",
            178,
            79,
            "Timur Glazkov",
            new OperatorAge(2, 7, 30),
            3
        );
        #endregion
        #region Fuze
        Fuze = new Attacker(
            "Fuze",
            [
                new Weapon(
                    null!,
                    "Ballistic Shield",
                    Weapon.WeaponType.Shield,
                    Weapon.FiringMode.Invalid,
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
                    null!,
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
                    null!,
                    "AK-12",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    40,
                    850,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1430,
                    2260
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            Weapon.Gadget.BreachCharge
                | Weapon.Gadget.HardBreachCharge
                | Weapon.Gadget.SmokeGrenade,
            "APM-6 Cluster Charge \"Matryoshka\"",
            [Specialties.AntiGadget],
            "SPETSNAZ",
            "Samarkand, Uzbekistan",
            180,
            80,
            "Shuhrat Kessikbayev",
            new OperatorAge(12, 10, 34),
            1
        );
        #endregion
        #region Blitz
        Blitz = new Attacker(
            "Blitz",
            [
                new Weapon(
                    null!,
                    "G52-Tactical Shield",
                    Weapon.WeaponType.Shield,
                    Weapon.FiringMode.Invalid,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "GSG 9",
            "Bremen, Germany",
            175,
            75,
            "Elias Kötz",
            new OperatorAge(2, 4, 37),
            2
        );
        #endregion
        #region IQ
        IQ = new Attacker(
            "IQ",
            [
                new Weapon(
                    null!,
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
                    null!,
                    "552 Commando",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    43,
                    690,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1390,
                    2170
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.Support],
            "GSG 9",
            "Leipzig, Germany",
            175,
            70,
            "Monika Weiss",
            new OperatorAge(1, 8, 38),
            3
        );
        #endregion
        #region Buck
        Buck = new Attacker(
            "Buck",
            [
                new Weapon(
                    null!,
                    "C8-SFW",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    40,
                    837,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1370,
                    1540
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.Support],
            "JTF2",
            "Montréal, Quebec",
            178,
            78,
            "Sebastien Côté",
            new OperatorAge(20, 8, 36),
            2
        );
        #endregion
        #region Blackbeard
        Blackbeard = new Attacker(
            "Blackbeard",
            [
                new Weapon(
                    null!,
                    "MK17 CQB",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    49,
                    585,
                    20,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1430,
                    2230
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Support],
            "NAVY SEAL",
            "Bellevue, Washington",
            180,
            84,
            "Craig Jenson",
            new OperatorAge(12, 2, 32),
            2
        );
        #endregion
        #region Capitao
        Capitao = new Attacker(
            "Capitão",
            [
                new Weapon(
                    null!,
                    "PARA-308",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    650,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    2000,
                    2300
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "BOPE",
            "Nova Iguaçu, Brazil",
            183,
            86,
            "Vicente Souza",
            new OperatorAge(17, 11, 49),
            3
        );
        #endregion
        #region Hibana
        Hibana = new Attacker(
            "Hibana",
            [
                new Weapon(
                    null!,
                    "TYPE-89",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    40,
                    850,
                    20,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1340,
                    2320
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.FrontLine],
            "SAT",
            "Tokyo, Japan (Suginami-ki)",
            173,
            57,
            "Yumiko Imagawa",
            new OperatorAge(12, 7, 34),
            3
        );
        #endregion
        #region Jackal
        Jackal = new Attacker(
            "Jackal",
            [
                new Weapon(
                    null!,
                    "C7E",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    46,
                    800,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1140,
                    2010
                ),
                new Weapon(
                    null!,
                    "PDW9",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    800,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1490,
                    2440
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.MapControl],
            "GEO",
            "Ceuta, Spain",
            190,
            78,
            "Ryad Ramírez Al-Hassar",
            new OperatorAge(1, 3, 49),
            2
        );
        #endregion
        #region Ying
        Ying = new Attacker(
            "Ying",
            [
                new Weapon(
                    null!,
                    "T-95 LSW",
                    Weapon.WeaponType.LightMachineGun,
                    Weapon.FiringMode.FullAuto,
                    46,
                    650,
                    80,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1300,
                    2180
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "SDU",
            "Hong Kong, Central",
            160,
            52,
            "Siu Mei Lin",
            new OperatorAge(12, 5, 33),
            2
        );
        #endregion
        #region Zofia
        Zofia = new Attacker(
            "Zofia",
            [
                new Weapon(
                    null!,
                    "LMG-E",
                    Weapon.WeaponType.LightMachineGun,
                    Weapon.FiringMode.FullAuto,
                    41,
                    720,
                    150,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    6180,
                    5430
                ),
                new Weapon(
                    null!,
                    "M762",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    45,
                    730,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1590,
                    2350
                )
            ],
            [
                new Weapon(
                    null!,
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
            [Specialties.Breach, Specialties.AntiGadget],
            "GROM",
            "Wrocław, Poland",
            179,
            72,
            "Zofia Bosak",
            new OperatorAge(28, 1, 36),
            1
        );
        #endregion
        #region Dokkaebi
        Dokkaebi = new Attacker(
            "Dokkaebi",
            [
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.MapControl],
            "707th SMB",
            "Seoul, South Korea",
            180,
            70,
            "Grace Nam",
            new OperatorAge(2, 2, 29),
            3
        );
        #endregion
        #region Lion
        Lion = new Attacker(
            "Lion",
            [
                new Weapon(
                    null!,
                    "V308",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    44,
                    700,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1550,
                    2330
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Intel, Specialties.MapControl],
            "CBRN THREAT UNIT",
            "Toulouse, France",
            185,
            87,
            "Olivier Flament",
            new OperatorAge(29, 8, 31),
            2
        );
        #endregion
        #region Finka
        Finka = new Attacker(
            "Finka",
            [
                new Weapon(
                    null!,
                    "Spear .308",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    42,
                    700,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1510,
                    2460
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.Support],
            "CBRN THREAT UNIT",
            "Gomel, Belarus",
            171,
            68,
            "Lera Melnikova",
            new OperatorAge(7, 6, 27),
            2
        );
        #endregion
        #region Maverick
        Maverick = new Attacker(
            "Maverick",
            [
                new Weapon(
                    null!,
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
                    null!,
                    "M4",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    44,
                    750,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1530,
                    2400
                )
            ],
            [
                new Weapon(
                    null!,
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
            [Specialties.Breach, Specialties.FrontLine],
            "GSUTR",
            "Boston, Massachusetts",
            180,
            82,
            "Erik Thorn",
            new OperatorAge(20, 4, 36),
            3
        );
        #endregion
        #region Nomad
        Nomad = new Attacker(
            "Nomad",
            [
                new Weapon(
                    null!,
                    "AK-74M",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    44,
                    650,
                    40,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1430,
                    2440
                ),
                new Weapon(
                    null!,
                    "ARX200",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    700,
                    20,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1420,
                    2350
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "GIGR",
            "Marrakesh, Morocco",
            171,
            63,
            "Sanaa El Maktoub",
            new OperatorAge(27, 7, 39),
            2
        );
        #endregion
        #region Gridlock
        Gridlock = new Attacker(
            "Gridlock",
            [
                new Weapon(
                    null!,
                    "F90",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    38,
                    780,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1380,
                    2290
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.Support, Specialties.MapControl],
            "SASR",
            "Longreach, Central Queensland, Australia",
            177,
            102,
            "Tori Tallyo Fairous",
            new OperatorAge(5, 8, 36),
            1
        );
        #endregion
        #region Nokk
        Nokk = new Attacker(
            "Nøkk",
            [
                new Weapon(
                    null!,
                    "FMG-9",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    800,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1420,
                    2210
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "JAEGER CORPS",
            "[REDACTED]",
            -1M,
            -1M,
            "[REDACTED]",
            OperatorAge.Redacted,
            2
        );
        #endregion
        #region Amaru
        Amaru = new Attacker(
            "Amaru",
            [
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
                    "SMG-11",
                    Weapon.WeaponType.MachinePistol,
                    Weapon.FiringMode.FullAuto,
                    32,
                    1270,
                    16,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1270,
                    2130
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "APCA",
            "Cojata, Peru",
            189,
            84,
            "Azucena Rocío Quispe",
            new OperatorAge(6, 5, 48),
            2
        );
        #endregion
        #region Kali
        Kali = new Attacker(
            "Kali",
            [
                new Weapon(
                    null!,
                    "CSRX 300",
                    Weapon.WeaponType.SniperRifle,
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
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Support],
            "NIGHTHAVEN",
            "Amreli, India",
            170,
            67,
            "Jaimini Kalimohan Shah",
            new OperatorAge(21, 8, 34),
            2
        );
        #endregion
        #region Iana
        Iana = new Attacker(
            "Iana",
            [
                new Weapon(
                    null!,
                    "ARX200",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    700,
                    20,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1420,
                    2350
                ),
                new Weapon(
                    null!,
                    "G36C",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    38,
                    780,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1320,
                    2340
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            Weapon.Gadget.EmpGrenade | Weapon.Gadget.SmokeGrenade,
            "Gemini Replicator",
            [Specialties.FrontLine, Specialties.Intel],
            "REU",
            "Katwijk, Netherlands",
            157,
            56,
            "Nienke Meijer",
            new OperatorAge(27, 8, 35),
            2
        );
        #endregion
        #region Ace
        Ace = new Attacker(
            "Ace",
            [
                new Weapon(
                    null!,
                    "AK-12",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    40,
                    850,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1430,
                    2260
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.AntiGadget],
            "NIGHTHAVEN",
            "Lærdalsøyri, Norway",
            187,
            75,
            "Håvard Haugland",
            new OperatorAge(15, 3, 33),
            2
        );
        #endregion
        #region Zero
        Zero = new Attacker(
            "Zero",
            [
                new Weapon(
                    null!,
                    "SC3000K",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    45,
                    850,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1520,
                    2470
                ),
                new Weapon(
                    null!,
                    "MP7",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    32,
                    900,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1320,
                    2250
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Intel],
            "ROS",
            "Baltimore, Maryland",
            178,
            77,
            "Samuel Leo Fisher",
            new OperatorAge(8, 8, 63),
            3
        );
        #endregion
        #region Flores
        Flores = new Attacker(
            "Flores",
            [
                new Weapon(
                    null!,
                    "AR33",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    41,
                    749,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1250,
                    2310
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Intel],
            "UNAFFILIATED",
            "Buenos Aires, Argentina",
            181,
            72,
            "Santiago Miguel Lucero",
            new OperatorAge(2, 10, 28),
            2
        );
        #endregion
        #region Osa
        Osa = new Attacker(
            "Osa",
            [
                new Weapon(
                    null!,
                    "556XI",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    690,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1460,
                    2410
                ),
                new Weapon(
                    null!,
                    "PDW9",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    800,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1490,
                    2440
                )
            ],
            [
                new Weapon(
                    null!,
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
            [Specialties.Intel, Specialties.Support],
            "NIGHTHAVEN",
            "Split, Croatia",
            180,
            71,
            "Anja Katarina Janković",
            new OperatorAge(29, 4, 27),
            1
        );
        #endregion
        #region Sens
        Sens = new Attacker(
            "Sens",
            [
                new Weapon(
                    null!,
                    "POF-9",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    35,
                    740,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1470,
                    2240
                ),
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Support, Specialties.MapControl],
            "SFG",
            "Brussels, Belgium",
            178,
            73,
            "Néon Ngoma Mutombo",
            new OperatorAge(3, 3, 30),
            3
        );
        #endregion
        #region Grim
        Grim = new Attacker(
            "Grim",
            [
                new Weapon(
                    null!,
                    "552 Commando",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    43,
                    690,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1390,
                    2170
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.FrontLine, Specialties.MapControl],
            "NIGHTHAVEN",
            "Jurong, Singapore",
            179,
            89.8M,
            "Charlie Tho Keng Boon",
            new OperatorAge(5, 4, 39),
            3
        );
        #endregion
        #region Brava
        Brava = new Attacker(
            "Brava",
            [
                new Weapon(
                    null!,
                    "PARA-308",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    47,
                    650,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    2000,
                    2300
                ),
                new Weapon(
                    null!,
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
                    null!,
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
                    null!,
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
            [Specialties.AntiGadget, Specialties.Intel],
            "COT",
            "Curitiba, Brazil",
            170,
            71M,
            "Nayara Cardoso",
            new OperatorAge(10, 1, 40),
            3
        );
        #endregion
        #region Ram
        Ram = new Attacker(
            "Ram",
            [
                new Weapon(
                    null!,
                    "R4-C",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    39,
                    860,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1330,
                    2200
                ),
                new Weapon(
                    null!,
                    "LMG-E",
                    Weapon.WeaponType.LightMachineGun,
                    Weapon.FiringMode.FullAuto,
                    41,
                    720,
                    150,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    6180,
                    5430
                )
            ],
            [
                new Weapon(
                    null!,
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
                    null!,
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
            [Specialties.Breach, Specialties.AntiGadget],
            "35th Commando Battalion",
            "Busan, South Korea",
            1.78M,
            68M,
            "Bo-Ram Choi",
            new OperatorAge(25, 4, 37),
            1
        );
        #endregion
        #region Deimos
        Deimos = new Attacker(
            "Deimos",
            [
                new Weapon(
                    null!,
                    "AK-74M",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    44,
                    650,
                    40,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1430,
                    2440
                ),
                new Weapon(
                    null!,
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
            ],
            [
                new Weapon(
                    null!,
                    ".44 Vendetta",
                    Weapon.WeaponType.Revolver,
                    Weapon.FiringMode.SingleShot,
                    78,
                    550, // can only guess since they don't disclose the actual RPM values for single-shot weapons
                    6,
                    Weapon.Sight.NoneOther,
                    Weapon.Barrel.None,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    2040,
                    2060
                )
            ],
            Weapon.Gadget.FragGrenade | Weapon.Gadget.HardBreachCharge,
            "DeathMARK Tracker",
            [Specialties.Intel, Specialties.MapControl],
            "Keres Legion",
            "Birmingham, Alabama",
            1.86M,
            94M,
            "Gerald Morris",
            new OperatorAge(24, 12, 51),
            1
        );
        #endregion

        All =
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

        foreach (var op in All.Concat([Striker]))
        {
            foreach (var wep in op.Primaries.Concat(op.Secondaries))
            {
                wep.Source = op;
            }
        }
        #endregion

        // Same as above
        Specialties.Breach.Reward = Hibana;
        Specialties.Support.Reward = Montagne;
        Specialties.FrontLine.Reward = Ash;
        Specialties.Intel.Reward = Twitch;
        Specialties.AntiGadget.Reward = Fuze;
        Specialties.MapControl.Reward = Lion;
    }

    /// <summary>
    /// Gets a <see cref="AttackerSpecialties"/> instance that contains the <see cref="Specialty"/> instances for <see cref="Attacker"/>s.
    /// </summary>
    public static AttackerSpecialties Specialties { get; } = new AttackerSpecialties();

    #region Attacker properties
    /// <summary>
    /// The <see cref="Attacker"/> Recruit <see cref="Striker"/>.
    /// </summary>
    public static Attacker Striker { get; }

    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Sledge"/>.
    /// </summary>
    public static Attacker Sledge { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Thatcher"/>.
    /// </summary>
    public static Attacker Thatcher { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Ash"/>.
    /// </summary>
    public static Attacker Ash { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Thermite"/>.
    /// </summary>
    public static Attacker Thermite { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Twitch"/>.
    /// </summary>
    public static Attacker Twitch { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Montagne"/>.
    /// </summary>
    public static Attacker Montagne { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Glaz"/>.
    /// </summary>
    public static Attacker Glaz { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Fuze"/>.
    /// </summary>
    public static Attacker Fuze { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Blitz"/>.
    /// </summary>
    public static Attacker Blitz { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="IQ"/>.
    /// </summary>
    public static Attacker IQ { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Buck"/>.
    /// </summary>
    public static Attacker Buck { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Blackbeard"/>.
    /// </summary>
    public static Attacker Blackbeard { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Capitao"/>.
    /// </summary>
    public static Attacker Capitao { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Hibana"/>.
    /// </summary>
    public static Attacker Hibana { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Jackal"/>.
    /// </summary>
    public static Attacker Jackal { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Ying"/>.
    /// </summary>
    public static Attacker Ying { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Zofia"/>.
    /// </summary>
    public static Attacker Zofia { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Dokkaebi"/>.
    /// </summary>
    public static Attacker Dokkaebi { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Lion"/>.
    /// </summary>
    public static Attacker Lion { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Finka"/>.
    /// </summary>
    public static Attacker Finka { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Maverick"/>.
    /// </summary>
    public static Attacker Maverick { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Nomad"/>.
    /// </summary>
    public static Attacker Nomad { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Gridlock"/>.
    /// </summary>
    public static Attacker Gridlock { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Nokk"/>.
    /// </summary>
    public static Attacker Nokk { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Amaru"/>.
    /// </summary>
    public static Attacker Amaru { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Kali"/>.
    /// </summary>
    public static Attacker Kali { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Iana"/>.
    /// </summary>
    public static Attacker Iana { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Ace"/>.
    /// </summary>
    public static Attacker Ace { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Zero"/>.
    /// </summary>
    public static Attacker Zero { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Flores"/>.
    /// </summary>
    public static Attacker Flores { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Osa"/>.
    /// </summary>
    public static Attacker Osa { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Sens"/>.
    /// </summary>
    public static Attacker Sens { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Grim"/>.
    /// </summary>
    public static Attacker Grim { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Brava"/>.
    /// </summary>
    public static Attacker Brava { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Ram"/>.
    /// </summary>
    public static Attacker Ram { get; }
    /// <summary>
    /// The <see cref="Attacker"/> <see cref="Deimos"/>.
    /// </summary>
    public static Attacker Deimos { get; }
    #endregion

    /// <summary>
    /// Compiles specific challenges from all <see cref="Attackers"/>' specialties into a collection.
    /// </summary>
    /// <param name="breach">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.Breach" /> <see cref="Specialty" />.</param>
    /// <param name="support">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.Support" /> <see cref="Specialty" />.</param>
    /// <param name="frontline">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.FrontLine" /> <see cref="Specialty" />.</param>
    /// <param name="intel">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.Intel" /> <see cref="Specialty" />.</param>
    /// <param name="antigadget">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.AntiGadget" /> <see cref="Specialty" />.</param>
    /// <param name="mapcontrol">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AttackerSpecialties.MapControl" /> <see cref="Specialty" />.</param>
    /// <returns>An <see cref="ImmutableDictionary{TKey, TValue}"/> that maps <see cref="Specialty"/> instances corresponding to the supplied progress values to their respective next <see cref="Specialty.Challenge"/>s.</returns>
    public static ImmutableDictionary<Specialty, string> GetPersonalSpecialtyChallengeSet(
        int breach,
        int support,
        int frontline,
        int intel,
        int antigadget,
        int mapcontrol
    )
    {
        Dictionary<Specialty, string> challenges = [];

        if (breach is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.Breach,
                $"{Specialties.Breach.Name,-13} -> {Specialties.Breach.Challenges[breach - 1].Description}"
            );
        }
        if (support is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.Support,
                $"{Specialties.Support.Name,-13} -> {Specialties.Support.Challenges[support - 1].Description}"
            );
        }
        if (frontline is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.FrontLine,
                $"{Specialties.FrontLine.Name,-13} -> {Specialties.FrontLine.Challenges[frontline - 1].Description}"
            );
        }
        if (intel is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.Intel,
                $"{Specialties.Intel.Name,-13} -> {Specialties.Intel.Challenges[intel - 1].Description}"
            );
        }
        if (antigadget is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.AntiGadget,
                $"{Specialties.AntiGadget.Name,-13} -> {Specialties.AntiGadget.Challenges[antigadget - 1].Description}"
            );
        }
        if (mapcontrol is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.MapControl,
                $"{Specialties.MapControl.Name,-13} -> {Specialties.MapControl.Challenges[mapcontrol - 1].Description}"
            );
        }

        return challenges.ToImmutableDictionary();
    }
}
