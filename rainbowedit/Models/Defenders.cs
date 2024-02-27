using rainbowedit.Models;

namespace rainbowedit;

/// <summary>
/// The <see cref="Defenders"/> in Siege.
/// </summary>
public sealed partial class Defenders : IEnumerable<Operator>
{
    static Defenders()
    {
        _operators =
        [
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
            Solis,
            Tubarao
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
        Specialties.Trapper.Reward = Ela;
        Specialties.Support.Reward = Rook;
        Specialties.AntiEntry.Reward = Castle;
        Specialties.Intel.Reward = Valkyrie;
        Specialties.AntiGadget.Reward = Jäger;
        Specialties.CrowdControl.Reward = Tachanka;
    }

#pragma warning disable CS8604 // Possible null reference argument.

    #region Specialties
    /// <summary>
    /// Contains <see cref="Specialty"/> definitions for <see cref="Defenders"/>.
    /// </summary>
    public static class Specialties
    {
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="Trapper"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Trapper { get; } = new Specialty(
            "Trapper",
            Ela,
            [
                new Specialty.Challenge("Deploy 5 trap devices.", "1-Day Renown Booster 1x"),
                new Specialty.Challenge("Affect 1 opponents with trap devices.", "Beginner Pack 2x"),
                new Specialty.Challenge("Win by counter-defusing the bomb 1 times.", "1-Day Battle Point Booster 3x")
            ]
        );
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="Support"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Support { get; } = new Specialty(
            "Support",
            Rook,
            [
                new Specialty.Challenge("Play 1 times as a Support Defender.", "1-Day Renown Booster 1x"),
                new Specialty.Challenge("Reach the Action Phase as a Defender 2 times without either bomb site being discovered.", "3-Days Renown Booster 1x"),
                new Specialty.Challenge("Heal 2 teammates.", "7-Days Renown Booster")
            ]
        );
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="AntiEntry"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty AntiEntry { get; } = new Specialty(
            "Anti-Entry",
            Castle,
            [
                new Specialty.Challenge("Barricade 5 doors or windows.", "Renown 250"),
                new Specialty.Challenge("Reinforce 5 surfaces.", "Renown 500"),
                new Specialty.Challenge("Deploy 5 anti-entry devices that electrify utility or interfere wih electronics.", "Renown 750")
            ]
        );
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="Intel"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty Intel { get; } = new Specialty(
            "Intel",
            Valkyrie,
            [
                new Specialty.Challenge("Scan and identify 7 Attackers as a Defender.", "Beginner Pack 1x"),
                new Specialty.Challenge("Deploy 5 Observation Tools as a Defender.", "Renown 500"),
                new Specialty.Challenge("Detect 1 opponents with Proximity Alarms that you deployed.", "7-Days Renown Booster 1x")
            ]
        );
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="AntiGadget"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty AntiGadget { get; } = new Specialty(
            "Anti-Gadget",
            Jäger,
            [
                new Specialty.Challenge("Destroy 2 Attacker drones as a Defender.", "Renown 250"),
                new Specialty.Challenge("Destroy 5 Attacker devices as a Defender.", "1-Day Battle Point Booster 2x"),
                new Specialty.Challenge("Deactivate or hack 1 Attacker drones.", "Beginner Pack 3x")
            ]
        );
        /// <summary>
        /// The <see cref="Defenders"/>' <see cref="CrowdControl"/> <see cref="Specialty"/>.
        /// </summary>
        public static Specialty CrowdControl { get; } = new Specialty(
            "Crowd Control",
            Tachanka,
            [
                new Specialty.Challenge("Deploy 5 Barbed Wire.", "1-Day Battle Point Booster 1x"),
                new Specialty.Challenge("Deactivate 2 electronic devices using the Bulletproof Camera EMP.", "3-Days Renown Booster 1x"),
                new Specialty.Challenge("Disorient 2 opponents.", "Renown 750")
            ]
        );

        /// <summary>
        /// A collection of all <see cref="Specialty"/> instances that apply to <see cref="Defenders"/>.
        /// </summary>
        public static IEnumerable<Specialty> All { get; } =
        [
            Trapper,
            Support,
            AntiEntry,
            Intel,
            AntiGadget,
            CrowdControl
        ];
    }
    #endregion

    #region Defender instances
    /// <summary>
    /// The <see cref="Operator"/> <see cref="Smoke"/>.
    /// </summary>
    public static Operator Smoke { get; } = new Operator(
        "Smoke",
        [
            new Weapon(
                Smoke,
                "FMG-9",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1420,
                2210
            ),
            new Weapon(
                Smoke,
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
                Smoke,
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
            ),
            new Weapon(
                Smoke,
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
            )
        ],
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ProximityAlarm,
        "Compound Z8 Grenades",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "SAS",
        "London, England (King's Cross)",
        173,
        70,
        "James Porter",
        new OperatorAge(14, 5, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mute"/>.
    /// </summary>
    public static Operator Mute { get; } = new Operator(
        "Mute",
        [
            new Weapon(
                Mute,
                "MP5K",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1280,
                2150
            ),
            new Weapon(
                Mute,
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
                Mute,
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
            ),
            new Weapon(
                Mute,
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
            )
        ],
        Weapon.Gadget.NitroCell | Weapon.Gadget.BulletproofCamera,
        "\"Moni\" GC90 Signal Disruptor",
        [
            Specialties.AntiGadget,
            Specialties.CrowdControl
        ],
        "SAS",
        "York, England",
        185,
        80,
        "Mark R. Chandar",
        new OperatorAge(11, 10, 25),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Castle"/>.
    /// </summary>
    public static Operator Castle { get; } = new Operator(
        "Castle",
        [
            new Weapon(
                Castle,
                "UMP45",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                38,
                600,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1480,
                2190
            ),
            new Weapon(
                Castle,
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
                Castle,
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
                Castle,
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
                Castle,
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
            )
        ],
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ProximityAlarm,
        "UTP1-Universal Tactical Panel",
        [
            Specialties.AntiEntry,
            Specialties.Support
        ],
        "FBI SWAT",
        "Sherman Oaks, California",
        185,
        86,
        "Miles Campbell",
        new OperatorAge(20, 9, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Pulse"/>.
    /// </summary>
    public static Operator Pulse { get; } = new Operator(
        "Pulse",
        [
            new Weapon(
                Pulse,
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
                Pulse,
                "UMP45",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                38,
                600,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1480,
                2190
            )
        ],
        [
            new Weapon(
                Pulse,
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
                Pulse,
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
        Weapon.Gadget.NitroCell | Weapon.Gadget.DeployableShield | Weapon.Gadget.ObservationBlocker,
        "HB-5 Cardiac Sensor",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "FBI SWAT",
        "Goldsboro, North Carolina",
        188,
        85,
        "Jack Estrada",
        new OperatorAge(11, 10, 32),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Doc"/>.
    /// </summary>
    public static Operator Doc { get; } = new Operator(
        "Doc",
        [
            new Weapon(
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
            new Weapon(
                Doc,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new Weapon(
                Doc,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1560,
                2190
            )
        ],
        [
            new Weapon(
                Doc,
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
                Doc,
                "LFP586",
                Weapon.WeaponType.Handgun,
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
                Doc,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            )
        ],
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.BarbedWire,
        "MPD-0 STIM PISTOL",
        [
            Specialties.Support
        ],
        "GIGN",
        "Paris, France",
        177,
        74,
        "Gustave Kateb",
        new OperatorAge(16, 9, 39),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Rook"/>.
    /// </summary>
    public static Operator Rook { get; } = new Operator(
        "Rook",
        [
            new Weapon(
                Rook,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1560,
                2190
            ),
            new Weapon(
                Rook,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new Weapon(
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
        ],
        [
            new Weapon(
                Rook,
                "LFP586",
                Weapon.WeaponType.Handgun,
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
                Rook,
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
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ObservationBlocker,
        "R1N \"Rhino\" Armor - Armor Pack",
        [
            Specialties.Support
        ],
        "GIGN",
        "Tours, France",
        175,
        72,
        "Julien Nizan",
        new OperatorAge(6, 1, 27),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kapkan"/>.
    /// </summary>
    public static Operator Kapkan { get; } = new Operator(
        "Kapkan",
        [
            new Weapon(
                Kapkan,
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
            new Weapon(
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
        ],
        [
            new Weapon(
                Kapkan,
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
                Kapkan,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.NitroCell,
        "EDD Mk II Tripwires",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "SPETSNAZ",
        "Kovrov, Russia",
        180,
        80,
        "Maxim Basuda",
        new OperatorAge(14, 5, 38),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Tachanka"/>.
    /// </summary>
    public static Operator Tachanka { get; } = new Operator(
        "Tachanka",
        [
            new Weapon(
                Tachanka,
                "DP27",
                Weapon.WeaponType.LightMachineGun,
                Weapon.FiringMode.FullAuto,
                60,
                550,
                70,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                false,
                2490,
                3340
            ),
            new Weapon(
                Tachanka,
                "9x19VSN",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                34,
                750,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1430,
                2220
            )
        ],
        [
            new Weapon(
                Tachanka,
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
            ),
            new Weapon(
                Tachanka,
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
                Tachanka,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2210
            )
        ],
        Weapon.Gadget.BarbedWire | Weapon.Gadget.DeployableShield | Weapon.Gadget.ProximityAlarm,
        "Shumikha Grenade Launcher",
        [
            Specialties.AntiEntry,
            Specialties.CrowdControl
        ],
        "SPETSNAZ",
        "Saint Petersburg, Russia",
        183,
        86,
        "Alexsandr Sanaviev",
        new OperatorAge(3, 11, 48),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Jäger"/>.
    /// </summary>
    public static Operator Jäger { get; } = new Operator(
        "Jäger",
        [
            new Weapon(
                Jäger,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3410,
                4360
            ),
            new Weapon(
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
        ],
        [
            new Weapon(
                Jäger,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ObservationBlocker,
        "ADS-Mk IV \"Magpie\" Automated Defense System",
        [
            Specialties.AntiGadget,
            Specialties.Support
        ],
        "GSG 9",
        "Düsseldorf, Germany",
        180,
        64,
        "Marius Streicher",
        new OperatorAge(9, 3, 39),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Bandit"/>.
    /// </summary>
    public static Operator Bandit { get; } = new Operator(
        "Bandit",
        [
            new Weapon(
                Bandit,
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2250
            ),
            new Weapon(
                Bandit,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3410,
                4360
            )
        ],
        [
            new Weapon(
                Bandit,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.NitroCell,
        "CED-1 Crude Electrical Device \"Shock Wires\"",
        [
            Specialties.AntiEntry,
            Specialties.AntiGadget
        ],
        "GSG 9",
        "Berlin, Germany",
        180,
        68,
        "Dominic Brunsmeier",
        new OperatorAge(13, 8, 42),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Frost"/>.
    /// </summary>
    public static Operator Frost { get; } = new Operator(
        "Frost",
        [
            new Weapon(
                Frost,
                "Super 90",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4320,
                5180
            ),
            new Weapon(
                Frost,
                "9mm C1",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                575,
                34,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1290,
                2070
            )
        ],
        [
            new Weapon(
                Frost,
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
                Frost,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.DeployableShield,
        "Sterling Mk2 LHT leg-hold trap (Welcome Mat)",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "JTF2",
        "Vancouver, British Columbia",
        172,
        63,
        "Tina Lin Tsang",
        new OperatorAge(4, 5, 32),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Valkyrie"/>.
    /// </summary>
    public static Operator Valkyrie { get; } = new Operator(
        "Valkyrie",
        [
            new Weapon(
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
            new Weapon(
                Valkyrie,
                "SPAS-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3470,
                4430
            )
        ],
        [
            new Weapon(
                Valkyrie,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.NitroCell,
        "Gyro Cam Mk2 \"Black Eye\"",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "NAVY SEAL",
        "Oceanside, California",
        170,
        61,
        "Meghan J. Castellano",
        new OperatorAge(21, 7, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Caveira"/>.
    /// </summary>
    public static Operator Caveira { get; } = new Operator(
        "Caveira",
        [
            new Weapon(
                Caveira,
                "M12",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                40,
                550,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1290,
                2170
            ),
            new Weapon(
                Caveira,
                "SPAS-15",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                290,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1180,
                2020
            )
        ],
        [
            new Weapon(
                Caveira,
                "Luison",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                65,
                450,
                12,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                1590
            )
        ],
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ProximityAlarm | Weapon.Gadget.ObservationBlocker,
        "Silent Step",
        [
            Specialties.Intel,
            Specialties.CrowdControl
        ],
        "BOPE",
        "Rinópolis, Brazil",
        177,
        72,
        "Taina Pereira",
        new OperatorAge(15, 10, 27),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Echo"/>.
    /// </summary>
    public static Operator Echo { get; } = new Operator(
        "Echo",
        [
            new Weapon(
                Echo,
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
            ),
            new Weapon(
                Echo,
                "MP5SD",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1320,
                2260
            )
        ],
        [
            new Weapon(
                Echo,
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
                Echo,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2210
            )
        ],
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.DeployableShield,
        "Yokai Hovering Drone",
        [
            Specialties.Intel,
            Specialties.CrowdControl
        ],
        "SAT",
        "Suginami, Tokyo, Japan",
        180,
        72,
        "Masaru Enatsu",
        new OperatorAge(31, 10, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mira"/>.
    /// </summary>
    public static Operator Mira { get; } = new Operator(
        "Mira",
        [
            new Weapon(
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
            new Weapon(
                Mira,
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
                Mira,
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
                Mira,
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
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.NitroCell,
        "Black Mirror",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "GEO",
        "Madrid, Spain",
        165,
        60,
        "Elena María Álvarez",
        new OperatorAge(18, 11, 39),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Lesion"/>.
    /// </summary>
    public static Operator Lesion { get; } = new Operator(
        "Lesion",
        [
            new Weapon(
                Lesion,
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
            ),
            new Weapon(
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
        ],
        [
            new Weapon(
                Lesion,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BulletproofCamera,
        "Gu Mines",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "SDU",
        "Hong Kong, Junk Bay (Tseung Kwan O)",
        174,
        82,
        "Liu Tze Long",
        new OperatorAge(2, 7, 44),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Ela"/>.
    /// </summary>
    public static Operator Ela { get; } = new Operator(
        "Ela",
        [
            new Weapon(
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
            new Weapon(
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
        ],
        [
            new Weapon(
                Ela,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.DeployableShield | Weapon.Gadget.ObservationBlocker,
        "GRZMOT Mine",
        [
            Specialties.CrowdControl,
            Specialties.Trapper
        ],
        "GROM",
        "Wrocław, Poland",
        173,
        68,
        "Elżbieta Bosak",
        new OperatorAge(8, 11, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Vigil"/>.
    /// </summary>
    public static Operator Vigil { get; } = new Operator(
        "Vigil",
        [
            new Weapon(
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
            new Weapon(
                Vigil,
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
                Vigil,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2220
            ),
            new Weapon(
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
        ],
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ImpactGrenade,
        "ERC-7 Electronic Rendering Cloak",
        [
            Specialties.AntiGadget,
            Specialties.CrowdControl
        ],
        "707TH SMB",
        "[REDACTED]",
        173,
        73,
        "Chul Kyung Hwa",
        new OperatorAge(17, 1, 34),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Maestro"/>.
    /// </summary>
    public static Operator Maestro { get; } = new Operator(
        "Maestro",
        [
            new Weapon(
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
            new Weapon(
                Maestro,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        ],
        [
            new Weapon(
                Maestro,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            ),
            new Weapon(
                Maestro,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                3020,
                3020
            )
        ],
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ObservationBlocker,
        "Compact Laser Emplacement Mk V \"Evil Eye\"",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "GIS",
        "Rome, Italy",
        185,
        87,
        "Adriano Martello",
        new OperatorAge(13, 4, 45),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Alibi"/>.
    /// </summary>
    public static Operator Alibi { get; } = new Operator(
        "Alibi",
        [
            new Weapon(
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
            new Weapon(
                Alibi,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        ],
        [
            new Weapon(
                Alibi,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                3020,
                3020
            ),
            new Weapon(
                Alibi,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            )
        ],
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.ObservationBlocker,
        "Prisma",
        [
            Specialties.Intel,
            Specialties.Trapper
        ],
        "GIS",
        "Tripoli, Libya",
        171,
        63,
        "Aria de Luca",
        new OperatorAge(15, 12, 37),
        3
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Clash"/>.
    /// </summary>
    public static Operator Clash { get; } = new Operator(
        "Clash",
        [
            new Weapon(
                Clash,
                "CCE Shield",
                Weapon.WeaponType.Shield,
                Weapon.FiringMode.None,
                5,
                20,
                4,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                0,
                0
            )
        ],
        [
            new Weapon(
                Clash,
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
                Clash,
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
                Clash,
                "P-10C",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                40,
                450,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1240,
                1380
            )
        ],
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ImpactGrenade | Weapon.Gadget.DeployableShield,
        "Crowd Control Electric Shield",
        [
            Specialties.Intel,
            Specialties.CrowdControl
        ],
        "GSUTR",
        "London, England",
        179,
        73,
        "Morowa Evans",
        new OperatorAge(7, 6, 35),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Kaid"/>.
    /// </summary>
    public static Operator Kaid { get; } = new Operator(
        "Kaid",
        [
            new Weapon(
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
            new Weapon(
                Kaid,
                "TCSG12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                63,
                450,
                10,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1410,
                2290
            )
        ],
        [
            new Weapon(
                Kaid,
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
                Kaid,
                "LFP586",
                Weapon.WeaponType.Handgun,
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
        Weapon.Gadget.NitroCell | Weapon.Gadget.BarbedWire | Weapon.Gadget.ObservationBlocker,
        "Rtila Electroclaw",
        [
            Specialties.AntiEntry,
            Specialties.AntiGadget
        ],
        "GIGR",
        "Aroumd, Morocco",
        195,
        98,
        "Jalal El Fassi",
        new OperatorAge(26, 6, 58),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Mozzie"/>.
    /// </summary>
    public static Operator Mozzie { get; } = new Operator(
        "Mozzie",
        [
            new Weapon(
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
            new Weapon(
                Mozzie,
                "P10 RONI",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                26,
                980,
                15,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1120,
                2200
            )
        ],
        [
            new Weapon(
                Mozzie,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.NitroCell,
        "Pest Launcher",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "SASR",
        "Portland, Australia",
        162,
        57,
        "Max Goose",
        new OperatorAge(15, 2, 35),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Warden"/>.
    /// </summary>
    public static Operator Warden { get; } = new Operator(
        "Warden",
        [
            new Weapon(
                Warden,
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
                Warden,
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
            )
        ],
        [
            new Weapon(
                Warden,
                "P-10C",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                40,
                450,
                15,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                1240,
                1380
            ),
            new Weapon(
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
        ],
        Weapon.Gadget.DeployableShield | Weapon.Gadget.NitroCell | Weapon.Gadget.ObservationBlocker,
        "Glance Smart Glasses",
        [
            Specialties.AntiGadget,
            Specialties.Intel
        ],
        "SECRET SERVICE",
        "Louisville, Kentucky",
        183,
        80,
        "Collinn McKinley",
        new OperatorAge(18, 3, 48),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Goyo"/>.
    /// </summary>
    public static Operator Goyo { get; } = new Operator(
        "Goyo",
        [
            new Weapon(
                Goyo,
                "Vector .45 ACP",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                23,
                1200,
                25,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1330,
                2170
            ),
            new Weapon(
                Goyo,
                "TCSG12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.SingleShot,
                63,
                450,
                10,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1410,
                2290
            )
        ],
        [
            new Weapon(
                Goyo,
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
            )
        ],
        Weapon.Gadget.ProximityAlarm | Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ImpactGrenade,
        "Volcán Canister",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "FUERZAS ESPECIALES",
        "Culiacán Rosales, Mexico",
        171,
        83,
        "César Ruiz Hernández",
        new OperatorAge(20, 6, 31),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Wamai"/>.
    /// </summary>
    public static Operator Wamai { get; } = new Operator(
        "Wamai",
        [
            new Weapon(
                Wamai,
                "AUG A2",
                Weapon.WeaponType.AssaultRifle,
                Weapon.FiringMode.FullAuto,
                42,
                720,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator,
                Weapon.Grip.HorizontalGrip,
                true,
                1470,
                2340
            ),
            new Weapon(
                Wamai,
                "MP5K",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                30,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1280,
                2150
            )
        ],
        [
            new Weapon(
                Wamai,
                "Keratos .357",
                Weapon.WeaponType.Handgun,
                Weapon.FiringMode.SingleShot,
                78,
                450,
                6,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.HorizontalGrip,
                true,
                3020,
                3020
            ),
            new Weapon(
                Wamai,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.ProximityAlarm,
        "Magnetic Neutralizing Electronic Targeting (Mag-NET) System",
        [
            Specialties.AntiGadget,
            Specialties.Trapper
        ],
        "NIGHTHAVEN",
        "Lamu, Kenya",
        187,
        83,
        "Ngũgĩ Muchoki Furaha",
        new OperatorAge(1, 6, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Oryx"/>.
    /// </summary>
    public static Operator Oryx { get; } = new Operator(
        "Oryx",
        [
            new Weapon(
                Oryx,
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
            ),
            new Weapon(
                Oryx,
                "SPAS-12",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3470,
                4430
            )
        ],
        [
            new Weapon(
                Oryx,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            ),
            new Weapon(
                Oryx,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.ProximityAlarm,
        "Remah Dash",
        [
            Specialties.Support
        ],
        "[UNAFFILIATED]",
        "Azraq, Jordan",
        195,
        130,
        "Saif Al Hadid",
        new OperatorAge(3, 7, 45),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Melusi"/>.
    /// </summary>
    public static Operator Melusi { get; } = new Operator(
        "Melusi",
        [
            new Weapon(
                Melusi,
                "MP5",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                27,
                800,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2220
            ),
            new Weapon(
                Melusi,
                "Super 90",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                35,
                200,
                8,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                4320,
                5180
            )
        ],
        [
            new Weapon(
                Melusi,
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
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ImpactGrenade,
        "Banshee Sonic Defense",
        [
            Specialties.Intel,
            Specialties.CrowdControl
        ],
        "INKABA TASK FORCE",
        "Louwsburg, South Africa",
        172,
        68,
        "Thandiwe Ndlovu",
        new OperatorAge(16, 6, 32),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Aruni"/>.
    /// </summary>
    public static Operator Aruni { get; } = new Operator(
        "Aruni",
        [
            new Weapon(
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
            new Weapon(
                Aruni,
                "Mk 14 EBR",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                60,
                450,
                20,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1490,
                2440
            )
        ],
        [
            new Weapon(
                Aruni,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.BulletproofCamera,
        "Surya Gate",
        [
            Specialties.AntiEntry,
            Specialties.AntiGadget
        ],
        "NIGHTHAVEN",
        "Ta Phraya District, Thailand",
        160,
        58,
        "Apha Tawanroong",
        new OperatorAge(9, 8, 42),
        1
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thunderbird"/>.
    /// </summary>
    public static Operator Thunderbird { get; } = new Operator(
        "Thunderbird",
        [
            new Weapon(
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
            new Weapon(
                Thunderbird,
                "SPAS-15",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                30,
                290,
                6,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                1180,
                2020
            )
        ],
        [
            new Weapon(
                Thunderbird,
                "Bearing 9",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                33,
                1100,
                25,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1300,
                2210
            ),
            new Weapon(
                Thunderbird,
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
        Weapon.Gadget.BarbedWire | Weapon.Gadget.BulletproofCamera | Weapon.Gadget.DeployableShield,
        "Kóna Healing Station",
        [
            Specialties.Support
        ],
        "STAR-NET AVIATION",
        "Nakoda Territories",
        172,
        70,
        "Mina Sky",
        new OperatorAge(1, 4, 36),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Thorn"/>.
    /// </summary>
    public static Operator Thorn { get; } = new Operator(
        "Thorn",
        [
            new Weapon(
                Thorn,
                "UZK50GI",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                36,
                700,
                22,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1370,
                2300
            ),
            new Weapon(
                Thorn,
                "M870",
                Weapon.WeaponType.ShotgunShot,
                Weapon.FiringMode.SingleShot,
                60,
                100,
                7,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3410,
                4360
            )
        ],
        [
            new Weapon(
                Thorn,
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
            ),
            new Weapon(
                Thorn,
                "C75 Auto",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                35,
                1000,
                26,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.Suppressor,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2220
            )
        ],
        Weapon.Gadget.DeployableShield | Weapon.Gadget.BarbedWire,
        "Razorbloom Shell",
        [
            Specialties.AntiEntry,
            Specialties.Trapper
        ],
        "EMERGENCY RESPONSE UNIT",
        "County Kildare, Ireland",
        188,
        78,
        "Brianna Skehan",
        new OperatorAge(18, 6, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Azami"/>.
    /// </summary>
    public static Operator Azami { get; } = new Operator(
        "Azami",
        [
            new Weapon(
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
            new Weapon(
                Azami,
                "ACS12",
                Weapon.WeaponType.ShotgunSlug,
                Weapon.FiringMode.FullAuto,
                69,
                300,
                30,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.None,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1590,
                2440
            )
        ],
        [
            new Weapon(
                Azami,
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
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BarbedWire,
        "Kiba Barrier",
        [
            Specialties.AntiEntry,
            Specialties.Support
        ],
        "UNAFFILIATED",
        "Kyoto, Japan",
        164,
        56.7M,
        "Kana Fujiwara",
        new OperatorAge(6, 9, 28),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Solis"/>.
    /// </summary>
    public static Operator Solis { get; } = new Operator(
        "Solis",
        [
            new Weapon(
                Solis,
                "P90",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                22,
                970,
                50,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1560,
                2190
            ),
            new Weapon(
                Solis,
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
                Solis,
                "SMG-11",
                Weapon.WeaponType.MachinePistol,
                Weapon.FiringMode.FullAuto,
                32,
                1270,
                16,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.ExtendedBarrel | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1270,
                2130
            )
        ],
        Weapon.Gadget.ImpactGrenade | Weapon.Gadget.BulletproofCamera,
        "SPEC-IO Electro-Sensor",
        [
            Specialties.Intel,
            Specialties.Support
        ],
        "AFEAU",
        "Zipaquirá, Colombia",
        166,
        65M,
        "Ana Valentina Díaz",
        new OperatorAge(18, 9, 37),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Fenrir"/>.
    /// </summary>
    public static Operator Fenrir { get; } = new Operator(
        "Fenrir",
        [
            new Weapon(
                Fenrir,
                "MP7",
                Weapon.WeaponType.SubmachineGun,
                Weapon.FiringMode.FullAuto,
                32,
                900,
                30,
                Weapon.Sight.NonMagnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.FlashHider | Weapon.Barrel.Compensator | Weapon.Barrel.MuzzleBrake | Weapon.Barrel.ExtendedBarrel,
                Weapon.Grip.HorizontalGrip,
                true,
                1320,
                2250
            ),
            new Weapon(
                Fenrir,
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
                Fenrir,
                "Bailiff 410",
                Weapon.WeaponType.Revolver,
                Weapon.FiringMode.SingleShot,
                30,
                485,
                5,
                Weapon.Sight.NoneOther,
                Weapon.Barrel.None,
                Weapon.Grip.HorizontalGrip,
                true,
                3260,
                3370
            )
        ],
        Weapon.Gadget.BulletproofCamera | Weapon.Gadget.BarbedWire,
        "F-NATT Dread Mine",
        [
            Specialties.CrowdControl,
            Specialties.Trapper
        ],
        "[UNAFFILIATED]",
        "Zipaquirá, Colombia",
        176,
        74M,
        "Emil Svensson",
        new OperatorAge(3, 12, 34),
        2
    );

    /// <summary>
    /// The <see cref="Operator"/> <see cref="Tubarao"/>.
    /// </summary>
    public static Operator Tubarao { get; } = new Operator(
        "Tubarão",
        [
            new Weapon(
                Tubarao,
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
            new Weapon(
                Tubarao,
                "AR-15.50",
                Weapon.WeaponType.MarksmanRifle,
                Weapon.FiringMode.SingleShot,
                67,
                450,
                10,
                Weapon.Sight.Magnifying,
                Weapon.Barrel.Suppressor | Weapon.Barrel.MuzzleBrake,
                Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                true,
                1280,
                2120
            )
        ],
        [
            new Weapon(
                Tubarao,
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
        Weapon.Gadget.NitroCell | Weapon.Gadget.ProximityAlarm,
        "Zoto Canister",
        [
            Specialties.AntiGadget,
            Specialties.CrowdControl
        ],
        "DAE",
        "Ponta Delgada, Portugal",
        173,
        69,
        "Isaac Nunes Oliveira",
        new OperatorAge(24, 11, 35),
        2
    );
    #endregion

#pragma warning restore CS8604 // Possible null reference argument.

    /// <summary>
    /// Compiles specific challenges from all <see cref="Defenders"/>' specialties into a collection.
    /// </summary>
    /// <param name="trapper">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Trapper" /> <see cref="Specialty" />.</param>
    /// <param name="support">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Support" /> <see cref="Specialty" />.</param>
    /// <param name="antientry">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AntiEntry" /> <see cref="Specialty" />.</param>
    /// <param name="intel">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="Intel" /> <see cref="Specialty" />.</param>
    /// <param name="antigadget">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="AntiGadget" /> <see cref="Specialty" />.</param>
    /// <param name="crowdcontrol">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="CrowdControl" /> <see cref="Specialty" />.</param>
    /// <returns>A</returns>
    public static Dictionary<Specialty, string> GetPersonalSpecialtyChallengeSet(int trapper, int support, int antientry, int intel, int antigadget, int crowdcontrol)
    {
        Dictionary<Specialty, string> challenges = [];

        if (trapper is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Trapper, $"{Specialties.Trapper.Name,-13} -> {Specialties.Trapper.Challenges[trapper - 1].Description}");
        }
        if (support is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Support, $"{Specialties.Support.Name,-13} -> {Specialties.Support.Challenges[support - 1].Description}");
        }
        if (antientry is >= 1 and <= 3)
        {
            challenges.Add(Specialties.AntiEntry, $"{Specialties.AntiEntry.Name,-13} -> {Specialties.AntiEntry.Challenges[antientry - 1].Description}");
        }
        if (intel is >= 1 and <= 3)
        {
            challenges.Add(Specialties.Intel, $"{Specialties.Intel.Name,-13} -> {Specialties.Intel.Challenges[intel - 1].Description}");
        }
        if (antigadget is >= 1 and <= 3)
        {
            challenges.Add(Specialties.AntiGadget, $"{Specialties.AntiGadget.Name,-13} -> {Specialties.AntiGadget.Challenges[antigadget - 1].Description}");
        }
        if (crowdcontrol is >= 1 and <= 3)
        {
            challenges.Add(Specialties.CrowdControl, $"{Specialties.CrowdControl.Name,-13} -> {Specialties.CrowdControl.Challenges[crowdcontrol - 1].Description}");
        }

        return challenges;
    }
}
