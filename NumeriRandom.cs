using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public class NumeriRandom
    {
        public int NumIntRan;

        public NumeriRandom(int NumIntRan)
        {
            this.NumIntRan = IntNum();
        }
        public int getNumRan() { return this.NumIntRan; }



        private int IntNum()
        {
            Random random = new();
            return random.Next(1, 99999999);
        }
        private double DoubleNum()
        {
            Random random = new();
            return random.Next(1, 99999999);
        }
    }
}
