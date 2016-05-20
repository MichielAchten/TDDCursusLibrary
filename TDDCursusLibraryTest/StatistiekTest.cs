using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class StatistiekTest
    {
        [TestMethod]
        public void HetGemiddeldeVan10En15Is12Punt5()
        {
            Assert.AreEqual(12.5m, Statistiek.Gemiddelde(new decimal[] { 10m, 15m }));
        }
        [TestMethod]
        public void HetGemiddeldeVanEenGetalIsDatGetal()
        {
            var enigGetal = 1.23m;
            Assert.AreEqual(enigGetal, Statistiek.Gemiddelde(new decimal[] { enigGetal }));
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetGemiddeldeVanEenLegeVerzamelingKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(new decimal[] { });
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void HetGemiddeldeVanNullKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(null);
        }
    }
}
