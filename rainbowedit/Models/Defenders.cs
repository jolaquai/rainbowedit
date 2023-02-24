namespace RainbowEdit;

/// <summary>
/// The <see cref="Defenders"/> in Siege.
/// </summary>
public partial class Defenders : IEnumerable<Operator>, IEnumerator<Operator>
{
    static Defenders()
    {
        _operators = new()
        {
            Smoke,
            Mute,
            Castle,
            Pulse,
            Doc,
            Rook,
            Kapkan,
            Tachanka,
            Jäger,
            Bandit,
            Frost,
            Valkyrie,
            Caveira,
            Echo,
            Mira,
            Lesion,
            Ela,
            Vigil,
            Maestro,
            Alibi,
            Clash,
            Kaid,
            Mozzie,
            Warden,
            Goyo,
            Wamai,
            Oryx,
            Melusi,
            Aruni,
            Thunderbird,
            Thorn,
            Azami,
            Solis
        };

        // Needed because even though every Weapon object is instantiated using a reference to the containing Operator instance, at the time of instantiation, those Operator references are null
        foreach (Operator op in _operators)
        {
            foreach (Weapon wep in op.Primaries.Concat(op.Secondaries))
            {
                wep.Source = op;
            }
        }
    }

#pragma warning disable CS8604 // Possible null reference argument.

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Smoke"/>.
    /// </summary>
    public static readonly Operator Smoke = new(
        "Smoke",
        new List<Weapon>()
        {
            new(
                Smoke,
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
                Smoke,
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
                Smoke,
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
            ),
            new(
                Smoke,
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
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.DeployableShield,
        "Compound Z8 Grenades",
        "SAS",
        "London, England (King's Cross)",
        173,
        70,
        "James Porter",
        new(14, 5, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mute"/>.
    /// </summary>
    public static readonly Operator Mute = new(
        "Mute",
        new List<Weapon>()
        {
            new(
                Mute,
                "MP5K",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1280,
                2150
            ),
            new(
                Mute,
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
                Mute,
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
            ),
            new(
                Mute,
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
            )
        },
        Weapon.Gadget.NitroCell | Weapon.Gadget.BulletproofCamera,
        "\"Moni\" GC90 Signal Disruptor",
        "SAS",
        "York, England",
        185,
        80,
        "Mark R. Chandar",
        new(11, 10, 25),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Castle"/>.
    /// </summary>
    public static readonly Operator Castle = new(
        "Castle",
        new List<Weapon>()
        {
            new(
                Castle,
                "UMP45",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                38,
                600,
                25,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1480,
                2190
            ),
            new(
                Castle,
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
                Castle,
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
                Castle,
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
                Castle,
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
            )
        },
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ProximityAlarm,
        "UTP1-Universal Tactical Panel",
        "FBI SWAT",
        "Sherman Oaks, California",
        185,
        86,
        "Miles Campbell",
        new(20, 9, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Pulse"/>.
    /// </summary>
    public static readonly Operator Pulse = new(
        "Pulse",
        new List<Weapon>()
        {
            new(
                Pulse,
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
                Pulse,
                "UMP45",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                38,
                600,
                25,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1480,
                2190
            )
        },
        new List<Weapon>()
        {
            new(
                Pulse,
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
                Pulse,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.NitroCell,
        "HB-5 Cardiac Sensor",
        "FBI SWAT",
        "Goldsboro, North Carolina",
        188,
        85,
        "Jack Estrada",
        new(11, 10, 32),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Doc"/>.
    /// </summary>
    public static readonly Operator Doc = new(
        "Doc",
        new List<Weapon>()
        {
            new(
                Doc,
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
            ),
            new(
                Doc,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new(
                Doc,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1560,
                2190
            )
        },
        new List<Weapon>()
        {
            new(
                Doc,
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
                Doc,
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
                Doc,
                "Bailiff 410",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3260,
                3370
            )
        },
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.BarbedWire,
        "MPD-0 STIM PISTOL",
        "GIGN",
        "Paris, France",
        177,
        74,
        "Gustave Kateb",
        new(16, 9, 39),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Rook"/>.
    /// </summary>
    public static readonly Operator Rook = new(
        "Rook",
        new List<Weapon>()
        {
            new(
                Rook,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1560,
                2190
            ),
            new(
                Rook,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new(
                Rook,
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
                Rook,
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
                Rook,
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
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.ImpactGrenade,
        "R1N \"Rhino\" Armor - Armor Pack",
        "GIGN",
        "Tours, France",
        175,
        72,
        "Julien Nizan",
        new(6, 1, 27),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kapkan"/>.
    /// </summary>
    public static readonly Operator Kapkan = new(
        "Kapkan",
        new List<Weapon>()
        {
            new(
                Kapkan,
                "9x19VSN",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                750,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2220
            ),
            new(
                Kapkan,
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
                Kapkan,
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
                Kapkan,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.NitroCell,
        "EDD Mk II Tripwires",
        "SPETSNAZ",
        "Kovrov, Russia",
        180,
        80,
        "Maxim Basuda",
        new(14, 5, 38),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Tachanka"/>.
    /// </summary>
    public static readonly Operator Tachanka = new(
        "Tachanka",
        new List<Weapon>()
        {
            new(
                Tachanka,
                "DP27",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                49,
                550,
                70,
                Weapon.Sight.Other | Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                false,
                2490,
                3340
            ),
            new(
                Tachanka,
                "9x19VSN",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                750,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2220
            )
        },
        new List<Weapon>()
        {
            new(
                Tachanka,
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
            ),
            new(
                Tachanka,
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
                Tachanka,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.DeployableShield,
        "Shumikha Grenade Launcher",
        "SPETSNAZ",
        "Saint Petersburg, Russia",
        183,
        86,
        "Alexsandr Sanaviev",
        new(3, 11, 48),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Jäger"/>.
    /// </summary>
    public static readonly Operator Jäger = new(
        "Jäger",
        new List<Weapon>()
        {
            new(
                Jäger,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3410,
                4360
            ),
            new(
                Jäger,
                "416-C Carbine",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                38,
                740,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1340,
                2180
            )
        },
        new List<Weapon>()
        {
            new(
                Jäger,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.BarbedWire,
        "ADS-Mk IV \"Magpie\" Automated Defense System",
        "GSG 9",
        "Düsseldorf, Germany",
        180,
        64,
        "Marius Streicher",
        new(9, 3, 39),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Bandit"/>.
    /// </summary>
    public static readonly Operator Bandit = new(
        "Bandit",
        new List<Weapon>()
        {
            new(
                Bandit,
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1320,
                2250
            ),
            new(
                Bandit,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3410,
                4360
            )
        },
        new List<Weapon>()
        {
            new(
                Bandit,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.NitroCell,
        "CED-1 Crude Electrical Device \"Shock Wires\"",
        "GSG 9",
        "Berlin, Germany",
        180,
        68,
        "Dominic Brunsmeier",
        new(13, 8, 42),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Frost"/>.
    /// </summary>
    public static readonly Operator Frost = new(
        "Frost",
        new List<Weapon>()
        {
            new(
                Frost,
                "Super 90",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4320,
                5180
            ),
            new(
                Frost,
                "9mm C1",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                575,
                34,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1290,
                2070
            )
        },
        new List<Weapon>()
        {
            new(
                Frost,
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
                Frost,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.DeployableShield,
        "Sterling Mk2 LHT leg-hold trap (Welcome Mat)",
        "JTF2",
        "Vancouver, British Columbia",
        172,
        63,
        "Tina Lin Tsang",
        new(4, 5, 32),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Valkyrie"/>.
    /// </summary>
    public static readonly Operator Valkyrie = new(
        "Valkyrie",
        new List<Weapon>()
        {
            new(
                Valkyrie,
                "MPX",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                830,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1310,
                2040
            ),
            new(
                Valkyrie,
                "SPAS-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3470,
                4430
            )
        },
        new List<Weapon>()
        {
            new(
                Valkyrie,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.NitroCell,
        "Gyro Cam Mk2 \"Black Eye\"",
        "NAVY SEAL",
        "Oceanside, California",
        170,
        61,
        "Meghan J. Castellano",
        new(21, 7, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Caveira"/>.
    /// </summary>
    public static readonly Operator Caveira = new(
        "Caveira",
        new List<Weapon>()
        {
            new(
                Caveira,
                "M12",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                40,
                550,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1290,
                2170
            ),
            new(
                Caveira,
                "SPAS-15",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                290,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1180,
                2020
            )
        },
        new List<Weapon>()
        {
            new(
                Caveira,
                "Luison",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                65,
                450,
                12,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1320,
                1590
            )
        },
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ProximityAlarm,
        "Silent Step",
        "BOPE",
        "Rinópolis, Brazil",
        177,
        72,
        "Taina Pereira",
        new(15, 10, 27),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Echo"/>.
    /// </summary>
    public static readonly Operator Echo = new(
        "Echo",
        new List<Weapon>()
        {
            new(
                Echo,
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
            ),
            new(
                Echo,
                "MP5SD",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2260
            )
        },
        new List<Weapon>()
        {
            new(
                Echo,
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
                Echo,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1300,
                2210
            )
        },
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.DeployableShield,
        "Yokai Hovering Drone",
        "SAT",
        "Suginami, Tokyo, Japan",
        180,
        72,
        "Masaru Enatsu",
        new(31, 10, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mira"/>.
    /// </summary>
    public static readonly Operator Mira = new(
        "Mira",
        new List<Weapon>()
        {
            new(
                Mira,
                "Vector .45 ACP",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                23,
                1200,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2170
            ),
            new(
                Mira,
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
                Mira,
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
                Mira,
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
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.NitroCell,
        "Black Mirror",
        "GEO",
        "Madrid, Spain",
        165,
        60,
        "Elena María Álvarez",
        new(18, 11, 39),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Lesion"/>.
    /// </summary>
    public static readonly Operator Lesion = new(
        "Lesion",
        new List<Weapon>()
        {
            new(
                Lesion,
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
            ),
            new(
                Lesion,
                "T-5 SMG",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                28,
                900,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1400,
                2180
            )
        },
        new List<Weapon>()
        {
            new(
                Lesion,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BulletproofCamera,
        "Gu Mines",
        "SDU",
        "Hong Kong, Junk Bay (Tseung Kwan O)",
        174,
        82,
        "Liu Tze Long",
        new(2, 7, 44),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ela"/>.
    /// </summary>
    public static readonly Operator Ela = new(
        "Ela",
        new List<Weapon>()
        {
            new(
                Ela,
                "Scorpion Evo 3 A1",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                23,
                1080,
                40,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1250,
                2220
            ),
            new(
                Ela,
                "FO-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                25,
                400,
                10,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1440,
                2360
            )
        },
        new List<Weapon>()
        {
            new(
                Ela,
                "RG15",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                38,
                550,
                15,
                Weapon.Sight.NonMagnifying | Weapon.Sight.Other,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1200,
                1370
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.DeployableShield,
        "GRZMOT Mine",
        "GROM",
        "Wrocław, Poland",
        173,
        68,
        "Elżbieta Bosak",
        new(8, 11, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Vigil"/>.
    /// </summary>
    public static readonly Operator Vigil = new(
        "Vigil",
        new List<Weapon>()
        {
            new(
                Vigil,
                "K1A",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                720,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1470,
                2280
            ),
            new(
                Vigil,
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
                Vigil,
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
                Vigil,
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
            )
        },
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ImpactGrenade,
        "ERC-7 Electronic Rendering Cloak",
        "707TH SMB",
        "[REDACTED]",
        173,
        73,
        "Chul Kyung Hwa",
        new(17, 1, 34),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Maestro"/>.
    /// </summary>
    public static readonly Operator Maestro = new(
        "Maestro",
        new List<Weapon>()
        {
            new(
                Maestro,
                "ALDA 5.56",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                35,
                900,
                80,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip,
                true,
                5200,
                4480
            ),
            new(
                Maestro,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Maestro,
                "Bailiff 410",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3260,
                3370
            ),
            new(
                Maestro,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                3020,
                3020
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ImpactGrenade,
        "Compact Laser Emplacement Mk V \"Evil Eye\"",
        "GIS",
        "Rome, Italy",
        185,
        87,
        "Adriano Martello",
        new(13, 4, 45),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Alibi"/>.
    /// </summary>
    public static readonly Operator Alibi = new(
        "Alibi",
        new List<Weapon>()
        {
            new(
                Alibi,
                "Mx4 Storm",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                950,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip,
                true,
                1570,
                2200
            ),
            new(
                Alibi,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.Two,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Alibi,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                3020,
                3020
            ),
            new(
                Alibi,
                "Bailiff 410",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3260,
                3370
            )
        },
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.DeployableShield,
        "Prisma",
        "GIS",
        "Tripoli, Libya",
        171,
        63,
        "Aria de Luca",
        new(15, 12, 37),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Clash"/>.
    /// </summary>
    public static readonly Operator Clash = new(
        "Clash",
        new List<Weapon>()
        {
            new(
                Clash,
                "CCE Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                5,
                20,
                4,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                0,
                0
            )
        },
        new List<Weapon>()
        {
            new(
                Clash,
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
                Clash,
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
                Clash,
                "P-10C",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                40,
                450,
                15,
                Weapon.Sight.Other,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1240,
                1380
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ImpactGrenade,
        "Crowd Control Electric Shield",
        "GSUTR",
        "London, England",
        179,
        73,
        "Morowa Evans",
        new(7, 6, 35),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kaid"/>.
    /// </summary>
    public static readonly Operator Kaid = new(
        "Kaid",
        new List<Weapon>()
        {
            new(
                Kaid,
                "AUG A3",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                700,
                31,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1480,
                2310
            ),
            new(
                Kaid,
                "TCSG12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                63,
                450,
                10,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1410,
                2290
            )
        },
        new List<Weapon>()
        {
            new(
                Kaid,
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
                Kaid,
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
        Weapon.Gadget.NitroCell | Weapon.Gadget.BarbedWire,
        "Rtila Electroclaw",
        "GIGR",
        "Aroumd, Morocco",
        195,
        98,
        "Jalal El Fassi",
        new(26, 6, 58),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mozzie"/>.
    /// </summary>
    public static readonly Operator Mozzie = new(
        "Mozzie",
        new List<Weapon>()
        {
            new(
                Mozzie,
                "Commando 9",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                36,
                780,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1200,
                1540
            ),
            new(
                Mozzie,
                "P10 RONI",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                980,
                15,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1120,
                2200
            )
        },
        new List<Weapon>()
        {
            new(
                Mozzie,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.NitroCell,
        "Pest Launcher",
        "SASR",
        "Portland, Australia",
        162,
        57,
        "Max Goose",
        new(15, 2, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Warden"/>.
    /// </summary>
    public static readonly Operator Warden = new(
        "Warden",
        new List<Weapon>()
        {
            new(
                Warden,
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
                Warden,
                "MPX",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                830,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1310,
                2040
            )
        },
        new List<Weapon>()
        {
            new(
                Warden,
                "P-10C",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                40,
                450,
                15,
                Weapon.Sight.Other,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                1240,
                1380
            ),
            new(
                Warden,
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
            )
        },
        Weapon.Gadget.DeployableShield | Weapon.Gadget.NitroCell,
        "Glance Smart Glasses",
        "SECRET SERVICE",
        "Louisville, Kentucky",
        183,
        80,
        "Collinn McKinley",
        new(18, 3, 48),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Goyo"/>.
    /// </summary>
    public static readonly Operator Goyo = new(
        "Goyo",
        new List<Weapon>()
        {
            new(
                Goyo,
                "Vector .45 ACP",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                23,
                1200,
                25,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2170
            ),
            new(
                Goyo,
                "TCSG12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                63,
                450,
                10,
                Weapon.Sight.Two,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1410,
                2290
            )
        },
        new List<Weapon>()
        {
            new(
                Goyo,
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
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.NitroCell,
        "Volcán Canister",
        "FUERZAS ESPECIALES",
        "Culiacán Rosales, Mexico",
        171,
        83,
        "César Ruiz Hernández",
        new(20, 6, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Wamai"/>.
    /// </summary>
    public static readonly Operator Wamai = new(
        "Wamai",
        new List<Weapon>()
        {
            new(
                Wamai,
                "AUG A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                720,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.None,
                true,
                1470,
                2340
            ),
            new(
                Wamai,
                "MP5K",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1280,
                2150
            )
        },
        new List<Weapon>()
        {
            new(
                Wamai,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.None,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.None,
                true,
                3020,
                3020
            ),
            new(
                Wamai,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ProximityAlarm,
        "Magnetic Neutralizing Electronic Targeting (Mag-NET) System",
        "NIGHTHAVEN",
        "Lamu, Kenya",
        187,
        83,
        "Ngũgĩ Muchoki Furaha",
        new(1, 6, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Oryx"/>.
    /// </summary>
    public static readonly Operator Oryx = new(
        "Oryx",
        new List<Weapon>()
        {
            new(
                Oryx,
                "T-5 SMG",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                28,
                900,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1400,
                2180
            ),
            new(
                Oryx,
                "SPAS-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3470,
                4430
            )
        },
        new List<Weapon>()
        {
            new(
                Oryx,
                "Bailiff 410",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.None,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3260,
                3370
            ),
            new(
                Oryx,
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
            )
        },
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ProximityAlarm,
        "Remah Dash",
        "[UNAFFILIATED]",
        "Azraq, Jordan",
        195,
        130,
        "Saif Al Hadid",
        new(3, 7, 45),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Melusi"/>.
    /// </summary>
    public static readonly Operator Melusi = new(
        "Melusi",
        new List<Weapon>()
        {
            new(
                Melusi,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new(
                Melusi,
                "Super 90",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                4320,
                5180
            )
        },
        new List<Weapon>()
        {
            new(
                Melusi,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ImpactGrenade,
        "Banshee Sonic Defense",
        "INKABA TASK FORCE",
        "Louwsburg, South Africa",
        172,
        68,
        "Thandiwe Ndlovu",
        new(16, 6, 32),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Aruni"/>.
    /// </summary>
    public static readonly Operator Aruni = new(
        "Aruni",
        new List<Weapon>()
        {
            new(
                Aruni,
                "P10 RONI",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                980,
                15,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1120,
                2200
            ),
            new(
                Aruni,
                "Mk 14 EBR",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                60,
                450,
                20,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Aruni,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.BulletproofCamera,
        "Surya Gate",
        "NIGHTHAVEN",
        "Ta Phraya District, Thailand",
        160,
        58,
        "Apha Tawanroong",
        new(9, 8, 42),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thunderbird"/>.
    /// </summary>
    public static readonly Operator Thunderbird = new(
        "Thunderbird",
        new List<Weapon>()
        {
            new(
                Thunderbird,
                "Spear .308",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                700,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1510,
                2460
            ),
            new(
                Thunderbird,
                "SPAS-15",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                290,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                1180,
                2020
            )
        },
        new List<Weapon>()
        {
            new(
                Thunderbird,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1300,
                2210
            ),
            new(
                Thunderbird,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.NitroCell,
        "Kóna Healing Station",
        "STAR-NET AVIATION",
        "Nakoda Territories",
        172,
        70,
        "Mina Sky",
        new(1, 4, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thorn"/>.
    /// </summary>
    public static readonly Operator Thorn = new(
        "Thorn",
        new List<Weapon>()
        {
            new(
                Thorn,
                "UZK50GI",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                700,
                22,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1370,
                2300
            ),
            new(
                Thorn,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.None,
                true,
                3410,
                4360
            )
        },
        new List<Weapon>()
        {
            new(
                Thorn,
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
            ),
            new(
                Thorn,
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
        Weapon.Gadget.DeployableShield | Weapon.Gadget.BarbedWire,
        "Razorbloom Shell",
        "EMERGENCY RESPONSE UNIT",
        "County Kildare, Ireland",
        188,
        78,
        "Brianna Skehan",
        new(18, 6, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Azami"/>.
    /// </summary>
    public static readonly Operator Azami = new(
        "Azami",
        new List<Weapon>()
        {
            new(
                Azami,
                "9x19VSN",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                750,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2220
            ),
            new(
                Azami,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.OnePointFive,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        },
        new List<Weapon>()
        {
            new(
                Azami,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BarbedWire,
        "Kiba Barrier",
        "UNAFFILIATED",
        "Kyoto, Japan",
        164,
        56.7M,
        "Kana Fujiwara",
        new(6, 9, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Solis"/>.
    /// </summary>
    public static readonly Operator Solis = new(
        "Solis",
        new List<Weapon>()
        {
            new(
                Solis,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.None,
                true,
                1560,
                2190
            ),
            new(
                Solis,
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
                Solis,
                "SMG-11",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1270,
                16,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1270,
                2130
            )
        },
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BulletproofCamera,
        "SPEC-IO Electro-Sensor",
        "AFEAU",
        "Zipaquirá, Colombia",
        166,
        65M,
        "Ana Valentina Díaz",
        new(18, 9, 37),
        2
    );

#pragma warning restore CS8604 // Possible null reference argument.
}
