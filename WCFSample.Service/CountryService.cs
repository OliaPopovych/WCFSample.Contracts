using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFSample.Contracts;

namespace WCFSample.Service
{
    public class CountryService : IService
    {
        public Country[] GetCountries()
        {
            return new[]
            {
                new Country { CountryId = 1, PostalCode = "345", CountryName = "Ukr" },
                new Country { CountryId = 2, PostalCode = "340", CountryName = "Usa" }
            };
        }

        public void PostCountry(Country country)
        {
            var newCountry = country;
        }
    }
}
