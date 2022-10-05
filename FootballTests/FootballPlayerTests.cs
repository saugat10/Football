using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void ValidateName()
        {
            var player = new FootballPlayer() { Id = 1, Name = null, Age = 5, ShirtNumber = 18 };
            Assert.ThrowsException<ArgumentNullException>(() => player.ValidateName());

            var playerName = new FootballPlayer() { Id = 1, Name = "s", Age = 5, ShirtNumber = 18 };
            Assert.ThrowsException<ArgumentException>(() => playerName.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            var playerAge = new FootballPlayer() { Id = 1, Name = "Sabin Bhandari", Age = 0, ShirtNumber = 23 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAge.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            var playerShirtNumber = new FootballPlayer() { Id = 1, Name = "Sabin Ghimire", Age = 22, ShirtNumber = 0 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumber.ValidateShirtNumber());

            var playerShirt = new FootballPlayer() { Id = 2, Name = "Saugat Khatiwada", Age = 25, ShirtNumber = 100 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirt.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateToStringMethod()
        {
           
            var playerShirtNumber = new FootballPlayer() { Id = 1, Name = "Sabin Ghimire", Age = 22, ShirtNumber = 22 };
            Assert.AreEqual("The player with id 1 has name Sabin Ghimire age is 22 and wears a shirt number 22", playerShirtNumber.ToString());
        }
    }
}