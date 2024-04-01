using System.Collections;
using System.Diagnostics;

namespace rainbowedit.Models;

/// <summary>
/// Serves as the base class for a collection of <see cref="Specialty"/> instances.
/// </summary>
public abstract class SpecialtyCollection : IEnumerable<Specialty>
{
    protected List<Specialty> specialties;

    public virtual IEnumerator<Specialty> GetEnumerator() => specialties.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Implements a collection of <see cref="Specialty"/> instances that apply to the <see cref="Defender"/>s.
/// </summary>
public sealed class DefenderSpecialties : SpecialtyCollection
{
    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="Trapper"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Trapper { get; } =
        new Specialty(
            "Trapper",
            null,
            [
                new Specialty.Challenge("Deploy 5 trap devices.", "1-Day Renown Booster 1x"),
                new Specialty.Challenge(
                    "Affect 1 opponents with trap devices.",
                    "Beginner Pack 2x"
                ),
                new Specialty.Challenge(
                    "Win by counter-defusing the bomb 1 times.",
                    "1-Day Battle Point Booster 3x"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="Support"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Support { get; } =
        new Specialty(
            "Support",
            null,
            [
                new Specialty.Challenge(
                    "Play 1 times as a Support Defender.",
                    "1-Day Renown Booster 1x"
                ),
                new Specialty.Challenge(
                    "Reach the Action Phase as a Defender 2 times without either bomb site being discovered.",
                    "3-Days Renown Booster 1x"
                ),
                new Specialty.Challenge("Heal 2 teammates.", "7-Days Renown Booster")
            ]
        );

    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="AntiEntry"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty AntiEntry { get; } =
        new Specialty(
            "Anti-Entry",
            null,
            [
                new Specialty.Challenge("Barricade 5 doors or windows.", "Renown 250"),
                new Specialty.Challenge("Reinforce 5 surfaces.", "Renown 500"),
                new Specialty.Challenge(
                    "Deploy 5 anti-entry devices that electrify utility or interfere wih electronics.",
                    "Renown 750"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="Intel"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Intel { get; } =
        new Specialty(
            "Intel",
            null,
            [
                new Specialty.Challenge(
                    "Scan and identify 7 Attackers as a Defender.",
                    "Beginner Pack 1x"
                ),
                new Specialty.Challenge("Deploy 5 Observation Tools as a Defender.", "Renown 500"),
                new Specialty.Challenge(
                    "Detect 1 opponents with Proximity Alarms that you deployed.",
                    "7-Days Renown Booster 1x"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="AntiGadget"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty AntiGadget { get; } =
        new Specialty(
            "Anti-Gadget",
            null,
            [
                new Specialty.Challenge("Destroy 2 Attacker drones as a Defender.", "Renown 250"),
                new Specialty.Challenge(
                    "Destroy 5 Attacker devices as a Defender.",
                    "1-Day Battle Point Booster 2x"
                ),
                new Specialty.Challenge("Deactivate or hack 1 Attacker drones.", "Beginner Pack 3x")
            ]
        );

    /// <summary>
    /// The <see cref="Defenders"/>' <see cref="CrowdControl"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty CrowdControl { get; } =
        new Specialty(
            "Crowd Control",
            null,
            [
                new Specialty.Challenge("Deploy 5 Barbed Wire.", "1-Day Battle Point Booster 1x"),
                new Specialty.Challenge(
                    "Deactivate 2 electronic devices using the Bulletproof Camera EMP.",
                    "3-Days Renown Booster 1x"
                ),
                new Specialty.Challenge("Disorient 2 opponents.", "Renown 750")
            ]
        );

    internal DefenderSpecialties()
    {
        specialties = [Trapper, Support, AntiEntry, Intel, AntiGadget, CrowdControl];
    }
}

/// <summary>
/// Implements a collection of <see cref="Specialty"/> instances that apply to the <see cref="Attacker"/>s.
/// </summary>
public sealed class AttackerSpecialties : SpecialtyCollection
{
    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Breach"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Breach { get; } =
        new Specialty(
            "Breach",
            null,
            [
                new Specialty.Challenge("Destroy 5 barricades or hatches.", "Renown 250"),
                new Specialty.Challenge(
                    "Breach 2 reinforced surfaces.",
                    "3-Days Renown Booster 1x"
                ),
                new Specialty.Challenge(
                    "Score 125 points by breaching reinforced surfaces.",
                    "Beginner Pack 3x"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Support"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Support { get; } =
        new Specialty(
            "Support",
            null,
            [
                new Specialty.Challenge("Play 1 times as a Support Attacker.", "Beginner Pack 1x"),
                new Specialty.Challenge("Revive 5 teammates.", "Beginner Pack 2x"),
                new Specialty.Challenge("Win by defusing bombs 1 times.", "Beginner Pack 3x")
            ]
        );

    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="FrontLine"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty FrontLine { get; } =
        new Specialty(
            "Front-Line",
            null,
            [
                new Specialty.Challenge("Get 5 eliminations or assists.", "Beginner Pack 1x"),
                new Specialty.Challenge("Blind 2 opponents.", "Renown 500"),
                new Specialty.Challenge(
                    "Eliminate 5 opponents with explosives as an Attacker.",
                    "7-Days Renown Booster 1x"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="Intel"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty Intel { get; } =
        new Specialty(
            "Intel",
            null,
            [
                new Specialty.Challenge(
                    "Scan and identify 7 Defenders as an Attacker.",
                    "1-Day Renown Booster 1x"
                ),
                new Specialty.Challenge(
                    "Find the bomb as an Attacker 1 times without your drone being destroyed during the Preparation Phase.",
                    "1-Day Battle Point Booster 2x"
                ),
                new Specialty.Challenge("Get 5 Opponents Scan Assists.", "Renown 750")
            ]
        );

    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="AntiGadget"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty AntiGadget { get; } =
        new Specialty(
            "Anti-Gadget",
            null,
            [
                new Specialty.Challenge(
                    "Destroy 5 trap devices as an Attacker.",
                    "1-Day Battle Point Booster 1x"
                ),
                new Specialty.Challenge(
                    "Destroy 5 Observation Tools as an Attacker.",
                    "1-Day Battle Point Booster 2x"
                ),
                new Specialty.Challenge(
                    "Deactivate 2 electronic devices as an Attacker.",
                    "1-Day Battle Point Booster 3x"
                )
            ]
        );

    /// <summary>
    /// The <see cref="Attackers"/>' <see cref="MapControl"/> <see cref="Specialty"/>.
    /// </summary>
    public Specialty MapControl { get; } =
        new Specialty(
            "Map Control",
            null,
            [
                new Specialty.Challenge("Walk or sprint 500 meters as an Attacker.", "Renown 250"),
                new Specialty.Challenge("Get 5 headshots.", "3-Days Renown Booster 1x"),
                new Specialty.Challenge(
                    "Eliminate 2 opponents through breakable surfaces.",
                    "1-Day Battle Point Booster 3x"
                )
            ]
        );

    internal AttackerSpecialties()
    {
        specialties = [Breach, Support, FrontLine, Intel, AntiGadget, MapControl];
    }
}
