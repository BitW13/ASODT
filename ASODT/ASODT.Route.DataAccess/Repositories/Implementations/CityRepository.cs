using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASODT.Common.DataAccess.Helpers;
using ASODT.Models.Domains;
using ASODT.Route.DataAccess.Repositories.Interfaces;
using Dapper;

namespace ASODT.Route.DataAccess.Repositories.Implementations
{
    public class CityRepository : ICityRepository
    {
        public async Task<City> GetById(int id)
        {
            string query = $"SELECT * FROM Cities WHERE Id = {id}";

            using (IDbConnection connection = ConnectionHelper.ConnectionFactory())
            {
                return connection.QueryAsync<City>(query).Result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<City>> Get()
        {
            string query = "SELECT * FROM Cities";

            using (IDbConnection connection = ConnectionHelper.ConnectionFactory())
            {
                return connection.QueryAsync<City>(query).Result.ToList();
            }
        }

        public async Task Create(City item)
        {
            string query = "SELECT * FROM Cities";

            using (IDbConnection connection = ConnectionHelper.ConnectionFactory())
            {
                await connection.QueryAsync(
                    sql: StoredProcedures.CREATE_CITY,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task Update(City item)
        {
            string query = "SELECT * FROM Cities";

            using (IDbConnection connection = ConnectionHelper.ConnectionFactory())
            {
                await connection.QueryAsync(
                    StoredProcedures.UPDATE_CITY,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task Delete(int id)
        {
            string query = $"DELETE Cities WHERE Id = {id}";

            using (IDbConnection connection = ConnectionHelper.ConnectionFactory())
            {
                await connection.QueryAsync(query);
            }
        }
    }
}
