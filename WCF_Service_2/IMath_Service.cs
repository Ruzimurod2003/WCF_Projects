using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_2
{
    [ServiceContract]
    public interface IMath_Service
    {
        [OperationContract]
        void DoWork();
    }
}
