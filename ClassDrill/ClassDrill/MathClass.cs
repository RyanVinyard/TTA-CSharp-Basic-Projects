using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class MathClass
    {
        public MathClass()
        {
            Value = 1;
        }

        public int MathMethod1(int userInput)
        {
            userInput = userInput + 12;

            return userInput;
        }

        public int MathMethod2(int userInput)
        {
            userInput = userInput * 3;

            return userInput;
        }

        public int MathMethod3(int userInput)
        {
            userInput = userInput / 2;

            return userInput;
        }
        public int Value { get; set; }

    }
}
