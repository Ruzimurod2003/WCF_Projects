using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in both code and config file together.
    public class MathService : IMathService
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
