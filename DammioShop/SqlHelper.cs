using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace DammioShop
{
    public class SqlHelper
    {
        private readonly string connectionString = "Data Source=THANHTUAN;Initial Catalog=dammio_shop;Integrated Security=True;";

        public SqlHelper()
        {
        }

        public DataTable ExecuteDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}