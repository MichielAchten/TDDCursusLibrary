using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Isbn
    {
        private const long GrootsteGetalMet13Cijfers = 9999999999999L;
        private const long KleinsteGetalMet13Cijfers = 1000000000000L;
        private long nummer;
        public Isbn(long nummer)
        {
            if (nummer < KleinsteGetalMet13Cijfers || nummer > GrootsteGetalMet13Cijfers)
            {
                throw new ArgumentException();
            }
            var somEvenCijfers = 0L;
            var somOnevenCijfers = 0L;
            var teVerwerkenCijfers = nummer / 10;
            for (int teller = 0; teller != 6; teller++)
            {
                somEvenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
                somOnevenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
            }
            var controlegetal = somEvenCijfers * 3 + somOnevenCijfers;
            var naastGelegenHoger10Tal = controlegetal - controlegetal % 10 + 10;
            var verschil = naastGelegenHoger10Tal - controlegetal;
            var laatsteCijfer = nummer % 10;
            if (verschil == 10)
            {
                if (laatsteCijfer != 0)
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                if (laatsteCijfer != verschil)
                {
                    throw new ArgumentException();
                }
            }
            this.nummer = nummer;
        }
        public override string ToString()
        {
            return nummer.ToString();
        }
    }
}
