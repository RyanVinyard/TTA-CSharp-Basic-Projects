using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterDrill
{
    class TestClass
    {
        public void TestMethod (int data)
        {
            int newData = data / 2;
            Console.WriteLine(data + " divided by 2 is: " + newData);
            return;
        }

        public void OutputMethod (out int output)
        {
            output = 2;
            Console.WriteLine("The Method OutputMethod has the output parameter output. It is an int equal to: " + output);
            return;
        }

        public int SimpleAddition (int input1, int input2)
        {
            int solution = input1 + input2;
            return solution;
        }

        public int SimpleAddition (int input1, int input2, int input3)
        {
            int solution = input1 + input2 + input3;
            return solution;
        }
    }
}
