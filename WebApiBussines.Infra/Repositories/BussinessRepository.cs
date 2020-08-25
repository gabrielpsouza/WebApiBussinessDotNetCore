using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebApiBussines.Domain.Models;
using WebApiBussines.Infra.Context;
using WebApiBussines.Infra.Interface;

namespace WebApiBussines.Infra.Repositories
{
    public class BussinessRepository : DbConn, IBussinessRepository
    {
        public BussinessRepository(IConfiguration config) : base(config) { }

        public List<BussinessModel> GetBussiness() 
        {
            string sqlQuery = "select * from bussines";

            return conn.Query<BussinessModel>(sqlQuery).ToList();
        }

        public List<BussinessModel> GetByIdBussiness(int id)
        {
            string sqlQuery = $"select * from bussines where bussinessid = " + id;

            return conn.Query<BussinessModel>(sqlQuery).ToList();
        }
    }
}
