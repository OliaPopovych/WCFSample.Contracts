using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFSample.Service;

namespace WCFSample.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(CountryService));

            host.Open();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
    }
}
