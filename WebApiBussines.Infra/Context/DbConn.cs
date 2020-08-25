using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WebApiBussines.Infra.Context
{
    public class DbConn
    {
        public SqlConnection conn { get; set; }

        protected IConfiguration _config;

        public DbConn(IConfiguration config)
        {
            _config = config;
            conn = new SqlConnection(_config.GetConnectionString("Conn"));
        }
    }
}
