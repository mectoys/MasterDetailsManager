using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL.Repositories
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
