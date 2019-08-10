using System;
using Xunit;

namespace Simbolyc.Swarm
{
    /// <summary>
    /// Unit tests for <see cref="Agent"/>.
    /// </summary>
    public sealed class AgentTest
    {
        [Fact]
        public void DefaultConstructor()
        {
            Agent first = new Agent();
            Agent second = new Agent();

            // Check not empty
            Assert.NotEqual(Guid.Empty, first.ID);
            Assert.NotEqual(Guid.Empty, second.ID);

            // Check random
            Assert.NotEqual(first.ID, second.ID);
        }

        [Fact]
        public void Constructor()
        {
            Guid id = Guid.NewGuid();
            Assert.Equal(id, new Agent(id).ID);
        }

        [Fact]
        public void StringConversion()
        {
            Agent agent = new Agent();
            string agentStr = agent.ToString();

            Assert.Contains(agent.GetType().Name, agentStr);
            Assert.Contains(agent.ID.ToString(), agentStr);
        }
    }
}
