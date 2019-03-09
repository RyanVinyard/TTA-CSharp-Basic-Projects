using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class TestClass
    {
        public int TestMethod(int userInteger)
        {
            userInteger = userInteger + 10;
            return userInteger;
        }

        public double TestMethod(double userDecimal)
        {
            userDecimal = userDecimal * 2;
            return userDecimal;
        }

        public string TestMethod(string userString)
        {
            int temp = Convert.ToInt32(userString);
            temp = temp / 2;
            
            userString = Convert.ToString(temp);




            return userString;            
        }
    }
}
