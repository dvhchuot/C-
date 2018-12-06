using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceHotelManager.Entity;

namespace WcfServiceHotelManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginApi" in both code and config file together.
    [ServiceContract]
    public interface ILoginApi
    {
        [OperationContract]
        account Login(string username, string password);
        [OperationContract]
        void DoWork();
    }
}
