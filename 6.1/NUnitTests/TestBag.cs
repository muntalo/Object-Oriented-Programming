using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestBag
    {

        Bag bag;
        Bag bag2;
        Item shovel;
        Item sword;
 
        [SetUp]
        public void SetUp()
        {
            bag = new Bag(new string[] { "bag", "backpack" }, "a bag", "A mighty fine bag");
            bag2 = new Bag(new string[] { "other bag", "backpack" }, "a bag", "A mighty fine secondary bag");
            shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "A mighty fine shovel");
            sword = new Item(new string[] { "sword", "weapon" }, "a sword", "A mighty fine sword");
        }


        [Test]
        public void TestLocate()
        {
            bag.Inventory.Put(shovel);
            Assert.AreEqual(
                shovel,
                bag.Locate("shovel"));
        }
        
        [Test]
        public void TestLocateSelf()
        {
            Assert.AreEqual(
                bag,
                bag.Locate("bag"));
        }

        [Test]
        public void TestLocateNothing()
        {
            Assert.AreEqual(
                null,
                bag.Locate("gun"));
        }

        [Test]
        public void TestFullDescription()
        {
            bag.Inventory.Put(shovel);
            Assert.AreEqual(
            "In the a bag you can see: \n\ta shovel (shovel)\n",
            bag.FullDescription);

        }

        [Test]
        public void TestBagInBag()
        {
            bag2.Inventory.Put(sword);
            bag.Inventory.Put(bag2);
            bag.Inventory.Put(shovel);

            Assert.AreEqual(      //Bag can locate other bag (bag2).
                bag2,
                bag.Locate("other bag"));

            Assert.AreEqual(      //Bag can locate other items in itself.
                shovel,
                bag.Locate("shovel"));
        
            Assert.AreEqual(       //Bag cant locate items inside other bag.
                null,
                bag.Locate("sword"));
        }
    }
}