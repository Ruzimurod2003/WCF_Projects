using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF_Service_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Math_Service));
            host.Open();
            Console.WriteLine("Jarayon boshlandi.....");
            Console.ReadLine();
            host.Close();
        }
    }
}
