using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private LandService landService;
        private Mock<ILandDAO> mockFactory;
        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;
            //landDAO = new LandDAOStub();
            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            landService = new LandService(landDAO);
        }
        [TestMethod]
        public void VerhoudingOppervlakteLandTovAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
