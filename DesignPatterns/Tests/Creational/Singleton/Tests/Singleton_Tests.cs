using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Singleton.Tests
{
    class Singleton_Tests
    {
        [Fact]
        public void GetMessage()
        {
            SingleObject singleton = SingleObject.getInstance();

            Assert.Equal(singleton.ShowMessage(), "The Message");
        }
    }
}
