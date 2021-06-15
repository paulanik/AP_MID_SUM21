using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace LabTask2_MVC.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-C81R62A\SQLEXPRESS;Database=Students;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);

        }
    }
}