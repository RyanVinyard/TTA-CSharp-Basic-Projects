using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    public class MathMagic
    {
        private int addResult = 0;
        private int subResult = 0;
        private int multResult = 0;
        public MathMagic()
        {

        }
        public int Addition(int myNumber)
        {
            int addResult = myNumber + 10;
            return addResult;         
        }

        public int Subtraction(int myNumber)
        {
            int subResult = myNumber - 100;
            return subResult;
        }

        public int Multiplication(int myNumber)
        {
            int multResult = myNumber * 3;
            return multResult;
        }
    }
}
