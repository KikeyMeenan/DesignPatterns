using Xunit;

namespace DesignPatterns.Behavioural.TemplateMethod.Tests
{
    public class CarInstructions_Tests
    {
        [Fact]
        public void ReadInstructions_Auto()
        {
            var expected = "Turn Key Forward, Do Nothing, Turn Key Backward";
            var result = CarInstructions.TestDriveCar(true);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReadInstructions_Manual()
        {
            var expected = "Turn Key Forward, Put down clutch and move stick, Turn Key Backward";
            var result = CarInstructions.TestDriveCar(false);
            Assert.Equal(expected, result);
        }
    }
}
