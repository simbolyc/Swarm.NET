using System;

namespace Simbolyc.Swarm
{
    /// <summary>
    /// An agent is the base of class of entities that participate in the swarm.
    /// An agent is simply an entity that is universally uniquely identifiable.
    /// Agent instances are immutable.
    /// </summary>
    public class Agent
    {
        /// <summary>
        /// Universally uniquely identifier of the agent.
        /// </summary>
        public Guid ID { get; }

        /// <summary>
        /// Creates an instance of an agent with the given identifier.
        /// </summary>
        /// <param name="id">Universally uniquely identifier.</param>
        public Agent(Guid id) => ID = id;

        /// <summary>
        /// Creates an instance of an agent with a random identifier.
        /// </summary>
        public Agent() => ID = Guid.NewGuid();

        /// <summary>
        /// Returns a string that represents the agent.
        /// </summary>
        /// <returns>A string that represents the agent.</returns>
        public override string ToString() => GetType().Name + "{id = " + ID + "}";
    }
}
