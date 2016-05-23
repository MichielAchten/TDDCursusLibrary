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
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        [TestInitialize]
        public void Initialize()
        {
            opbrengstDAO = new OpbrengstDAOStub();
            kostDAO = new KostDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
        }
    }
}
