using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DammioShop
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    //SqlHelper sqlHelper = new SqlHelper();
                    //string sqlQuery = "SELECT * FROM clothings";

                    //// Using DataTable
                    //DataTable dataTable = sqlHelper.ExecuteDataTable(sqlQuery);
                    //DataRow[] rows = dataTable.Select();
                    //foreach (DataRow row in rows)
                    //{
                    //    var id = row["id"];
                    //    var name = row["name"];
                    //    var description = row["description"];
                    //    var price = row["price"];

                    //    Response.Write($"ID: {id}, Name: {name}, Description: {description}, Price: {price}<br>");
                    //}

                    // Using SqlCommand
                    //string connectionString = "Data Source=THANHTUAN;Initial Catalog=dammio_shop;Integrated Security=True;";
                    //SqlConnection connection = new SqlConnection(connectionString);
                    //connection.Open();
                    //SqlCommand command = new SqlCommand(sqlQuery, connection);
                    //SqlDataReader reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    var id = reader["id"];
                    //    var name = reader["name"];
                    //    var description = reader["description"];
                    //    var price = reader["price"];

                    //    Response.Write($"ID: {id}, Name: {name}, Description: {description}, Price: {price}<br>");
                    //}
                    //connection.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}