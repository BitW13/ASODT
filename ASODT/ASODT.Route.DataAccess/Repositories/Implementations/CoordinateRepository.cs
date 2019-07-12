using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASODT.Models.Domains;
using ASODT.Route.DataAccess.Repositories.Interfaces;

namespace ASODT.Route.DataAccess.Repositories.Implementations
{
    public class CoordinateRepository : ICoordinateRepository
    {
        public async Task<Coordinate> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coordinate>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task Create(Coordinate item)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Coordinate item)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
