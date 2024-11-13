using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SwinAdventures
{
    [TestFixture]
    public class TestLookCommand
    {
        Player player;
        Bag bag;
        Item shovel;
        Item gem;
        LookCommand look;

        [SetUp]
        public void SetUp()
        {
            look = new LookCommand();
            player = new Player("Muntazar", "player");
            bag = new Bag(new string[] { "bag", "backpack" }, "bag", "A mighty fine bag");
            shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "A mighty fine shovel");
            gem = new Item(new string[] { "gem", "shiny" }, "a gem", "A shiny red gem...");
        }


        [Test]
        public void TestLookAtSelf()
        {
            player.Invetory.Put(gem);
            player.Invetory.Put(bag);
            Assert.AreEqual(
                "You are Muntazar player.\nYou are carring\ta gem (gem)\n\tbag (bag)\n",
                look.Execute(player, new string[] { "look", "at", "inventory" }));
        }


        [Test]
        public void LookAtGem()
        {
            player.Invetory.Put(gem);
            Assert.AreEqual(
                "A shiny red gem...",
                look.Execute(player, new string[] { "look", "at", "gem" }));
        }


        [Test]
        public void LookAtUknown()
        {
            Assert.AreEqual(
                "Cant find \"gem\".",
                look.Execute(player, new string[] { "look", "at", "gem" }));
        }


        [Test]
        public void LookAtGemInMe()
        {
            player.Invetory.Put(gem);
            Assert.AreEqual(
                "A shiny red gem...",
                look.Execute(player, new string[] { "look", "at", "gem", "in", "inventory" }));
        }


        [Test]
        public void LookAtGemInBag()
        {
            bag.Inventory.Put(gem);      //Puts gem in bag
            player.Invetory.Put(bag);    // Puts bag in player
            Assert.AreEqual(
                "A shiny red gem...",
                look.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }));
        }


        [Test]
        public void LookAtGemInNoBag()
        {
            Assert.AreEqual(
                "Cant find \"bag\".",
                look.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }));
        }


        [Test]
        public void LookAtNoGemInBag()
        {
            player.Invetory.Put(bag);    // Puts bag in player
            Assert.AreEqual(
                "Cant find \"gem\".",
                look.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }));
        }


        [Test]
        public void InvalidLook()
        {
            Assert.AreEqual(
                "I don't know how to look at that.",
                look.Execute(player, new string[] { "look", "at", "gem", "in" }));
            Assert.AreEqual(
                "Error in look input.",
                look.Execute(player, new string[] { "what", "at", "gem", "in", "bag" }));
            Assert.AreEqual(
                "What do you want to look at?",
                look.Execute(player, new string[] { "look", "hello", "gem", "in", "bag" }));
            Assert.AreEqual(
                "What do you want to look in?",
                look.Execute(player, new string[] { "look", "at", "gem", "out", "bag" }));
        }
    }
}