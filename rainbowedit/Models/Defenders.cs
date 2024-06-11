using rainbowedit.Models;

namespace rainbowedit;

/// <summary>
/// The <see cref="Defenders"/> in Siege.
/// </summary>
public static class Defenders
{
    /// <summary>
    /// Retrieves a <see cref="List{T}"/> of all <see cref="Defender"/>s.
    /// </summary>
    public static ImmutableArray<Defender> All { get; private set; }

    static Defenders()
    {
        #region Defender instances
        #region Recruit/Sentry
        Sentry = new Defender(
            "Sentry",
            [
                new Weapon(
                    null,
                    "Commando 9",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    36,
                    780,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1200,
                    1540
                ),
                new Weapon(
                    null,
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
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
            ],
            Weapon.Gadget.BarbedWire | Weapon.Gadget.BulletproofCamera | Weapon.Gadget.DeployableShield | Weapon.Gadget.ObservationBlocker | Weapon.Gadget.ImpactGrenade | Weapon.Gadget.NitroCell | Weapon.Gadget.ProximityAlarm,
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

        #region Smoke
        Smoke = new Defender(
            "Smoke",
            [
                new Weapon(
                    null,
                    "FMG-9",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    800,
                    30,
                    Weapon.Sight.NonMagnifying,
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
                    null,
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
                    null,
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
                    null,
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
                )
            ],
            Weapon.Gadget.BarbedWire | Weapon.Gadget.ProximityAlarm,
            "Compound Z8 Grenades",
            [Specialties.AntiEntry, Specialties.Trapper],
            "SAS",
            "London, England (King's Cross)",
            173,
            70,
            "James Porter",
            new OperatorAge(14, 5, 36),
            2
        );
        #endregion
        #region Mute
        Mute = new Defender(
            "Mute",
            [
                new Weapon(
                    null,
                    "MP5K",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    30,
                    800,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1280,
                    2150
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
                )
            ],
            Weapon.Gadget.NitroCell | Weapon.Gadget.BulletproofCamera,
            "\"Moni\" GC90 Signal Disruptor",
            [Specialties.AntiGadget, Specialties.CrowdControl],
            "SAS",
            "York, England",
            185,
            80,
            "Mark R. Chandar",
            new OperatorAge(11, 10, 25),
            1
        );
        #endregion
        #region Castle
        Castle = new Defender(
            "Castle",
            [
                new Weapon(
                    null,
                    "UMP45",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    38,
                    600,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1480,
                    2190
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.Support],
            "FBI SWAT",
            "Sherman Oaks, California",
            185,
            86,
            "Miles Campbell",
            new OperatorAge(20, 9, 36),
            2
        );
        #endregion
        #region Pulse
        Pulse = new Defender(
            "Pulse",
            [
                new Weapon(
                    null,
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
                    null,
                    "UMP45",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    38,
                    600,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1480,
                    2190
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.NitroCell
                | Weapon.Gadget.DeployableShield
                | Weapon.Gadget.ObservationBlocker,
            "HB-5 Cardiac Sensor",
            [Specialties.Intel, Specialties.Support],
            "FBI SWAT",
            "Goldsboro, North Carolina",
            188,
            85,
            "Jack Estrada",
            new OperatorAge(11, 10, 32),
            3
        );
        #endregion
        #region Doc
        Doc = new Defender(
            "Doc",
            [
                new Weapon(
                    null,
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
                    null,
                    "MP5",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    27,
                    800,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1280,
                    2220
                ),
                new Weapon(
                    null,
                    "P90",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    22,
                    970,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1560,
                    2190
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.Support],
            "GIGN",
            "Paris, France",
            177,
            74,
            "Gustave Kateb",
            new OperatorAge(16, 9, 39),
            1
        );
        #endregion
        #region Rook
        Rook = new Defender(
            "Rook",
            [
                new Weapon(
                    null,
                    "P90",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    22,
                    970,
                    50,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1560,
                    2190
                ),
                new Weapon(
                    null,
                    "MP5",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    27,
                    800,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1280,
                    2220
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            Weapon.Gadget.ProximityAlarm
                | Weapon.Gadget.ImpactGrenade
                | Weapon.Gadget.ObservationBlocker,
            "R1N \"Rhino\" Armor - Armor Pack",
            [Specialties.Support],
            "GIGN",
            "Tours, France",
            175,
            72,
            "Julien Nizan",
            new OperatorAge(6, 1, 27),
            1
        );
        #endregion
        #region Kapkan
        Kapkan = new Defender(
            "Kapkan",
            [
                new Weapon(
                    null,
                    "9x19VSN",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    750,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1430,
                    2220
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.Trapper],
            "SPETSNAZ",
            "Kovrov, Russia",
            180,
            80,
            "Maxim Basuda",
            new OperatorAge(14, 5, 38),
            2
        );
        #endregion
        #region Tachanka
        Tachanka = new Defender(
            "Tachanka",
            [
                new Weapon(
                    null,
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
                    null,
                    "9x19VSN",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
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
                    1430,
                    2220
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
                    null,
                    "Bearing 9",
                    Weapon.WeaponType.MachinePistol,
                    Weapon.FiringMode.FullAuto,
                    33,
                    1100,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1300,
                    2210
                )
            ],
            Weapon.Gadget.BarbedWire
                | Weapon.Gadget.DeployableShield
                | Weapon.Gadget.ProximityAlarm,
            "Shumikha Grenade Launcher",
            [Specialties.AntiEntry, Specialties.CrowdControl],
            "SPETSNAZ",
            "Saint Petersburg, Russia",
            183,
            86,
            "Alexsandr Sanaviev",
            new OperatorAge(3, 11, 48),
            1
        );
        #endregion
        #region Jäger
        Jäger = new Defender(
            "Jäger",
            [
                new Weapon(
                    null,
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
                    null,
                    "416-C Carbine",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    38,
                    740,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1340,
                    2180
                )
            ],
            [
                new Weapon(
                    null,
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
            [Specialties.AntiGadget, Specialties.Support],
            "GSG 9",
            "Düsseldorf, Germany",
            180,
            64,
            "Marius Streicher",
            new OperatorAge(9, 3, 39),
            2
        );
        #endregion
        #region Bandit
        Bandit = new Defender(
            "Bandit",
            [
                new Weapon(
                    null,
                    "MP7",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    32,
                    900,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1320,
                    2250
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.AntiGadget],
            "GSG 9",
            "Berlin, Germany",
            180,
            68,
            "Dominic Brunsmeier",
            new OperatorAge(13, 8, 42),
            3
        );
        #endregion
        #region Frost
        Frost = new Defender(
            "Frost",
            [
                new Weapon(
                    null,
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
                    null,
                    "9mm C1",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    36,
                    575,
                    34,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1290,
                    2070
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.Trapper],
            "JTF2",
            "Vancouver, British Columbia",
            172,
            63,
            "Tina Lin Tsang",
            new OperatorAge(4, 5, 32),
            2
        );
        #endregion
        #region Valkyrie
        Valkyrie = new Defender(
            "Valkyrie",
            [
                new Weapon(
                    null,
                    "MPX",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    830,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1310,
                    2040
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.Intel, Specialties.Support],
            "NAVY SEAL",
            "Oceanside, California",
            170,
            61,
            "Meghan J. Castellano",
            new OperatorAge(21, 7, 31),
            2
        );
        #endregion
        #region Caveira
        Caveira = new Defender(
            "Caveira",
            [
                new Weapon(
                    null,
                    "M12",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    40,
                    550,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1290,
                    2170
                ),
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.ImpactGrenade
                | Weapon.Gadget.ProximityAlarm
                | Weapon.Gadget.ObservationBlocker,
            "Silent Step",
            [Specialties.Intel, Specialties.CrowdControl],
            "BOPE",
            "Rinópolis, Brazil",
            177,
            72,
            "Taina Pereira",
            new OperatorAge(15, 10, 27),
            3
        );
        #endregion
        #region Echo
        Echo = new Defender(
            "Echo",
            [
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
                    null,
                    "Bearing 9",
                    Weapon.WeaponType.MachinePistol,
                    Weapon.FiringMode.FullAuto,
                    33,
                    1100,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1300,
                    2210
                )
            ],
            Weapon.Gadget.ImpactGrenade | Weapon.Gadget.DeployableShield,
            "Yokai Hovering Drone",
            [Specialties.Intel, Specialties.CrowdControl],
            "SAT",
            "Suginami, Tokyo, Japan",
            180,
            72,
            "Masaru Enatsu",
            new OperatorAge(31, 10, 36),
            2
        );
        #endregion
        #region Mira
        Mira = new Defender(
            "Mira",
            [
                new Weapon(
                    null,
                    "Vector .45 ACP",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    23,
                    1200,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1330,
                    2170
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.Intel, Specialties.Support],
            "GEO",
            "Madrid, Spain",
            165,
            60,
            "Elena María Álvarez",
            new OperatorAge(18, 11, 39),
            1
        );
        #endregion
        #region Lesion
        Lesion = new Defender(
            "Lesion",
            [
                new Weapon(
                    null,
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
                    null,
                    "T-5 SMG",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    28,
                    900,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1400,
                    2180
                )
            ],
            [
                new Weapon(
                    null,
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
            Weapon.Gadget.ObservationBlocker | Weapon.Gadget.BulletproofCamera,
            "Gu Mines",
            [Specialties.AntiEntry, Specialties.Trapper],
            "SDU",
            "Hong Kong, Junk Bay (Tseung Kwan O)",
            174,
            82,
            "Liu Tze Long",
            new OperatorAge(2, 7, 44),
            2
        );
        #endregion
        #region Ela
        Ela = new Defender(
            "Ela",
            [
                new Weapon(
                    null,
                    "Scorpion Evo 3 A1",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    23,
                    1080,
                    40,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1250,
                    2220
                ),
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.BarbedWire
                | Weapon.Gadget.DeployableShield
                | Weapon.Gadget.ObservationBlocker,
            "GRZMOT Mine",
            [Specialties.CrowdControl, Specialties.Trapper],
            "GROM",
            "Wrocław, Poland",
            173,
            68,
            "Elżbieta Bosak",
            new OperatorAge(8, 11, 31),
            2
        );
        #endregion
        #region Vigil
        Vigil = new Defender(
            "Vigil",
            [
                new Weapon(
                    null,
                    "K1A",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    36,
                    720,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1470,
                    2280
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.AntiGadget, Specialties.CrowdControl],
            "707TH SMB",
            "[REDACTED]",
            173,
            73,
            "Chul Kyung Hwa",
            new OperatorAge(17, 1, 34),
            3
        );
        #endregion
        #region Maestro
        Maestro = new Defender(
            "Maestro",
            [
                new Weapon(
                    null,
                    "ALDA 5.56",
                    Weapon.WeaponType.LightMachineGun,
                    Weapon.FiringMode.FullAuto,
                    35,
                    900,
                    80,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip,
                    true,
                    5200,
                    4480
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            Weapon.Gadget.BarbedWire
                | Weapon.Gadget.ImpactGrenade
                | Weapon.Gadget.ObservationBlocker,
            "Compact Laser Emplacement Mk V \"Evil Eye\"",
            [Specialties.AntiGadget, Specialties.Intel],
            "GIS",
            "Rome, Italy",
            185,
            87,
            "Adriano Martello",
            new OperatorAge(13, 4, 45),
            1
        );
        #endregion
        #region Alibi
        Alibi = new Defender(
            "Alibi",
            [
                new Weapon(
                    null,
                    "Mx4 Storm",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    950,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip,
                    true,
                    1570,
                    2200
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.Intel, Specialties.Trapper],
            "GIS",
            "Tripoli, Libya",
            171,
            63,
            "Aria de Luca",
            new OperatorAge(15, 12, 37),
            3
        );
        #endregion
        #region Clash
        Clash = new Defender(
            "Clash",
            [
                new Weapon(
                    null,
                    "CCE Shield",
                    Weapon.WeaponType.Shield,
                    Weapon.FiringMode.Invalid,
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
                    null,
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
                    null,
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
                    null,
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
            [Specialties.Intel, Specialties.CrowdControl],
            "GSUTR",
            "London, England",
            179,
            73,
            "Morowa Evans",
            new OperatorAge(7, 6, 35),
            1
        );
        #endregion
        #region Kaid
        Kaid = new Defender(
            "Kaid",
            [
                new Weapon(
                    null,
                    "AUG A3",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    36,
                    700,
                    31,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1480,
                    2310
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.AntiGadget],
            "GIGR",
            "Aroumd, Morocco",
            195,
            98,
            "Jalal El Fassi",
            new OperatorAge(26, 6, 58),
            1
        );
        #endregion
        #region Mozzie
        Mozzie = new Defender(
            "Mozzie",
            [
                new Weapon(
                    null,
                    "Commando 9",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    36,
                    780,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1200,
                    1540
                ),
                new Weapon(
                    null,
                    "P10 RONI",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    980,
                    15,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1120,
                    2200
                )
            ],
            [
                new Weapon(
                    null,
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
            [Specialties.AntiGadget, Specialties.Intel],
            "SASR",
            "Portland, Australia",
            162,
            57,
            "Max Goose",
            new OperatorAge(15, 2, 35),
            2
        );
        #endregion
        #region Warden
        Warden = new Defender(
            "Warden",
            [
                new Weapon(
                    null,
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
                    null,
                    "MPX",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    830,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1310,
                    2040
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.DeployableShield
                | Weapon.Gadget.NitroCell
                | Weapon.Gadget.ObservationBlocker,
            "Glance Smart Glasses",
            [Specialties.AntiGadget, Specialties.Intel],
            "SECRET SERVICE",
            "Louisville, Kentucky",
            183,
            80,
            "Collinn McKinley",
            new OperatorAge(18, 3, 48),
            1
        );
        #endregion
        #region Goyo
        Goyo = new Defender(
            "Goyo",
            [
                new Weapon(
                    null,
                    "Vector .45 ACP",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    23,
                    1200,
                    25,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1330,
                    2170
                ),
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.ProximityAlarm
                | Weapon.Gadget.BulletproofCamera
                | Weapon.Gadget.ImpactGrenade,
            "Volcán Canister",
            [Specialties.AntiEntry, Specialties.Trapper],
            "FUERZAS ESPECIALES",
            "Culiacán Rosales, Mexico",
            171,
            83,
            "César Ruiz Hernández",
            new OperatorAge(20, 6, 31),
            2
        );
        #endregion
        #region Wamai
        Wamai = new Defender(
            "Wamai",
            [
                new Weapon(
                    null,
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
                    null,
                    "MP5K",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    30,
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
                    1280,
                    2150
                )
            ],
            [
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiGadget, Specialties.Trapper],
            "NIGHTHAVEN",
            "Lamu, Kenya",
            187,
            83,
            "Ngũgĩ Muchoki Furaha",
            new OperatorAge(1, 6, 28),
            2
        );
        #endregion
        #region Oryx
        Oryx = new Defender(
            "Oryx",
            [
                new Weapon(
                    null,
                    "T-5 SMG",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    28,
                    900,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1400,
                    2180
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.Support],
            "[UNAFFILIATED]",
            "Azraq, Jordan",
            195,
            130,
            "Saif Al Hadid",
            new OperatorAge(3, 7, 45),
            2
        );
        #endregion
        #region Melusi
        Melusi = new Defender(
            "Melusi",
            [
                new Weapon(
                    null,
                    "MP5",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    27,
                    800,
                    30,
                    Weapon.Sight.Magnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1280,
                    2220
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.Intel, Specialties.CrowdControl],
            "INKABA TASK FORCE",
            "Louwsburg, South Africa",
            172,
            68,
            "Thandiwe Ndlovu",
            new OperatorAge(16, 6, 32),
            1
        );
        #endregion
        #region Aruni
        Aruni = new Defender(
            "Aruni",
            [
                new Weapon(
                    null,
                    "P10 RONI",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    980,
                    15,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1120,
                    2200
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.AntiGadget],
            "NIGHTHAVEN",
            "Ta Phraya District, Thailand",
            160,
            58,
            "Apha Tawanroong",
            new OperatorAge(9, 8, 42),
            1
        );
        #endregion
        #region Thunderbird
        Thunderbird = new Defender(
            "Thunderbird",
            [
                new Weapon(
                    null,
                    "Spear .308",
                    Weapon.WeaponType.AssaultRifle,
                    Weapon.FiringMode.FullAuto,
                    42,
                    700,
                    30,
                    Weapon.Sight.NonMagnifying,
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
                    null,
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
                    null,
                    "Bearing 9",
                    Weapon.WeaponType.MachinePistol,
                    Weapon.FiringMode.FullAuto,
                    33,
                    1100,
                    25,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1300,
                    2210
                ),
                new Weapon(
                    null,
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
            Weapon.Gadget.BarbedWire
                | Weapon.Gadget.BulletproofCamera
                | Weapon.Gadget.DeployableShield,
            "Kóna Healing Station",
            [Specialties.Support],
            "STAR-NET AVIATION",
            "Nakoda Territories",
            172,
            70,
            "Mina Sky",
            new OperatorAge(1, 4, 36),
            2
        );
        #endregion
        #region Thorn
        Thorn = new Defender(
            "Thorn",
            [
                new Weapon(
                    null,
                    "UZK50GI",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    36,
                    700,
                    22,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1370,
                    2300
                ),
                new Weapon(
                    null,
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
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.Trapper],
            "EMERGENCY RESPONSE UNIT",
            "County Kildare, Ireland",
            188,
            78,
            "Brianna Skehan",
            new OperatorAge(18, 6, 28),
            2
        );
        #endregion
        #region Azami
        Azami = new Defender(
            "Azami",
            [
                new Weapon(
                    null,
                    "9x19VSN",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    34,
                    750,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1430,
                    2220
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiEntry, Specialties.Support],
            "UNAFFILIATED",
            "Kyoto, Japan",
            164,
            56.7M,
            "Kana Fujiwara",
            new OperatorAge(6, 9, 28),
            2
        );
        #endregion
        #region Solis
        Solis = new Defender(
            "Solis",
            [
                new Weapon(
                    null,
                    "P90",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    22,
                    970,
                    50,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1560,
                    2190
                ),
                new Weapon(
                    null,
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
                    null,
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
                        | Weapon.Barrel.ExtendedBarrel
                        | Weapon.Barrel.MuzzleBrake,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1270,
                    2130
                )
            ],
            Weapon.Gadget.ProximityAlarm | Weapon.Gadget.BulletproofCamera,
            "SPEC-IO Electro-Sensor",
            [Specialties.Intel, Specialties.Support],
            "AFEAU",
            "Zipaquirá, Colombia",
            166,
            65M,
            "Ana Valentina Díaz",
            new OperatorAge(18, 9, 37),
            2
        );
        #endregion
        #region Fenrir
        Fenrir = new Defender(
            "Fenrir",
            [
                new Weapon(
                    null,
                    "MP7",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    32,
                    900,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.HorizontalGrip,
                    true,
                    1320,
                    2250
                ),
                new Weapon(
                    null,
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
                    null,
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
            Weapon.Gadget.BulletproofCamera | Weapon.Gadget.ObservationBlocker,
            "F-NATT Dread Mine",
            [Specialties.CrowdControl, Specialties.Trapper],
            "[UNAFFILIATED]",
            "Zipaquirá, Colombia",
            176,
            74M,
            "Emil Svensson",
            new OperatorAge(3, 12, 34),
            2
        );
        #endregion
        #region Tubarao
        Tubarao = new Defender(
            "Tubarão",
            [
                new Weapon(
                    null,
                    "MPX",
                    Weapon.WeaponType.SubmachineGun,
                    Weapon.FiringMode.FullAuto,
                    26,
                    830,
                    30,
                    Weapon.Sight.NonMagnifying,
                    Weapon.Barrel.Suppressor
                        | Weapon.Barrel.FlashHider
                        | Weapon.Barrel.Compensator
                        | Weapon.Barrel.MuzzleBrake
                        | Weapon.Barrel.ExtendedBarrel,
                    Weapon.Grip.VerticalGrip | Weapon.Grip.AngledGrip,
                    true,
                    1310,
                    2040
                ),
                new Weapon(
                    null,
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
                    null,
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
            [Specialties.AntiGadget, Specialties.CrowdControl],
            "DAE",
            "Ponta Delgada, Portugal",
            173,
            69,
            "Isaac Nunes Oliveira",
            new OperatorAge(24, 11, 35),
            2
        );
        #endregion
        All =
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

        foreach (var op in All.Concat([Sentry]))
        {
            foreach (var wep in op.Primaries.Concat(op.Secondaries))
            {
                wep.Source = op;
            }
        }
        #endregion

        // Same as above
        Specialties.Trapper.Reward = Ela;
        Specialties.Support.Reward = Rook;
        Specialties.AntiEntry.Reward = Castle;
        Specialties.Intel.Reward = Valkyrie;
        Specialties.AntiGadget.Reward = Jäger;
        Specialties.CrowdControl.Reward = Tachanka;
    }

    /// <summary>
    /// Gets a <see cref="DefenderSpecialties"/> instance that contains the <see cref="Specialty"/> instances for <see cref="Defender"/>s.
    /// </summary>
    public static DefenderSpecialties Specialties { get; } = new DefenderSpecialties();

    #region Defender instances
    /// <summary>
    /// The <see cref="Defender"/> Recruit <see cref="Sentry"/>.
    /// </summary>
    public static Defender Sentry { get; }

    /// <summary>
    /// The <see cref="Defender"/> <see cref="Smoke"/>.
    /// </summary>
    public static Defender Smoke { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Mute"/>.
    /// </summary>
    public static Defender Mute { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Castle"/>.
    /// </summary>
    public static Defender Castle { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Pulse"/>.
    /// </summary>
    public static Defender Pulse { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Doc"/>.
    /// </summary>
    public static Defender Doc { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Rook"/>.
    /// </summary>
    public static Defender Rook { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Kapkan"/>.
    /// </summary>
    public static Defender Kapkan { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Tachanka"/>.
    /// </summary>
    public static Defender Tachanka { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Jäger"/>.
    /// </summary>
    public static Defender Jäger { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Bandit"/>.
    /// </summary>
    public static Defender Bandit { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Frost"/>.
    /// </summary>
    public static Defender Frost { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Valkyrie"/>.
    /// </summary>
    public static Defender Valkyrie { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Caveira"/>.
    /// </summary>
    public static Defender Caveira { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Echo"/>.
    /// </summary>
    public static Defender Echo { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Mira"/>.
    /// </summary>
    public static Defender Mira { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Lesion"/>.
    /// </summary>
    public static Defender Lesion { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Ela"/>.
    /// </summary>
    public static Defender Ela { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Vigil"/>.
    /// </summary>
    public static Defender Vigil { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Maestro"/>.
    /// </summary>
    public static Defender Maestro { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Alibi"/>.
    /// </summary>
    public static Defender Alibi { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Clash"/>.
    /// </summary>
    public static Defender Clash { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Kaid"/>.
    /// </summary>
    public static Defender Kaid { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Mozzie"/>.
    /// </summary>
    public static Defender Mozzie { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Warden"/>.
    /// </summary>
    public static Defender Warden { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Goyo"/>.
    /// </summary>
    public static Defender Goyo { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Wamai"/>.
    /// </summary>
    public static Defender Wamai { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Oryx"/>.
    /// </summary>
    public static Defender Oryx { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Melusi"/>.
    /// </summary>
    public static Defender Melusi { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Aruni"/>.
    /// </summary>
    public static Defender Aruni { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Thunderbird"/>.
    /// </summary>
    public static Defender Thunderbird { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Thorn"/>.
    /// </summary>
    public static Defender Thorn { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Azami"/>.
    /// </summary>
    public static Defender Azami { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Solis"/>.
    /// </summary>
    public static Defender Solis { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Fenrir"/>.
    /// </summary>
    public static Defender Fenrir { get; }
    /// <summary>
    /// The <see cref="Defender"/> <see cref="Tubarao"/>.
    /// </summary>
    public static Defender Tubarao { get; }
    #endregion

    /// <summary>
    /// Compiles specific challenges from all <see cref="Defenders"/>' specialties into a collection.
    /// </summary>
    /// <param name="trapper">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.Trapper" /> <see cref="Specialty" />.</param>
    /// <param name="support">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.Support" /> <see cref="Specialty" />.</param>
    /// <param name="antientry">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.AntiEntry" /> <see cref="Specialty" />.</param>
    /// <param name="intel">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.Intel" /> <see cref="Specialty" />.</param>
    /// <param name="antigadget">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.AntiGadget" /> <see cref="Specialty" />.</param>
    /// <param name="crowdcontrol">The <see cref="Specialty.Challenge" /> to retrieve for the <see cref="DefenderSpecialties.CrowdControl" /> <see cref="Specialty" />.</param>
    /// <returns>An <see cref="ImmutableDictionary{TKey, TValue}"/> that maps <see cref="Specialty"/> instances corresponding to the supplied progress values to their respective next <see cref="Specialty.Challenge"/>s.</returns>
    public static ImmutableDictionary<Specialty, string> GetPersonalSpecialtyChallengeSet(
        int trapper,
        int support,
        int antientry,
        int intel,
        int antigadget,
        int crowdcontrol
    )
    {
        Dictionary<Specialty, string> challenges = [];

        if (trapper is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.Trapper,
                $"{Specialties.Trapper.Name,-13} -> {Specialties.Trapper.Challenges[trapper - 1].Description}"
            );
        }
        if (support is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.Support,
                $"{Specialties.Support.Name,-13} -> {Specialties.Support.Challenges[support - 1].Description}"
            );
        }
        if (antientry is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.AntiEntry,
                $"{Specialties.AntiEntry.Name,-13} -> {Specialties.AntiEntry.Challenges[antientry - 1].Description}"
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
        if (crowdcontrol is >= 1 and <= 3)
        {
            challenges.Add(
                Specialties.CrowdControl,
                $"{Specialties.CrowdControl.Name,-13} -> {Specialties.CrowdControl.Challenges[crowdcontrol - 1].Description}"
            );
        }

        return challenges.ToImmutableDictionary();
    }
}
