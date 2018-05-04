using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFSample.Contracts;

namespace WCFSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {   
            var channel = new ChannelFactory<IService>(new BasicHttpBinding(), new EndpointAddress("http://localhost:9000/CountryService"));
            var client = channel.CreateChannel();

            client.PostCountry(new Country() { CountryId = 3, PostalCode = "345", CountryName = "Ger" });

            Console.ReadKey();
        }
    }
}
