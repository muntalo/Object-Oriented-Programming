using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestIdentifiableObject
    {

        IdentifiableObject id;
 
        [SetUp]
        public void SetUp()
        {
            id = new IdentifiableObject(new string[] { "fred", "bob" });
        }


        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(id.AreYou("fred"), "If AreYou returns true when given correct string. (Test #1).");
        }
        
        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(id.AreYou("wilma"), "If AreYou returns false when given wrong string. (Test #2)");
        }

        [Test]
        public void TestCaseSensitivity()
        {
            Assert.IsTrue(id.AreYou("frEd"), "If AreYou is case-sensative. (Test #3)");

        }
        
        [Test]
        public void TestFirstID()
        {
            StringAssert.AreEqualIgnoringCase
                (
                "fred",
                id.FirstId, 
                "If FirstID returns the first id. (Test #4)."
                );
        }
        
        [Test]
        [TestCase("fred")]
        [TestCase("bob")]
        [TestCase("wilma")]
        public void TestAddID(string toTest)
        {
            id.AddIdentifier("wilma");
            Assert.IsTrue(id.AreYou(toTest), "If AreYou returns true when given correct string after a new string is added. (Test #5).");
        }
    }
}