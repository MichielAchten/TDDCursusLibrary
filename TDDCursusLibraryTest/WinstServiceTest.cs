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
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        private Mock<IKostDAO> mockKostDAO;
        private Mock<IOpbrengstDAO> mockOpbrengstDAO;
        [TestInitialize]
        public void Initialize()
        {
            mockKostDAO = new Mock<IKostDAO>();
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            kostDAO = mockKostDAO.Object;
            opbrengstDAO = mockOpbrengstDAO.Object;
            //opbrengstDAO = new OpbrengstDAOStub();
            //kostDAO = new KostDAOStub();
            mockKostDAO.Setup(eenKostDAO => eenKostDAO.FindTotaleKost()).Returns(169m);
            mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.FindTotaleOpbrengst()).Returns(200m);
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.FindTotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.FindTotaleOpbrengst());
        }
    }
}
