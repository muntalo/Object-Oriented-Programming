using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestPlayer
    {

        Player id;
        Item shovel;

        [SetUp]
        public void SetUp()
        {
            id = new Player("Muntazar", "player");
            shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "A mighty fine shovel");
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void PlayerIsIdentifiable(string toTest)
        {
            Assert.IsTrue(id.AreYou(toTest));
        }

        [Test]
        public void PlayerLocatesItem()
        {
            id.Inventory.Put(shovel);
            Assert.AreEqual(
                shovel,
                id.Locate("shovel"));
        }
        
        [Test]
        public void PlayerLocatesItself()
        {
            id.Inventory.Put(shovel);
            Assert.AreEqual(
                id,
                id.Locate("me"));
        }

        [Test]
        public void PlayerLocatesNothing()
        {
            id.Inventory.Put(shovel);
            Assert.AreEqual(
                null,
                id.Locate("nothing"));
        }

        [Test]
        public void FullDescription()
        {
            Assert.AreEqual(
            "You are Muntazar player.\nYou are carring",
            id.FullDescription);
        }
    }
}