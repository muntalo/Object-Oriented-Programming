using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CounterTest;
namespace CounterTest
{
    [TestFixture]
    public class TestCounter
    {
        private Counter counterObj;

        [SetUp]
        public void SetUp()
        {
            counterObj = new Counter("Test Counter"); 
        }

        [Test]
        public void CounterTests()
        {
            Assert.AreEqual(0, counterObj.Ticks);
        
            counterObj.Increment();
            Assert.AreEqual(1, counterObj.Ticks);
            
            counterObj.Increment();
            counterObj.Increment();
            counterObj.Increment();
            counterObj.Increment();
            Assert.AreEqual(5, counterObj.Ticks);

            counterObj.Reset();
            Assert.AreEqual(0, counterObj.Ticks);
        }
    }
}