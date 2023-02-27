using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class DeleteRecord
    {
        public void delete(string constring)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(constring);
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "spDeleteRecord";

                SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                comm.Parameters.Add(id);

                Console.WriteLine("Enter id: ");
                id.Value = Convert.ToInt32(Console.ReadLine());

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
