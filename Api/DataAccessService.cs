using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Api
{
    public class DataAccessService
    {
        private IConfiguration config;
        public DataAccessService(IConfiguration configuration)
        {
            config = configuration;
        }

        private string ConnectionString
        {
            get
            {
                string _server = config.GetValue<string>("Values.dbHost");
                string _database = config.GetValue<string>("Values.dbDatabase");
                string _username = config.GetValue<string>("Values.dbUser");
                string _password = config.GetValue<string>("Values.dbPassword");

                return ($"Server={_server};Database={_database};User ID={_username};Password={_password};Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }
    }
}
