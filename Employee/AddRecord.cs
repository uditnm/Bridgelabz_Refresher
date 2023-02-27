using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class AddRecord
    {
        public void add(string constring)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(constring);

                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "spEnterRecords";

                SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter name = new SqlParameter("@name", SqlDbType.VarChar);
                SqlParameter email = new SqlParameter("email", SqlDbType.VarChar);
                SqlParameter join_date = new SqlParameter("@join_date", SqlDbType.Date);
                SqlParameter salary = new SqlParameter("@salary", SqlDbType.Int);

                comm.Parameters.Add(id);
                comm.Parameters.Add(name);
                comm.Parameters.Add(email);
                comm.Parameters.Add(join_date);
                comm.Parameters.Add(salary);

                DateTime date = DateTime.Now;

                Console.WriteLine("Enter id: ");
                id.Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name: ");
                name.Value = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                email.Value = Console.ReadLine();
                join_date.Value = date;
                Console.WriteLine("Enter salary: ");
                salary.Value = Convert.ToInt32(Console.ReadLine());

                con.Open();
                comm.ExecuteNonQuery();
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
