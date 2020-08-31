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

        public BussinessModel GetByIdBussiness(int id)
        {
            string sqlQuery = $"select * from bussines where bussinessid = " + id;

            return conn.Query<BussinessModel>(sqlQuery).FirstOrDefault();
        }

        public ReturnModel PostBussiness(BussinessModel model)
        {
            ReturnModel retorno = new ReturnModel();
            

            string sqlQuery = @"insert into bussines values(@NameBussiness, @Phone, @Email, @Document);
                                SELECT TOP 1 bussinessid FROM bussines ORDER BY bussinessid DESC;";

            retorno.BusssinessId = conn.Query<int>(sqlQuery, model).Single();

            if (retorno.BusssinessId != 0)
            {
                retorno.Retorno = "Dados inseridos!";
                return retorno;
            }
            else
            {
                retorno.Retorno = "Errrrou";
            }

            return retorno;
        }
    
        public void DeleteBussiness(int id)
        {
            string sqlQuery = $"delete from bussines where bussinessid = " + id;

            conn.Query<ReturnModel>(sqlQuery).FirstOrDefault();
        }
    }
}
