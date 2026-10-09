using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.Services;

namespace CarSimulator.Test
{
    public class DirectionStrategyTests
    {
        [Fact]
        public void TurnLeftStrategy_ShouldBeInstantiable()
        {
            var strategy = new TurnLeftStrategy();
            Assert.NotNull(strategy);
        }
        [Fact]
        public void TurnRightStrategy_ShouldBeInstantiable()
        {
            var strategy = new TurnRightStrategy();
            Assert.NotNull(strategy);
        }
        [Fact]
        public void DriveforwardStrateg_ShouldBeInstantiable()
        {
            var strategy = new DriveForwardStrategy();
            Assert.NotNull(strategy);
        }
        [Fact]
        public void ReverseStrategy_ShouldBeInstantiable()
        {
            var strategy = new ReverseStrategy();
            Assert.NotNull(strategy);
        }
    
    }
}

    