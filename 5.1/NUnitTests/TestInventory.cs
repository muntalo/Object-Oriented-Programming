using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestInventory
    {

        Inventory id;
        Item shovel;
        Item sword;
 
        [SetUp]
        public void SetUp()
        {
            id = new Inventory();
            shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "A mighty fine shovel");
            sword = new Item(new string[] { "sword", "weapon" }, "a sword", "A mighty fine sword");

            id.Put(shovel);
        }


        [Test]
        public void TestFindItem()
        {
            Assert.IsTrue(
                id.HasItem("shovel"));
        }
        
        [Test]
        public void TestNoItemFind()
        {
            Assert.IsFalse(
                id.HasItem("sword"));
        }

        [Test]
        public void TestFetchItem()
        {
            Assert.AreEqual(
                shovel, 
                id.Fetch("shovel"));
        }

        [Test]
        public void TestTakeItem()
        {
            //id.Take("shovel");
            Assert.AreEqual(
                shovel, 
                id.Take("shovel"));

        }
        
        [Test]
        public void TestItemList()
        {
            //id.Put(shovel);
            id.Put(sword);
            Assert.AreEqual(
                "\ta shovel (shovel)\n\ta sword (sword)\n",
                id.ItemList);
        }
    }
}