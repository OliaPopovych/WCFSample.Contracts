using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSample.Contracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Country[] GetCountries();

        [OperationContract]
        void PostCountry(Country country);
    }
}
