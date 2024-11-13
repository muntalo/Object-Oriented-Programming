using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestItem
    {

        Item id;
 
        [SetUp]
        public void SetUp()
        {
            id = new Item(new string[] { "shovel", "spade" }, "a shovel", "A mighty fine shovel");
        }


        [Test]
        public void TestItemisIdentifiable()
        {
            Assert.IsTrue(id.AreYou("shovel"));
        }
        
        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual("a shovel (shovel)", id.ShortDescription);
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual("A mighty fine shovel", id.FullDescription);

        }
    }
}