using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen_alan_cevre
{
    internal class dikdortgen
    {
        private int a, b;
        public dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int alanHesaplama()
        {
            return a * b;
        }
        public int cevreHesaplama()
        {
            return (a + b) * 2;
        }
    }
}
