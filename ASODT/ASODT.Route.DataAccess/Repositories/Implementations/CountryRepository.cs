using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASODT.Models.Domains;
using ASODT.Route.DataAccess.Repositories.Interfaces;

namespace ASODT.Route.DataAccess.Repositories.Implementations
{
    public class CountryRepository : ICountryRepository
    {
        public async Task<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task Create(Country item)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Country item)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
