using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLass_Libary;
using System;

namespace FootBallPlayerTest
{
    [TestClass]
    public class UnitTest1
    {
        private CLass_Libary.FootBallPlayer Player;

        [TestInitialize]
        public void CreatPlayer()
        {

            Player = new CLass_Libary.FootBallPlayer(1, "Boris", 2, 3);
        }
        [TestMethod]
        public void TestingConstructorInput()
        {
            Assert.AreEqual(1, Player.Id);
            Assert.AreEqual("Boris", Player.Name);
            Assert.AreEqual(2, Player.Price);
            Assert.AreEqual(3, Player.ShirtNumber);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Name must contain atlesat 4 characters")]
        public void TestingConstructorName()
        {
            Player = new CLass_Libary.FootBallPlayer(1, "Bor", 2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Price must be over 0")]
        public void TestingConstructorPrice()
        {
            Player = new CLass_Libary.FootBallPlayer(1, "Boris", 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "You must place a value higher then 0 and between 0 and 101")]
        public void TestingConstructorShirtNrLow()
        {
            Player = new CLass_Libary.FootBallPlayer(1, "Boris", 1, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "You must place a value higher then 0 and between 0 and 101")]
        public void TestingConstructorShirtNrHigh()
        {
            Player = new CLass_Libary.FootBallPlayer(1, "Boris", 1, 101);
        }


        [TestMethod]
        public void TestingConstructorNoInput()
        {
            Player = new CLass_Libary.FootBallPlayer();
            Assert.AreEqual(0, Player.Id);
            Assert.AreEqual(null, Player.Name);
            Assert.AreEqual(0, Player.Price);
            Assert.AreEqual(0, Player.ShirtNumber);

        }
        [TestMethod]
        public void AddingNameToPlayer()
        {
            Player.Name = "Morten";
            Assert.AreEqual("Morten", Player.Name);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Name must contain atlesat 4 characters")]
        public void AddingNoneValidNameToPlayer()
        {
            // Because we know no footballplayer can be named bo
            Player.Name = "Bo";

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]

        public void AddingNullNameToPlayer()
        {
            Player.Name = null;
        }

        [TestMethod]
        public void Adding4CharNameToPlayer()
        {

            Player.Name = "Bebo";
            Assert.AreEqual("Bebo", Player.Name);

        }
        [TestMethod]
        public void Adding3CharNameToPlayer()
        {
            try
            {
                Player.Name = "Beb";
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }
        [TestMethod]
        public void SettingPrice1Player()
        {
            Player.Price = 1;
            Assert.AreEqual(1, Player.Price);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Price must be over 0")]
        public void SettingPrice0ToPlayer()
        {
            Player.Price = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "You must place a value higher then 0 and between 0 and 101")]
        public void SettingShirt0Player()
        {
            Player.ShirtNumber = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "You must place a value higher then 0 and between 0 and 101")]
        public void SettingShirt101Player()
        {
            Player.ShirtNumber = 101;
        }
        [TestMethod]
        public void SettingShirt100Player()
        {
            Player.ShirtNumber = 100;
            Assert.AreEqual(100, Player.ShirtNumber);
        }
        [TestMethod]
        public void SettingShirt1Player()
        {
            Player.ShirtNumber = 1;
            Assert.AreEqual(1, Player.ShirtNumber);
        }



    }
}

