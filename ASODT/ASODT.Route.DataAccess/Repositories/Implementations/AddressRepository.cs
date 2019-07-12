using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASODT.Models.Domains;
using ASODT.Route.DataAccess.Repositories.Interfaces;

namespace ASODT.Route.DataAccess.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        public async Task<Address> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Address>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task Create(Address item)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Address item)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
