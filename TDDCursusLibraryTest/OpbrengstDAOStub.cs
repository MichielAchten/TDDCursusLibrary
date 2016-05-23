using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class OpbrengstDAOStub: IOpbrengstDAO
    {
        public decimal FindTotaleOpbrengst()
        {
            return 200m;
        }
    }
}
