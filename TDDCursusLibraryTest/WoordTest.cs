using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom());
        }
        [TestMethod]
        public void EenLegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord(string.Empty).IsPalindroom());
        }
        
        //[TestMethod]
        //public void EenWoordDatHetzelfdeIsVanVoorNaarAchterAlsVanAchterNaarVoorIsEenPalindroom()
        //{
        //    var woord = new Woord("lepel");
        //    Assert.IsTrue(woord.IsPalindroom());
        //}
        //[TestMethod]
        //public void EenWoordDatNietHetzelfdeIsVanVoorNaarAchterAlsVanAchterNaarVoorIsGeenPalindroom()
        //{
        //    var woord = new Woord("vork");
        //    Assert.IsFalse(woord.IsPalindroom());
        //}
    }
}
