﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void HetHoogsteBodVanEenNieuweVeilingStaatOpNul()
        {
            Assert.AreEqual(0m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void NaEenBodIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            veiling.DoeBod(100m);
            Assert.AreEqual(100m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void NaMeerdereBiedingenIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            veiling.DoeBod(100m);
            veiling.DoeBod(200m);
            veiling.DoeBod(150m);
            Assert.AreEqual(200m, veiling.HoogsteBod);
        }
    }
}
