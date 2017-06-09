using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Singleton.Tests
{
    public class Singleton_Tests
    {
        [Fact]
        public void CallSingleton()
        {
            SingleObject singleton = SingleObject.getInstance();

            singleton.CallSingleton();

            Assert.Equal(singleton.CallCount, 1);

            SingleObject singleton2 = SingleObject.getInstance();

            singleton2.CallSingleton();

            Assert.Equal(singleton2.CallCount, 2);
        }
    }
}