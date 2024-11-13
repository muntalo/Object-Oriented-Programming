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
    public class TestClock
    {
        private Clock clockObj;
        [SetUp]
        public void SetUp()
        {
            clockObj = new Clock("Test Counter");
        }

        [Test]
        public void InitialisingCounter()
        {
            Assert.AreEqual("00:00:00", clockObj.Time);
        }

        [Test]
        public void IncrementingOne()
        {
            clockObj.Increment();
            Assert.AreEqual("00:00:01", clockObj.Time);
        }

        [Test]
        public void Incrementing60()
        { 
            for (int i = 0; i< 60; i++)
            {
                clockObj.Increment();
            }
            Assert.AreEqual("00:01:00", clockObj.Time);
        }

        [Test]
        public void Incrementing3600()
        {
            for (int i = 0; i < 3600; i++)
            {
                clockObj.Increment();
            }
            Assert.AreEqual("01:00:00", clockObj.Time);
        }

        [Test]
        public void Incrementing86400() 
        { 
            for (int i = 0; i < 86400; i++)
            {
                clockObj.Increment();
            }
            Assert.AreEqual("24:00:00", clockObj.Time);
        }

        [Test]
        public void ResetingClock()
        {
            clockObj.Reset();
            Assert.AreEqual("00:00:00", clockObj.Time);
        }
    }
}