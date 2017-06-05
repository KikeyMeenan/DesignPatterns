using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Creational.FactoryMethod.Tests
{
    public class CarInstructions_Tests
    {
        [Fact]
        public void ReadInstructions_Auto()
        {
            var expected = new List<string>()
            {
                "Turn Key Forward",
                "Do Nothing",
                "Turn Key Backward"
            };
            var result = CarInstructions.GetInstructions(true);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReadInstructions_Manual()
        {
            var expected = new List<string>()
            {
                "Turn Key Forward",
                "Put down clutch and move stick",
                "Turn Key Backward"
            };
            var result = CarInstructions.GetInstructions(false);
            Assert.Equal(expected, result);
        }
    }
}
