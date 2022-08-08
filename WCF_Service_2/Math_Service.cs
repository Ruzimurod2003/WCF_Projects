using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_2
{
    public class Math_Service : IMath_Service
    {
        public void DoWork()
        {
            Console.WriteLine("Salom dunyo");
        }
    }
}
