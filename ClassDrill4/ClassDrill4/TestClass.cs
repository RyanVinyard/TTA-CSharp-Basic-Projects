using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill4
{
    class TestClass
    {
        public int TestMethod(int required, int optional = 0)
        {
            required = (required + optional) * 2;
            
            return required;
        }
    }
}
