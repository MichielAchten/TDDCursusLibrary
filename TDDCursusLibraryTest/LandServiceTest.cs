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
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private LandService landService;
        [TestInitialize]
        public void Initialize()
        {
            landDAO = new LandDAOStub();
            landService = new LandService(landDAO);
        }
        [TestMethod]
        public void VerhoudingOppervlakteLandTovAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
        }
    }
}
