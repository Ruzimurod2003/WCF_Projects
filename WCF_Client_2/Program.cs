using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Client_2.Client_Math;

namespace WCF_Client_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math_ServiceClient proxy = new Math_ServiceClient();
            proxy.DoWorkAsync();
            Console.ReadLine();
        }
    }
}
