using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace asp_net_core_mvc_mysql_dashboard.Models
{
    public class SalesDBContext
    {
        public string ConnectionString { get; set; }
        public SalesDBContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
    
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    
        public List<Sale> GetTopSales()
        {
            List<Sale> list = new List<Sale>();
        
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sales LIMIT 2000", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Sale(){
                            id = reader.GetInt32("id"),
                            date = reader.GetDateTime("date"),
                            product = reader.GetString("product"),
                            price = reader.GetDouble("price"),
                            count = reader.GetInt32("count"),
                            region = reader.GetString("region")
                        });
                    }
                }
            }
            return list;
        }
    }
}