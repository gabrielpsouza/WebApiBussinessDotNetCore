using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiBussines.Infra.Context
{
    public class MongoContext<T> where T : class
    {
        protected IConfiguration _config;

        public IMongoCollection<T> Collection { get; set; }

        public MongoContext(string databasename, string collectionName)
        {
            IMongoClient client = new MongoClient(_config.GetConnectionString("MongoConn"));
            var database = client.GetDatabase(databasename);
            this.Collection = database.GetCollection<T>(collectionName);
        }
    }
}
