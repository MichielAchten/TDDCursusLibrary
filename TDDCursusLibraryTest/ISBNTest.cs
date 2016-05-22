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
    public class ISBNTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetNummer0IsVerkeerd()
        {
            new Isbn(0);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsVerkeerd()
        {
            new Isbn(-9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersIsVerkeerd()
        {
            new Isbn(978902743964L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet14CijfersIsVerkeerd()
        {
            new Isbn(97890274396421L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersEnEenVerkeerdControleGetal2()
        {
            new Isbn(8789027439642L);
        }
        [TestMethod]
        public void NummerMet13CijfersEnEenJuistControleGetal2()
        {
            new Isbn(9789027439642L);    //dit nummer mag geen exception veroorzaken
        }
        
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersEnEenFoutControleGetal0()
        {
            new Isbn(7789027439640L);
        }
        [TestMethod]
        public void NummerMet13CijfersMetJuistControleGetal0()
        {
            new Isbn(9789227439640L);
        }
        
        
        

    }
}
