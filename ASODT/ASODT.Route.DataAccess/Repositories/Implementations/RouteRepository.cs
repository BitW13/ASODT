using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASODT.Route.DataAccess.Repositories.Interfaces;

namespace ASODT.Route.DataAccess.Repositories.Implementations
{
    public class RouteRepository : IRouteRepository
    {
        public async Task<Models.Domains.Route> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Models.Domains.Route>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task Create(Models.Domains.Route item)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Models.Domains.Route item)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
