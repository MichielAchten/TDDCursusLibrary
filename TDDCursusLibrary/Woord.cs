using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Woord
    {
        private readonly string woord;
        public Woord(string woord)
        {
            this.woord = woord;
        }
        public bool IsPalindroom()
        {
            var omgekeerd = new string(woord.ToArray().Reverse().ToArray());
            return woord == omgekeerd;
        }

        //public Woord(string eenWoord)
        //{
        //    EenWoord = eenWoord;
        //}
        //public string EenWoord { get; set; }
        //public bool IsPalindroom()
        //{
        //    bool isPalindroom = true;
        //    for (int begin = 0, einde = EenWoord.Length - 1; begin < einde; begin++, einde--)
        //    {
        //        if (EenWoord[begin] != EenWoord[einde])
        //        {
        //            isPalindroom = false;
        //            break;
        //        }
        //    }
        //    return isPalindroom;
        //}
    }
}
