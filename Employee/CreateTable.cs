using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class CreateTable
    {
        public void createTable(string constring)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(constring);
                SqlCommand cm = new SqlCommand("create table employee(id int not null, name varchar(100), email varchar(50), join_date date, salary int)", con);

                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
