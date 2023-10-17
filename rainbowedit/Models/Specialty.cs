using System.Linq;

using rainbowedit;

namespace rainbowedit.Models;

/// <summary>
/// Represents a <see cref="Specialty"/>, introduced in Y8S1.
/// </summary>
public class Specialty
{
    /// <summary>
    /// The name of this <see cref="Specialty"/>.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The <see cref="Operator"/> reward for completing all three of this <see cref="Specialty"/>'s <see cref="Challenges"/>.
    /// </summary>
    public Operator Reward { get; set; }
    /// <summary>
    /// A list of <see cref="Challenge"/>s to be completed to unlock rewards and finally the <see cref="Reward"/> <see cref="Operator"/>.
    /// </summary>
    public List<Challenge> Challenges { get; }

    /// <summary>
    /// Instantiates a new <see cref="Specialty"/> with a specified name, <see cref="Operator"/> reward, and list of <see cref="Challenges"/>.
    /// </summary>
    /// <param name="name">The name of the <see cref="Specialty"/>.</param>
    /// <param name="reward">The <see cref="Operator"/> reward for completing all three of this <see cref="Specialty"/>'s <paramref name="challenges"/>.</param>
    /// <param name="challenges">The list of challenges for this <see cref="Specialty"/>.</param>
    internal Specialty(string name, Operator reward, List<Challenge> challenges)
    {
        Name = name;
        Reward = reward;
        Challenges = challenges;
    }

    /// <summary>
    /// Compiles a collection of all <see cref="Operator"/>s that have this <see cref="Specialty"/>.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Operator"/> that have this <see cref="Specialty"/>.</returns>
    public IEnumerable<Operator> GetOperators() => Siege.DefAtk.Where(op => op.Specialties.Contains(this));

    /// <summary>
    /// Represents one of the three challenges of a <see cref="Specialty"/>.
    /// </summary>
    public class Challenge
    {
        /// <summary>
        /// The description of the <see cref="Challenge" />.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The reward for completing the <see cref="Challenge" />.
        /// </summary>
        public string Reward { get; }

        /// <summary>
        /// Instantiates a new <see cref="Challenge" /> with the specified name, description, and reward.
        /// </summary>
        /// <param name="description">The description of the challenge.</param>
        /// <param name="reward">The reward for completing the challenge.</param>
        internal Challenge(string description, string reward)
        {
            Description = description;
            Reward = reward;
        }
    }
}
